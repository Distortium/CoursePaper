using System;
using System.Windows.Forms;

namespace CoursePaper
{
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private Game gameData;

        public Form1()
        {
            InitializeComponent();
            label5.Visible = false;
            RateEatPredatorsTextBox.Visible = false;
            label6.Visible = false;
            RateDeadHungryPredatorsTextBox.Visible = false;
            label7.Visible = false;
            RateReproductionPredatorsTextBox.Visible = false;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (gameData != null)
            {
                gameData.Play = true;
                return;
            }
            /*gameData = new Game(
                int.Parse(CountVictimsTextBox.Text),
                int.Parse(CountPredatorsTextBox.Text),
                int.Parse(RateReproductionVictimsTextBox.Text),
                int.Parse(RateEatPredatorsTextBox.Text),
                int.Parse(RateDeadHungryPredatorsTextBox.Text),
                int.Parse(RateReproductionPredatorsTextBox.Text),
                int.Parse(XSizeGameTextBox.Text), int.Parse(YSizeGameTextBox.Text));*/
            int r;
            gameData = new Game();

            if (int.TryParse(CountVictimsTextBox.Text, out r) && r > 0)
                gameData.CountVictims = r;
            else
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }
            if (int.TryParse(CountPredatorsTextBox.Text, out r) && r > 0)
                gameData.CountPredators = r;
            else
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }
            if (float.TryParse(RateReproductionVictimsTextBox.Text, out var t) && t > 0)
                gameData.RateReproductionVictims = t;
            else
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }

            if (int.TryParse(XSizeGameTextBox.Text, out r) && r > 0)
            {
                if (r > 50)
                {
                    gameData = null;
                    MessageBox.Show($"Превышен размер поля, максимум 50");
                    return;
                }
                else
                    GameView.ColumnCount = r;
            }
            else
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }
            if (int.TryParse(YSizeGameTextBox.Text, out r) && r > 0)
            {
                if (r > 50)
                {
                    MessageBox.Show($"Превышен размер поля, максимум 50");
                    gameData = null;
                    return;
                }
                else
                    GameView.RowCount = r;
            }
            else
            {
                MessageBox.Show("Неверный ввод данных");
                return;
            }

            if (gameData.CountVictims + gameData.CountPredators >= GameView.ColumnCount * GameView.RowCount)
            {
                MessageBox.Show("Количество хищников и жертв превышает размер поля");
                return;
            }

            for (int i = 0; i < GameView.RowCount; i++)
                for (int j = 0; j < GameView.ColumnCount; j++)
                    GameView.Rows[i].Cells[j].Value = '\0';

            int countV = gameData.CountVictims, countP = gameData.CountPredators;
            Vector2Int pos;
            while (countP > 0 || countV > 0)
            {
                if (countV > 0)
                {
                    pos = new Vector2Int(rnd.Next(GameView.RowCount), rnd.Next(GameView.ColumnCount));
                    if (ContainsNullInCell(pos))
                    {
                        GameView.Rows[rnd.Next(GameView.RowCount)].Cells[rnd.Next(GameView.ColumnCount)].Value = '\t';
                        countV--;
                    }
                }
                if (countP > 0)
                {
                    pos = new Vector2Int(rnd.Next(GameView.RowCount), rnd.Next(GameView.ColumnCount));
                    if (ContainsNullInCell(pos))
                    {
                        GameView.Rows[rnd.Next(GameView.RowCount)].Cells[rnd.Next(GameView.ColumnCount)].Value = '\n';
                        countP--;
                    }
                }
            }
            GameView.ColumnHeadersVisible = false;
            GameView.RowHeadersVisible = false;
            GameView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            GameView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GameView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;

            gameData.Play = true;
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (gameData != null)
                gameData.Play = false;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (gameData != null)
            {
                gameData = null;

                DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                cellStyle.BackColor = System.Drawing.Color.Green;
                for (int i = 0; i < GameView.RowCount; i++)
                    for (int j = 0; j < GameView.ColumnCount; j++)
                    {
                        GameView.Rows[i].Cells[j].Value = '\0';
                        GameView.Rows[i].Cells[j].Style = cellStyle;
                    }
                ChartModel.Series[0].Points.Clear();
                ChartModel.Series[1].Points.Clear();
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (gameData == null || !gameData.Play || !gameData.CanStartGame()) return;
            Vector2Int resultPos;
            bool findNearTarget;
            for (int i = 0; i < GameView.RowCount; i++)
            {
                for (int j = 0; j < GameView.ColumnCount; j++)
                {
                    RefreshDrawCell(i, j);
                    findNearTarget = false;
                    if (GameView.Rows[i].Cells[j].Value.Equals('\n'))
                    {
                        // Поиск добычи
                        foreach (var offset in new Vector2Int[] 
                        { new Vector2Int(1, 0), new Vector2Int(-1, 0),
                        new Vector2Int(0, 1), new Vector2Int(0, -1)})
                        {
                            resultPos = new Vector2Int(i, j);

                            if (!(resultPos.x == 0 && offset.x == -1) && !(resultPos.x == GameView.ColumnCount - 1 && offset.x == 1))
                                resultPos.x += offset.x;
                            if (!(resultPos.y == 0 && offset.y == -1) && !(resultPos.y == GameView.ColumnCount - 1 && offset.y == 1))
                                resultPos.y += offset.y;

                            if (GameView.Rows[resultPos.x].Cells[resultPos.y].Value.Equals('\t') || 
                                GameView.Rows[resultPos.x].Cells[resultPos.y].Value.Equals('1'))
                            {
                                GameView.Rows[i].Cells[j].Value = '\0';
                                GameView.Rows[resultPos.x].Cells[resultPos.y].Value = '0';
                                findNearTarget = true;
                                RefreshDrawCell(resultPos.x, resultPos.y);
                                RefreshDrawCell(i, j);
                                break;
                            }
                        }

                        // Обычное передвижение
                        if (!findNearTarget)
                        {
                            resultPos = new Vector2Int(i, j);
                            if (rnd.Next(2) == 0)
                                resultPos.x += rnd.Next(i > 0 ? -1 : 0, i < GameView.ColumnCount - 1 ? 2 : 1);
                            else
                                resultPos.y += rnd.Next(j > 0 ? -1 : 0, j < GameView.RowCount - 1 ? 2 : 1);

                            if (ContainsNullInCell(resultPos.x, resultPos.y))
                            {
                                GameView.Rows[i].Cells[j].Value = '\0';
                                GameView.Rows[resultPos.x].Cells[resultPos.y].Value = '0';
                                RefreshDrawCell(resultPos);
                                RefreshDrawCell(i, j);
                            }
                        }
                    }
                    else if (GameView.Rows[i].Cells[j].Value.Equals('\t'))
                    {
                        // Размножение
                        if (gameData.NowRateReproductionVictims > 0)
                            gameData.NowRateReproductionVictims -= (float)GameTimer.Interval / 1000;
                        else
                        {
                            gameData.NowRateReproductionVictims = gameData.RateReproductionVictims;
                            if (ContainsNearInCell(new Vector2Int(i, j), '\t', out _))
                            {
                                if (ContainsNearInCell(new Vector2Int(i, j), '\0', out resultPos))
                                {
                                    GameView.Rows[resultPos.x].Cells[resultPos.y].Value = '1';
                                    findNearTarget = true;
                                    RefreshDrawCell(resultPos);
                                }
                            }
                        }

                        // Обычное передвижение
                        if (!findNearTarget)
                        {
                            resultPos = new Vector2Int(i, j);
                            if (rnd.Next(2) == 0)
                                resultPos.x += rnd.Next(i > 0 ? -1 : 0, i < GameView.ColumnCount - 1 ? 2 : 1);
                            else
                                resultPos.y += rnd.Next(j > 0 ? -1 : 0, j < GameView.RowCount - 1 ? 2 : 1);

                            if (ContainsNullInCell(resultPos.x, resultPos.y))
                            {
                                GameView.Rows[i].Cells[j].Value = '\0';
                                GameView.Rows[resultPos.x].Cells[resultPos.y].Value = '1';
                                RefreshDrawCell(resultPos);
                                RefreshDrawCell(i, j);
                            }
                        }
                    }
                    if (GameView.Rows[i].Cells[j].Value.Equals('0'))
                        GameView.Rows[i].Cells[j].Value = '\n';
                    if (GameView.Rows[i].Cells[j].Value.Equals('1'))
                        GameView.Rows[i].Cells[j].Value = '\t';
                }
            }
            RefreshGraph();
        }

        // Добавить элемент и обновить график
        private void RefreshGraph()
        {
            int countVictims = 0, countPredators = 0;
            for (int i = 0; i < GameView.RowCount; i++)
            {
                for (int j = 0; j < GameView.ColumnCount; j++)
                {
                    if (GameView.Rows[i].Cells[j].Value.Equals('\n') || GameView.Rows[i].Cells[j].Value.Equals('0'))
                        countPredators++;
                    else if (GameView.Rows[i].Cells[j].Value.Equals('\t') || GameView.Rows[i].Cells[j].Value.Equals('1'))
                        countVictims++;
                }
            }
            ChartModel.Series[0].Points.AddXY(ChartModel.Series[0].Points.Count * (float)GameTimer.Interval / 1000, countPredators);
            ChartModel.Series[1].Points.AddXY(ChartModel.Series[1].Points.Count * (float)GameTimer.Interval / 1000, countVictims);
        }

        private void RefreshDrawCell(Vector2Int vector)
        {
            RefreshDrawCell(vector.x, vector.y);
        }
        private void RefreshDrawCell(int row, int cell)
        {
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            if (GameView.Rows[row].Cells[cell].Value.Equals('\n') ||
                GameView.Rows[row].Cells[cell].Value.Equals('0'))
            {
                cellStyle.BackColor = System.Drawing.Color.Blue;
                cellStyle.ForeColor = System.Drawing.Color.Blue;
            }
            else if (GameView.Rows[row].Cells[cell].Value.Equals('\t') ||
                GameView.Rows[row].Cells[cell].Value.Equals('1'))
            {
                cellStyle.BackColor = System.Drawing.Color.Orange;
                cellStyle.ForeColor = System.Drawing.Color.Orange;
            }
            else
            {
                cellStyle.BackColor = System.Drawing.Color.Green;
                cellStyle.ForeColor = System.Drawing.Color.Green;
            }
            GameView.Rows[row].Cells[cell].Style = cellStyle;
        }

        private bool ContainsNearInCell(Vector2Int pos, char find, out Vector2Int resultPos)
        {
            resultPos = pos;
            foreach (var offset in new Vector2Int[]
                        { new Vector2Int(1, 0), new Vector2Int(-1, 0),
                        new Vector2Int(0, 1), new Vector2Int(0, -1)})
            {
                resultPos = pos;
                if (!(resultPos.x == 0 && offset.x == -1) && !(resultPos.x == GameView.ColumnCount - 1 && offset.x == 1))
                    resultPos.x += offset.x;
                if (!(resultPos.y == 0 && offset.y == -1) && !(resultPos.y == GameView.ColumnCount - 1 && offset.y == 1))
                    resultPos.y += offset.y;

                if (GameView.Rows[resultPos.x].Cells[resultPos.y].Value.Equals(find))
                    return true;
            }
            return false;
        }

        private bool ContainsNullInCell(Vector2Int vector) => ContainsNullInCell(vector.x, vector.y);
        private bool ContainsNullInCell(int row, int cell) =>
            GameView.Rows[row].Cells[cell].Value.Equals('\0');
    }

    [System.Serializable]
    public class Game
    {
        public Game()
        {

        }
        public Game(int countVictims, int countPredators, int rateReproductionVictims, int rateEatPredators, int rateDeadHungryPredators, int rateReproductionPredators, int planeSizeX, int planeSizeY)
        {
            CountVictims = countVictims;
            CountPredators = countPredators;
            RateReproductionVictims = rateReproductionVictims;
            RateEatPredators = rateEatPredators;
            RateDeadHungryPredators = rateDeadHungryPredators;
            RateReproductionPredators = rateReproductionPredators;
        }

        public int CountVictims { get; set; }
        public int CountPredators { get; set; }
        public float RateReproductionVictims { get; set; }
        public float NowRateReproductionVictims { get; set; }
        public int RateEatPredators { get; set; }
        public int RateDeadHungryPredators { get; set; }
        public int RateReproductionPredators { get; set; }
        public bool Play { get; set; }

        public bool CanStartGame() => Play && CountVictims > 0 && CountPredators > 0;

        public class Cells
        {
            public Cell[] Values;

            public Cells(Cell[] values)
            {
                Values = values;
            }
        }

        [System.Serializable]
        public class Cell
        {
            public ContainType Type;

            public Cell(ContainType type)
            {
                Type = type;
            }

            public enum ContainType
            {
                None,
                Victim,
                Predator
            }
        }
    }

    [Serializable]
    public struct Vector2Int
    {
        public int x;
        public int y;

        public Vector2Int(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public Vector2Int(float X, float Y)
        {
            x = (int)X;
            y = (int)Y;
        }
    }
}
