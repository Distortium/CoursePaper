namespace CoursePaper
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation3 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation textAnnotation4 = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.CountVictimsTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CountPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RateReproductionVictimsTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RateEatPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RateDeadHungryPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RateReproductionPredatorsTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ChartModel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GameView = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.XSizeGameTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.YSizeGameTextBox = new System.Windows.Forms.TextBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ChartModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Начальные параметры";
            // 
            // CountVictimsTextBox
            // 
            this.CountVictimsTextBox.Location = new System.Drawing.Point(16, 54);
            this.CountVictimsTextBox.Name = "CountVictimsTextBox";
            this.CountVictimsTextBox.Size = new System.Drawing.Size(143, 20);
            this.CountVictimsTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество жертв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Количество хищников";
            // 
            // CountPredatorsTextBox
            // 
            this.CountPredatorsTextBox.Location = new System.Drawing.Point(16, 93);
            this.CountPredatorsTextBox.Name = "CountPredatorsTextBox";
            this.CountPredatorsTextBox.Size = new System.Drawing.Size(143, 20);
            this.CountPredatorsTextBox.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Скорость размножения жертв";
            // 
            // RateReproductionVictimsTextBox
            // 
            this.RateReproductionVictimsTextBox.Location = new System.Drawing.Point(16, 132);
            this.RateReproductionVictimsTextBox.Name = "RateReproductionVictimsTextBox";
            this.RateReproductionVictimsTextBox.Size = new System.Drawing.Size(143, 20);
            this.RateReproductionVictimsTextBox.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Скорость поедания жертв хищниками";
            // 
            // RateEatPredatorsTextBox
            // 
            this.RateEatPredatorsTextBox.Location = new System.Drawing.Point(16, 171);
            this.RateEatPredatorsTextBox.Name = "RateEatPredatorsTextBox";
            this.RateEatPredatorsTextBox.Size = new System.Drawing.Size(143, 20);
            this.RateEatPredatorsTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Скорость вымирания голодных хищников";
            // 
            // RateDeadHungryPredatorsTextBox
            // 
            this.RateDeadHungryPredatorsTextBox.Location = new System.Drawing.Point(16, 210);
            this.RateDeadHungryPredatorsTextBox.Name = "RateDeadHungryPredatorsTextBox";
            this.RateDeadHungryPredatorsTextBox.Size = new System.Drawing.Size(143, 20);
            this.RateDeadHungryPredatorsTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Скорость размножения сытых хищников";
            // 
            // RateReproductionPredatorsTextBox
            // 
            this.RateReproductionPredatorsTextBox.Location = new System.Drawing.Point(16, 249);
            this.RateReproductionPredatorsTextBox.Name = "RateReproductionPredatorsTextBox";
            this.RateReproductionPredatorsTextBox.Size = new System.Drawing.Size(143, 20);
            this.RateReproductionPredatorsTextBox.TabIndex = 12;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartButton.Location = new System.Drawing.Point(12, 358);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 41);
            this.StartButton.TabIndex = 14;
            this.StartButton.Text = "Старт";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StopButton.Location = new System.Drawing.Point(93, 358);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 41);
            this.StopButton.TabIndex = 15;
            this.StopButton.Text = "Стоп";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResetButton.Location = new System.Drawing.Point(174, 358);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 41);
            this.ResetButton.TabIndex = 16;
            this.ResetButton.Text = "Сброс";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ChartModel
            // 
            textAnnotation3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textAnnotation3.Name = "TextAnnotation1";
            textAnnotation3.Text = "Кол-во";
            textAnnotation3.Y = -6D;
            textAnnotation4.Name = "TextAnnotation2";
            textAnnotation4.Text = "Время";
            textAnnotation4.X = 73D;
            textAnnotation4.Y = 76D;
            this.ChartModel.Annotations.Add(textAnnotation3);
            this.ChartModel.Annotations.Add(textAnnotation4);
            chartArea2.Name = "ChartArea1";
            this.ChartModel.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartModel.Legends.Add(legend2);
            this.ChartModel.Location = new System.Drawing.Point(286, 297);
            this.ChartModel.Name = "ChartModel";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Хищники";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Жертвы";
            this.ChartModel.Series.Add(series3);
            this.ChartModel.Series.Add(series4);
            this.ChartModel.Size = new System.Drawing.Size(486, 102);
            this.ChartModel.TabIndex = 17;
            this.ChartModel.Text = "chart1";
            // 
            // GameView
            // 
            this.GameView.AllowUserToAddRows = false;
            this.GameView.AllowUserToDeleteRows = false;
            this.GameView.BackgroundColor = System.Drawing.Color.Green;
            this.GameView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GameView.Location = new System.Drawing.Point(286, 13);
            this.GameView.Name = "GameView";
            this.GameView.ReadOnly = true;
            this.GameView.Size = new System.Drawing.Size(486, 278);
            this.GameView.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Размер поля";
            // 
            // XSizeGameTextBox
            // 
            this.XSizeGameTextBox.Location = new System.Drawing.Point(16, 288);
            this.XSizeGameTextBox.Name = "XSizeGameTextBox";
            this.XSizeGameTextBox.Size = new System.Drawing.Size(61, 20);
            this.XSizeGameTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(83, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "Х";
            // 
            // YSizeGameTextBox
            // 
            this.YSizeGameTextBox.Location = new System.Drawing.Point(104, 288);
            this.YSizeGameTextBox.Name = "YSizeGameTextBox";
            this.YSizeGameTextBox.Size = new System.Drawing.Size(61, 20);
            this.YSizeGameTextBox.TabIndex = 22;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 200;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.YSizeGameTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.XSizeGameTextBox);
            this.Controls.Add(this.GameView);
            this.Controls.Add(this.ChartModel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RateReproductionPredatorsTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RateDeadHungryPredatorsTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RateEatPredatorsTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RateReproductionVictimsTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CountPredatorsTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CountVictimsTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Игра \"хищник-жертва\"";
            ((System.ComponentModel.ISupportInitialize)(this.ChartModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GameView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CountVictimsTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CountPredatorsTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox RateReproductionVictimsTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RateEatPredatorsTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RateDeadHungryPredatorsTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RateReproductionPredatorsTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartModel;
        private System.Windows.Forms.DataGridView GameView;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox XSizeGameTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox YSizeGameTextBox;
        private System.Windows.Forms.Timer GameTimer;
    }
}

