
namespace ProcessLab1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.minTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PointsCountTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.NTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DVTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MVTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DUTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MUTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart1
            // 
            this.Chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(12, 12);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(674, 426);
            this.Chart1.TabIndex = 0;
            this.Chart1.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maxTB);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.minTB);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PointsCountTB);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.NTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DVTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MVTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.DUTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.MUTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Location = new System.Drawing.Point(683, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 439);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры";
            // 
            // maxTB
            // 
            this.maxTB.Location = new System.Drawing.Point(161, 230);
            this.maxTB.Name = "maxTB";
            this.maxTB.Size = new System.Drawing.Size(100, 22);
            this.maxTB.TabIndex = 34;
            this.maxTB.Text = "10";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 17);
            this.label8.TabIndex = 33;
            this.label8.Text = "tmax";
            // 
            // minTB
            // 
            this.minTB.Location = new System.Drawing.Point(18, 230);
            this.minTB.Name = "minTB";
            this.minTB.Size = new System.Drawing.Size(100, 22);
            this.minTB.TabIndex = 32;
            this.minTB.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "tmin";
            // 
            // PointsCountTB
            // 
            this.PointsCountTB.Location = new System.Drawing.Point(161, 165);
            this.PointsCountTB.Name = "PointsCountTB";
            this.PointsCountTB.Size = new System.Drawing.Size(100, 22);
            this.PointsCountTB.TabIndex = 30;
            this.PointsCountTB.Text = "10";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Кол-во точек";
            // 
            // NTB
            // 
            this.NTB.Location = new System.Drawing.Point(18, 165);
            this.NTB.Name = "NTB";
            this.NTB.Size = new System.Drawing.Size(100, 22);
            this.NTB.TabIndex = 28;
            this.NTB.Text = "10";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Число реализаций";
            // 
            // DVTB
            // 
            this.DVTB.Location = new System.Drawing.Point(161, 93);
            this.DVTB.Name = "DVTB";
            this.DVTB.Size = new System.Drawing.Size(100, 22);
            this.DVTB.TabIndex = 26;
            this.DVTB.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Дисперсия V";
            // 
            // MVTB
            // 
            this.MVTB.Location = new System.Drawing.Point(161, 40);
            this.MVTB.Name = "MVTB";
            this.MVTB.Size = new System.Drawing.Size(100, 22);
            this.MVTB.TabIndex = 24;
            this.MVTB.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Мат. Ожидание V";
            // 
            // DUTB
            // 
            this.DUTB.Location = new System.Drawing.Point(18, 94);
            this.DUTB.Name = "DUTB";
            this.DUTB.Size = new System.Drawing.Size(100, 22);
            this.DUTB.TabIndex = 22;
            this.DUTB.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Дисперсия U";
            // 
            // MUTB
            // 
            this.MUTB.Location = new System.Drawing.Point(18, 40);
            this.MUTB.Name = "MUTB";
            this.MUTB.Size = new System.Drawing.Size(100, 22);
            this.MUTB.TabIndex = 20;
            this.MUTB.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Мат. Ожидание U";
            // 
            // Start
            // 
            this.Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Start.Location = new System.Drawing.Point(18, 385);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(264, 48);
            this.Start.TabIndex = 18;
            this.Start.Text = "Построить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox maxTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox minTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PointsCountTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DVTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox MVTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DUTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MUTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start;
    }
}

