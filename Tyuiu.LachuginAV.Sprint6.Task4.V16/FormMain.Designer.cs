namespace Tyuiu.LachuginAV.Sprint6.Task4.V16

{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBoxStart_LAV = new System.Windows.Forms.TextBox();
            this.textBoxStop_LAV = new System.Windows.Forms.TextBox();
            this.chartFunc_LAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxRes_LAV = new System.Windows.Forms.TextBox();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.buttonFile_LAV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFirst_LAV = new System.Windows.Forms.Label();
            this.labelStop_LAV = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelRes_LAV = new System.Windows.Forms.Label();
            this.labelStart_LAV = new System.Windows.Forms.Label();
            this.panelFunc_LAV = new System.Windows.Forms.Panel();
            this.buttonFil_LAV = new System.Windows.Forms.Button();
            this.buttonHelp_LAV = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFinal_LAV = new System.Windows.Forms.Label();
            this.labelFx_LAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_LAV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFunc_LAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStart_LAV
            // 
            this.textBoxStart_LAV.Location = new System.Drawing.Point(132, 107);
            this.textBoxStart_LAV.Name = "textBoxStart_LAV";
            this.textBoxStart_LAV.Size = new System.Drawing.Size(107, 20);
            this.textBoxStart_LAV.TabIndex = 0;
            // 
            // textBoxStop_LAV
            // 
            this.textBoxStop_LAV.Location = new System.Drawing.Point(245, 107);
            this.textBoxStop_LAV.Name = "textBoxStop_LAV";
            this.textBoxStop_LAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_LAV.TabIndex = 1;
            // 
            // chartFunc_LAV
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFunc_LAV.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFunc_LAV.Legends.Add(legend3);
            this.chartFunc_LAV.Location = new System.Drawing.Point(45, 51);
            this.chartFunc_LAV.Name = "chartFunc_LAV";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "F(X)";
            this.chartFunc_LAV.Series.Add(series3);
            this.chartFunc_LAV.Size = new System.Drawing.Size(392, 242);
            this.chartFunc_LAV.TabIndex = 2;
            this.chartFunc_LAV.Text = "chart1";
            // 
            // textBoxRes_LAV
            // 
            this.textBoxRes_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxRes_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRes_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxRes_LAV.Location = new System.Drawing.Point(441, 135);
            this.textBoxRes_LAV.Multiline = true;
            this.textBoxRes_LAV.Name = "textBoxRes_LAV";
            this.textBoxRes_LAV.ReadOnly = true;
            this.textBoxRes_LAV.Size = new System.Drawing.Size(133, 281);
            this.textBoxRes_LAV.TabIndex = 3;
            this.textBoxRes_LAV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonDone_LAV.Location = new System.Drawing.Point(30, 159);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(162, 71);
            this.buttonDone_LAV.TabIndex = 4;
            this.buttonDone_LAV.Text = "Выполнить";
            this.buttonDone_LAV.UseVisualStyleBackColor = false;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            // 
            // buttonFile_LAV
            // 
            this.buttonFile_LAV.Location = new System.Drawing.Point(753, 278);
            this.buttonFile_LAV.Name = "buttonFile_LAV";
            this.buttonFile_LAV.Size = new System.Drawing.Size(162, 70);
            this.buttonFile_LAV.TabIndex = 5;
            this.buttonFile_LAV.UseVisualStyleBackColor = true;
            this.buttonFile_LAV.Click += new System.EventHandler(this.buttonFile_LAV_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.labelFirst_LAV);
            this.panel1.Controls.Add(this.labelStop_LAV);
            this.panel1.Controls.Add(this.textBoxStart_LAV);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelRes_LAV);
            this.panel1.Controls.Add(this.textBoxStop_LAV);
            this.panel1.Controls.Add(this.labelStart_LAV);
            this.panel1.Location = new System.Drawing.Point(12, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 129);
            this.panel1.TabIndex = 6;
            // 
            // labelFirst_LAV
            // 
            this.labelFirst_LAV.AutoSize = true;
            this.labelFirst_LAV.Location = new System.Drawing.Point(132, 91);
            this.labelFirst_LAV.Name = "labelFirst_LAV";
            this.labelFirst_LAV.Size = new System.Drawing.Size(20, 13);
            this.labelFirst_LAV.TabIndex = 10;
            this.labelFirst_LAV.Text = "От";
            // 
            // labelStop_LAV
            // 
            this.labelStop_LAV.AutoSize = true;
            this.labelStop_LAV.Location = new System.Drawing.Point(242, 91);
            this.labelStop_LAV.Name = "labelStop_LAV";
            this.labelStop_LAV.Size = new System.Drawing.Size(25, 13);
            this.labelStop_LAV.TabIndex = 7;
            this.labelStop_LAV.Text = "До:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.LachuginAV.Sprint6.Task4.V16.Properties.Resources._2023_12_10_13_16_27;
            this.pictureBox1.Location = new System.Drawing.Point(34, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelRes_LAV
            // 
            this.labelRes_LAV.AutoSize = true;
            this.labelRes_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes_LAV.Location = new System.Drawing.Point(31, 11);
            this.labelRes_LAV.Name = "labelRes_LAV";
            this.labelRes_LAV.Size = new System.Drawing.Size(190, 112);
            this.labelRes_LAV.TabIndex = 9;
            this.labelRes_LAV.Text = "Протабулировать функцию\r\n\r\n\r\n\r\n\r\n\r\n на отрезке";
            // 
            // labelStart_LAV
            // 
            this.labelStart_LAV.AutoSize = true;
            this.labelStart_LAV.Location = new System.Drawing.Point(129, 91);
            this.labelStart_LAV.Name = "labelStart_LAV";
            this.labelStart_LAV.Size = new System.Drawing.Size(23, 13);
            this.labelStart_LAV.TabIndex = 6;
            this.labelStart_LAV.Text = "От:";
            // 
            // panelFunc_LAV
            // 
            this.panelFunc_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelFunc_LAV.Controls.Add(this.chartFunc_LAV);
            this.panelFunc_LAV.Location = new System.Drawing.Point(555, 65);
            this.panelFunc_LAV.Name = "panelFunc_LAV";
            this.panelFunc_LAV.Size = new System.Drawing.Size(440, 373);
            this.panelFunc_LAV.TabIndex = 7;
            // 
            // buttonFil_LAV
            // 
            this.buttonFil_LAV.BackColor = System.Drawing.Color.Blue;
            this.buttonFil_LAV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFil_LAV.Location = new System.Drawing.Point(245, 159);
            this.buttonFil_LAV.Name = "buttonFil_LAV";
            this.buttonFil_LAV.Size = new System.Drawing.Size(162, 70);
            this.buttonFil_LAV.TabIndex = 8;
            this.buttonFil_LAV.Text = "Сохранить";
            this.buttonFil_LAV.UseVisualStyleBackColor = false;
            this.buttonFil_LAV.Click += new System.EventHandler(this.buttonFile_LAV_Click);
            // 
            // buttonHelp_LAV
            // 
            this.buttonHelp_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonHelp_LAV.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_LAV.Location = new System.Drawing.Point(164, 291);
            this.buttonHelp_LAV.Name = "buttonHelp_LAV";
            this.buttonHelp_LAV.Size = new System.Drawing.Size(114, 95);
            this.buttonHelp_LAV.TabIndex = 9;
            this.buttonHelp_LAV.Text = "Справка";
            this.buttonHelp_LAV.UseVisualStyleBackColor = false;
            this.buttonHelp_LAV.Click += new System.EventHandler(this.buttonHelp_LAV_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(21, 144);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(401, 301);
            this.textBox1.TabIndex = 10;
            // 
            // labelFinal_LAV
            // 
            this.labelFinal_LAV.AutoSize = true;
            this.labelFinal_LAV.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFinal_LAV.Location = new System.Drawing.Point(488, 9);
            this.labelFinal_LAV.Name = "labelFinal_LAV";
            this.labelFinal_LAV.Size = new System.Drawing.Size(191, 42);
            this.labelFinal_LAV.TabIndex = 11;
            this.labelFinal_LAV.Text = "Результат:";
            // 
            // labelFx_LAV
            // 
            this.labelFx_LAV.AutoSize = true;
            this.labelFx_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFx_LAV.Location = new System.Drawing.Point(492, 116);
            this.labelFx_LAV.Name = "labelFx_LAV";
            this.labelFx_LAV.Size = new System.Drawing.Size(36, 16);
            this.labelFx_LAV.TabIndex = 12;
            this.labelFx_LAV.Text = "F(X)";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.buttonDone_LAV);
            this.Controls.Add(this.labelFx_LAV);
            this.Controls.Add(this.textBoxRes_LAV);
            this.Controls.Add(this.labelFinal_LAV);
            this.Controls.Add(this.buttonHelp_LAV);
            this.Controls.Add(this.panelFunc_LAV);
            this.Controls.Add(this.buttonFil_LAV);
            this.Controls.Add(this.buttonFile_LAV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc_LAV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFunc_LAV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStart_LAV;
        private System.Windows.Forms.TextBox textBoxStop_LAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc_LAV;
        private System.Windows.Forms.TextBox textBoxRes_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.Button buttonFile_LAV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStop_LAV;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelRes_LAV;
        private System.Windows.Forms.Label labelStart_LAV;
        private System.Windows.Forms.Panel panelFunc_LAV;
        private System.Windows.Forms.Label labelFirst_LAV;
        private System.Windows.Forms.Button buttonFil_LAV;
        private System.Windows.Forms.Button buttonHelp_LAV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelFinal_LAV;
        private System.Windows.Forms.Label labelFx_LAV;
    }
}