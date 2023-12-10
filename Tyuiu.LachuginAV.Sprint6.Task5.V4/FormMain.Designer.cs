
namespace Tyuiu.LachuginAV.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_LAV = new System.Windows.Forms.Panel();
            this.buttonHelp_LAV = new System.Windows.Forms.Button();
            this.buttonSave_LAV = new System.Windows.Forms.Button();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.groupBoxTask_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.panelLeft_LAV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_LAV = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_LAV = new System.Windows.Forms.DataGridView();
            this.panelFill_LAV = new System.Windows.Forms.Panel();
            this.chartDiag_LAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitterOutPut_LAV = new System.Windows.Forms.Splitter();
            this.panelTop_LAV.SuspendLayout();
            this.groupBoxTask_LAV.SuspendLayout();
            this.panelLeft_LAV.SuspendLayout();
            this.groupBoxOutPut_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_LAV)).BeginInit();
            this.panelFill_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_LAV
            // 
            this.panelTop_LAV.Controls.Add(this.buttonHelp_LAV);
            this.panelTop_LAV.Controls.Add(this.buttonSave_LAV);
            this.panelTop_LAV.Controls.Add(this.buttonDone_LAV);
            this.panelTop_LAV.Controls.Add(this.groupBoxTask_LAV);
            this.panelTop_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_LAV.Location = new System.Drawing.Point(0, 0);
            this.panelTop_LAV.Name = "panelTop_LAV";
            this.panelTop_LAV.Size = new System.Drawing.Size(710, 100);
            this.panelTop_LAV.TabIndex = 0;
            // 
            // buttonHelp_LAV
            // 
            this.buttonHelp_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_LAV.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonHelp_LAV.Location = new System.Drawing.Point(617, 22);
            this.buttonHelp_LAV.Name = "buttonHelp_LAV";
            this.buttonHelp_LAV.Size = new System.Drawing.Size(75, 60);
            this.buttonHelp_LAV.TabIndex = 1;
            this.buttonHelp_LAV.Text = "Справка";
            this.buttonHelp_LAV.UseVisualStyleBackColor = false;
            this.buttonHelp_LAV.Click += new System.EventHandler(this.buttonHelp_LAV_Click);
            // 
            // buttonSave_LAV
            // 
            this.buttonSave_LAV.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_LAV.Location = new System.Drawing.Point(536, 22);
            this.buttonSave_LAV.Name = "buttonSave_LAV";
            this.buttonSave_LAV.Size = new System.Drawing.Size(75, 60);
            this.buttonSave_LAV.TabIndex = 1;
            this.buttonSave_LAV.Text = "Открыть";
            this.buttonSave_LAV.UseVisualStyleBackColor = false;
            this.buttonSave_LAV.Click += new System.EventHandler(this.buttonSave_LAV_Click);
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonDone_LAV.Location = new System.Drawing.Point(449, 22);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(81, 60);
            this.buttonDone_LAV.TabIndex = 1;
            this.buttonDone_LAV.Text = "Выполнить";
            this.buttonDone_LAV.UseVisualStyleBackColor = false;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            // 
            // groupBoxTask_LAV
            // 
            this.groupBoxTask_LAV.Controls.Add(this.textBoxTask_LAV);
            this.groupBoxTask_LAV.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_LAV.Name = "groupBoxTask_LAV";
            this.groupBoxTask_LAV.Size = new System.Drawing.Size(431, 76);
            this.groupBoxTask_LAV.TabIndex = 0;
            this.groupBoxTask_LAV.TabStop = false;
            this.groupBoxTask_LAV.Text = "Условие";
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_LAV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.ReadOnly = true;
            this.textBoxTask_LAV.Size = new System.Drawing.Size(419, 51);
            this.textBoxTask_LAV.TabIndex = 0;
            this.textBoxTask_LAV.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести в" +
    "се целые числа.";
            // 
            // panelLeft_LAV
            // 
            this.panelLeft_LAV.Controls.Add(this.groupBoxOutPut_LAV);
            this.panelLeft_LAV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_LAV.Location = new System.Drawing.Point(0, 100);
            this.panelLeft_LAV.Name = "panelLeft_LAV";
            this.panelLeft_LAV.Size = new System.Drawing.Size(200, 350);
            this.panelLeft_LAV.TabIndex = 1;
            // 
            // groupBoxOutPut_LAV
            // 
            this.groupBoxOutPut_LAV.Controls.Add(this.dataGridViewNums_LAV);
            this.groupBoxOutPut_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_LAV.Name = "groupBoxOutPut_LAV";
            this.groupBoxOutPut_LAV.Size = new System.Drawing.Size(200, 350);
            this.groupBoxOutPut_LAV.TabIndex = 0;
            this.groupBoxOutPut_LAV.TabStop = false;
            this.groupBoxOutPut_LAV.Text = "Вывод данных";
            // 
            // dataGridViewNums_LAV
            // 
            this.dataGridViewNums_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_LAV.ColumnHeadersVisible = false;
            this.dataGridViewNums_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_LAV.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_LAV.Name = "dataGridViewNums_LAV";
            this.dataGridViewNums_LAV.ReadOnly = true;
            this.dataGridViewNums_LAV.RowHeadersVisible = false;
            this.dataGridViewNums_LAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_LAV.Size = new System.Drawing.Size(194, 331);
            this.dataGridViewNums_LAV.TabIndex = 0;
            // 
            // panelFill_LAV
            // 
            this.panelFill_LAV.Controls.Add(this.chartDiag_LAV);
            this.panelFill_LAV.Controls.Add(this.splitterOutPut_LAV);
            this.panelFill_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill_LAV.Location = new System.Drawing.Point(200, 100);
            this.panelFill_LAV.Name = "panelFill_LAV";
            this.panelFill_LAV.Size = new System.Drawing.Size(510, 350);
            this.panelFill_LAV.TabIndex = 2;
            // 
            // chartDiag_LAV
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiag_LAV.ChartAreas.Add(chartArea1);
            this.chartDiag_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiag_LAV.Legends.Add(legend1);
            this.chartDiag_LAV.Location = new System.Drawing.Point(3, 0);
            this.chartDiag_LAV.Name = "chartDiag_LAV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartDiag_LAV.Series.Add(series1);
            this.chartDiag_LAV.Size = new System.Drawing.Size(507, 350);
            this.chartDiag_LAV.TabIndex = 1;
            this.chartDiag_LAV.Text = "chart1";
            // 
            // splitterOutPut_LAV
            // 
            this.splitterOutPut_LAV.Location = new System.Drawing.Point(0, 0);
            this.splitterOutPut_LAV.Name = "splitterOutPut_LAV";
            this.splitterOutPut_LAV.Size = new System.Drawing.Size(3, 350);
            this.splitterOutPut_LAV.TabIndex = 0;
            this.splitterOutPut_LAV.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 450);
            this.Controls.Add(this.panelFill_LAV);
            this.Controls.Add(this.panelLeft_LAV);
            this.Controls.Add(this.panelTop_LAV);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 |Лачугин А.В. АСОиУБ-23-3";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelTop_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.PerformLayout();
            this.panelLeft_LAV.ResumeLayout(false);
            this.groupBoxOutPut_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_LAV)).EndInit();
            this.panelFill_LAV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_LAV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTop_LAV;
        private System.Windows.Forms.Button buttonHelp_LAV;
        private System.Windows.Forms.Button buttonSave_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.GroupBox groupBoxTask_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
        private System.Windows.Forms.Panel panelLeft_LAV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LAV;
        private System.Windows.Forms.DataGridView dataGridViewNums_LAV;
        private System.Windows.Forms.Panel panelFill_LAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_LAV;
        private System.Windows.Forms.Splitter splitterOutPut_LAV;
    }
}