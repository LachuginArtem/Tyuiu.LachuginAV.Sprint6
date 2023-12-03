
namespace Tyuiu.LachuginAV.Sprint6.Task2.V5
{
    partial class FormMain_LAV
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.groupBoxInPut_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxStop_LAV = new System.Windows.Forms.TextBox();
            this.textBoxStart_LAV = new System.Windows.Forms.TextBox();
            this.labelStop_LAV = new System.Windows.Forms.Label();
            this.labelStart_LAV = new System.Windows.Forms.Label();
            this.buttonHelp_LAV = new System.Windows.Forms.Button();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.groupBoxResult_LAV = new System.Windows.Forms.GroupBox();
            this.labelResult_LAV = new System.Windows.Forms.Label();
            this.chartResult_LAV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewXY_LAV = new System.Windows.Forms.DataGridView();
            this.ColumnX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTask_LAV.SuspendLayout();
            this.groupBoxInPut_LAV.SuspendLayout();
            this.groupBoxResult_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LAV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_LAV
            // 
            this.groupBoxTask_LAV.Controls.Add(this.textBoxTask_LAV);
            this.groupBoxTask_LAV.Location = new System.Drawing.Point(14, 12);
            this.groupBoxTask_LAV.Name = "groupBoxTask_LAV";
            this.groupBoxTask_LAV.Size = new System.Drawing.Size(636, 300);
            this.groupBoxTask_LAV.TabIndex = 0;
            this.groupBoxTask_LAV.TabStop = false;
            this.groupBoxTask_LAV.Text = "Условие";
            this.groupBoxTask_LAV.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.Location = new System.Drawing.Point(10, 27);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.ReadOnly = true;
            this.textBoxTask_LAV.Size = new System.Drawing.Size(620, 258);
            this.textBoxTask_LAV.TabIndex = 0;
            this.textBoxTask_LAV.Text = "Протабулировать функцию ( (2х-3) / (cos(x)-2x) ) + 5x - 6 \r\nна заданном диапазоне" +
    " [-5;5].\r\nРезультат вывести в DataGridView и построить график функции.";
            // 
            // groupBoxInPut_LAV
            // 
            this.groupBoxInPut_LAV.Controls.Add(this.textBoxStop_LAV);
            this.groupBoxInPut_LAV.Controls.Add(this.textBoxStart_LAV);
            this.groupBoxInPut_LAV.Controls.Add(this.labelStop_LAV);
            this.groupBoxInPut_LAV.Controls.Add(this.labelStart_LAV);
            this.groupBoxInPut_LAV.Location = new System.Drawing.Point(13, 320);
            this.groupBoxInPut_LAV.Name = "groupBoxInPut_LAV";
            this.groupBoxInPut_LAV.Size = new System.Drawing.Size(304, 100);
            this.groupBoxInPut_LAV.TabIndex = 1;
            this.groupBoxInPut_LAV.TabStop = false;
            this.groupBoxInPut_LAV.Text = "Ввод данных";
            // 
            // textBoxStop_LAV
            // 
            this.textBoxStop_LAV.Location = new System.Drawing.Point(162, 49);
            this.textBoxStop_LAV.Name = "textBoxStop_LAV";
            this.textBoxStop_LAV.Size = new System.Drawing.Size(100, 26);
            this.textBoxStop_LAV.TabIndex = 3;
            this.textBoxStop_LAV.Text = "5";
            this.textBoxStop_LAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_LAV_KeyPress);
            // 
            // textBoxStart_LAV
            // 
            this.textBoxStart_LAV.Location = new System.Drawing.Point(9, 49);
            this.textBoxStart_LAV.Name = "textBoxStart_LAV";
            this.textBoxStart_LAV.Size = new System.Drawing.Size(100, 26);
            this.textBoxStart_LAV.TabIndex = 2;
            this.textBoxStart_LAV.Text = "-5";
            this.textBoxStart_LAV.TextChanged += new System.EventHandler(this.textBoxStart_LAV_TextChanged);
            this.textBoxStart_LAV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStart_LAV_KeyPress);
            // 
            // labelStop_LAV
            // 
            this.labelStop_LAV.AutoSize = true;
            this.labelStop_LAV.Location = new System.Drawing.Point(161, 26);
            this.labelStop_LAV.Name = "labelStop_LAV";
            this.labelStop_LAV.Size = new System.Drawing.Size(101, 20);
            this.labelStop_LAV.TabIndex = 1;
            this.labelStop_LAV.Text = "Конец шага:";
            // 
            // labelStart_LAV
            // 
            this.labelStart_LAV.AutoSize = true;
            this.labelStart_LAV.Location = new System.Drawing.Point(7, 26);
            this.labelStart_LAV.Name = "labelStart_LAV";
            this.labelStart_LAV.Size = new System.Drawing.Size(102, 20);
            this.labelStart_LAV.TabIndex = 0;
            this.labelStart_LAV.Text = "Старт шага:";
            // 
            // buttonHelp_LAV
            // 
            this.buttonHelp_LAV.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonHelp_LAV.Location = new System.Drawing.Point(324, 330);
            this.buttonHelp_LAV.Name = "buttonHelp_LAV";
            this.buttonHelp_LAV.Size = new System.Drawing.Size(125, 90);
            this.buttonHelp_LAV.TabIndex = 2;
            this.buttonHelp_LAV.Text = "Справка";
            this.buttonHelp_LAV.UseVisualStyleBackColor = false;
            this.buttonHelp_LAV.Click += new System.EventHandler(this.buttonHelp_LAV_Click);
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonDone_LAV.Location = new System.Drawing.Point(456, 330);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(193, 90);
            this.buttonDone_LAV.TabIndex = 3;
            this.buttonDone_LAV.Text = "Выполнить";
            this.buttonDone_LAV.UseVisualStyleBackColor = false;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            this.buttonDone_LAV.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_LAV_MouseDown);
            this.buttonDone_LAV.MouseEnter += new System.EventHandler(this.buttonDone_LAV_MouseEnter);
            this.buttonDone_LAV.MouseLeave += new System.EventHandler(this.buttonDone_LAV_MouseLeave);
            // 
            // groupBoxResult_LAV
            // 
            this.groupBoxResult_LAV.Controls.Add(this.labelResult_LAV);
            this.groupBoxResult_LAV.Controls.Add(this.chartResult_LAV);
            this.groupBoxResult_LAV.Controls.Add(this.dataGridViewXY_LAV);
            this.groupBoxResult_LAV.Location = new System.Drawing.Point(656, 13);
            this.groupBoxResult_LAV.Name = "groupBoxResult_LAV";
            this.groupBoxResult_LAV.Size = new System.Drawing.Size(968, 407);
            this.groupBoxResult_LAV.TabIndex = 4;
            this.groupBoxResult_LAV.TabStop = false;
            this.groupBoxResult_LAV.Text = "Вывод данных";
            // 
            // labelResult_LAV
            // 
            this.labelResult_LAV.AutoSize = true;
            this.labelResult_LAV.Location = new System.Drawing.Point(7, 26);
            this.labelResult_LAV.Name = "labelResult_LAV";
            this.labelResult_LAV.Size = new System.Drawing.Size(93, 20);
            this.labelResult_LAV.TabIndex = 2;
            this.labelResult_LAV.Text = "Результат:";
            // 
            // chartResult_LAV
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_LAV.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_LAV.Legends.Add(legend5);
            this.chartResult_LAV.Location = new System.Drawing.Point(191, 50);
            this.chartResult_LAV.Name = "chartResult_LAV";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_LAV.Series.Add(series5);
            this.chartResult_LAV.Size = new System.Drawing.Size(609, 351);
            this.chartResult_LAV.TabIndex = 1;
            this.chartResult_LAV.Text = "chart1";
            // 
            // dataGridViewXY_LAV
            // 
            this.dataGridViewXY_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewXY_LAV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnX,
            this.ColumnY});
            this.dataGridViewXY_LAV.Location = new System.Drawing.Point(7, 50);
            this.dataGridViewXY_LAV.Name = "dataGridViewXY_LAV";
            this.dataGridViewXY_LAV.RowHeadersVisible = false;
            this.dataGridViewXY_LAV.RowHeadersWidth = 62;
            this.dataGridViewXY_LAV.RowTemplate.Height = 28;
            this.dataGridViewXY_LAV.Size = new System.Drawing.Size(178, 351);
            this.dataGridViewXY_LAV.TabIndex = 0;
            // 
            // ColumnX
            // 
            this.ColumnX.HeaderText = "X";
            this.ColumnX.MinimumWidth = 8;
            this.ColumnX.Name = "ColumnX";
            this.ColumnX.ReadOnly = true;
            this.ColumnX.Width = 50;
            // 
            // ColumnY
            // 
            this.ColumnY.HeaderText = "F(X)";
            this.ColumnY.MinimumWidth = 8;
            this.ColumnY.Name = "ColumnY";
            this.ColumnY.ReadOnly = true;
            this.ColumnY.Width = 50;
            // 
            // FormMain_LAV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 450);
            this.Controls.Add(this.groupBoxResult_LAV);
            this.Controls.Add(this.buttonDone_LAV);
            this.Controls.Add(this.buttonHelp_LAV);
            this.Controls.Add(this.groupBoxInPut_LAV);
            this.Controls.Add(this.groupBoxTask_LAV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_LAV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант  5 | Логинов М.В.";
            this.groupBoxTask_LAV.ResumeLayout(false);
            this.groupBoxTask_LAV.PerformLayout();
            this.groupBoxInPut_LAV.ResumeLayout(false);
            this.groupBoxInPut_LAV.PerformLayout();
            this.groupBoxResult_LAV.ResumeLayout(false);
            this.groupBoxResult_LAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_LAV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewXY_LAV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_LAV;
        private System.Windows.Forms.GroupBox groupBoxInPut_LAV;
        private System.Windows.Forms.Button buttonHelp_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.GroupBox groupBoxResult_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
        private System.Windows.Forms.TextBox textBoxStop_LAV;
        private System.Windows.Forms.TextBox textBoxStart_LAV;
        private System.Windows.Forms.Label labelStop_LAV;
        private System.Windows.Forms.Label labelStart_LAV;
        private System.Windows.Forms.Label labelResult_LAV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_LAV;
        private System.Windows.Forms.DataGridView dataGridViewXY_LAV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnY;
    }
}
