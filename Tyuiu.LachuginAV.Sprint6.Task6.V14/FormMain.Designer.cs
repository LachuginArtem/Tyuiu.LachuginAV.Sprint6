namespace Tyuiu.LachuginAV.Sprint6.Task6.V14
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelData_LAV = new System.Windows.Forms.Panel();
            this.buttonOpenFile_LAV = new System.Windows.Forms.Button();
            this.buttonInfo_LAV = new System.Windows.Forms.Button();
            this.buttonDone_LAV = new System.Windows.Forms.Button();
            this.groupBoxData_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTask_LAV = new System.Windows.Forms.TextBox();
            this.panelOpenFile_LAV = new System.Windows.Forms.Panel();
            this.groupBoxInput_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxFile_LAV = new System.Windows.Forms.TextBox();
            this.panelResultFile_LAV = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxResult_LAV = new System.Windows.Forms.TextBox();
            this.splitterWindows_LAV = new System.Windows.Forms.Splitter();
            this.openFileDialog_LAV = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_LAV = new System.Windows.Forms.ToolTip(this.components);
            this.panelData_LAV.SuspendLayout();
            this.groupBoxData_LAV.SuspendLayout();
            this.panelOpenFile_LAV.SuspendLayout();
            this.groupBoxInput_LAV.SuspendLayout();
            this.panelResultFile_LAV.SuspendLayout();
            this.groupBoxOutPut_LAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData_LAV
            // 
            this.panelData_LAV.Controls.Add(this.buttonOpenFile_LAV);
            this.panelData_LAV.Controls.Add(this.buttonInfo_LAV);
            this.panelData_LAV.Controls.Add(this.buttonDone_LAV);
            this.panelData_LAV.Controls.Add(this.groupBoxData_LAV);
            this.panelData_LAV.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelData_LAV.Location = new System.Drawing.Point(0, 0);
            this.panelData_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelData_LAV.Name = "panelData_LAV";
            this.panelData_LAV.Size = new System.Drawing.Size(862, 153);
            this.panelData_LAV.TabIndex = 0;
            // 
            // buttonOpenFile_LAV
            // 
            this.buttonOpenFile_LAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_LAV.Location = new System.Drawing.Point(9, 10);
            this.buttonOpenFile_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOpenFile_LAV.Name = "buttonOpenFile_LAV";
            this.buttonOpenFile_LAV.Size = new System.Drawing.Size(73, 58);
            this.buttonOpenFile_LAV.TabIndex = 2;
            this.buttonOpenFile_LAV.Text = "Открыть";
            this.toolTip_LAV.SetToolTip(this.buttonOpenFile_LAV, "Открыть файл\r\nВыберите нужный файл для обработки");
            this.buttonOpenFile_LAV.UseVisualStyleBackColor = true;
            this.buttonOpenFile_LAV.Click += new System.EventHandler(this.buttonOpenFile_LAV_Click);
            // 
            // buttonInfo_LAV
            // 
            this.buttonInfo_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_LAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_LAV.Location = new System.Drawing.Point(780, 10);
            this.buttonInfo_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInfo_LAV.Name = "buttonInfo_LAV";
            this.buttonInfo_LAV.Size = new System.Drawing.Size(73, 58);
            this.buttonInfo_LAV.TabIndex = 1;
            this.buttonInfo_LAV.Text = "Справка";
            this.toolTip_LAV.SetToolTip(this.buttonInfo_LAV, "Сведения о программе");
            this.buttonInfo_LAV.UseVisualStyleBackColor = true;
            this.buttonInfo_LAV.Click += new System.EventHandler(this.buttonInfo_LAV_Click);
            // 
            // buttonDone_LAV
            // 
            this.buttonDone_LAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_LAV.Enabled = false;
            this.buttonDone_LAV.Location = new System.Drawing.Point(87, 10);
            this.buttonDone_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDone_LAV.Name = "buttonDone_LAV";
            this.buttonDone_LAV.Size = new System.Drawing.Size(73, 58);
            this.buttonDone_LAV.TabIndex = 1;
            this.buttonDone_LAV.Text = "Выполнить";
            this.toolTip_LAV.SetToolTip(this.buttonDone_LAV, "Выводит слова в которых встречается \"z\"\r\nи конкатенирует их");
            this.buttonDone_LAV.UseVisualStyleBackColor = true;
            this.buttonDone_LAV.Click += new System.EventHandler(this.buttonDone_LAV_Click);
            // 
            // groupBoxData_LAV
            // 
            this.groupBoxData_LAV.Controls.Add(this.textBoxTask_LAV);
            this.groupBoxData_LAV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxData_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxData_LAV.Location = new System.Drawing.Point(0, 79);
            this.groupBoxData_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxData_LAV.Name = "groupBoxData_LAV";
            this.groupBoxData_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxData_LAV.Size = new System.Drawing.Size(862, 74);
            this.groupBoxData_LAV.TabIndex = 0;
            this.groupBoxData_LAV.TabStop = false;
            this.groupBoxData_LAV.Text = "Условие";
            // 
            // textBoxTask_LAV
            // 
            this.textBoxTask_LAV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxTask_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTask_LAV.Location = new System.Drawing.Point(10, 18);
            this.textBoxTask_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTask_LAV.Multiline = true;
            this.textBoxTask_LAV.Name = "textBoxTask_LAV";
            this.textBoxTask_LAV.Size = new System.Drawing.Size(832, 51);
            this.textBoxTask_LAV.TabIndex = 0;
            this.textBoxTask_LAV.Text = resources.GetString("textBoxTask_LAV.Text");
            // 
            // panelOpenFile_LAV
            // 
            this.panelOpenFile_LAV.Controls.Add(this.groupBoxInput_LAV);
            this.panelOpenFile_LAV.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOpenFile_LAV.Location = new System.Drawing.Point(0, 153);
            this.panelOpenFile_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelOpenFile_LAV.Name = "panelOpenFile_LAV";
            this.panelOpenFile_LAV.Size = new System.Drawing.Size(419, 330);
            this.panelOpenFile_LAV.TabIndex = 0;
            // 
            // groupBoxInput_LAV
            // 
            this.groupBoxInput_LAV.Controls.Add(this.textBoxFile_LAV);
            this.groupBoxInput_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxInput_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInput_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInput_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput_LAV.Name = "groupBoxInput_LAV";
            this.groupBoxInput_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxInput_LAV.Size = new System.Drawing.Size(419, 330);
            this.groupBoxInput_LAV.TabIndex = 0;
            this.groupBoxInput_LAV.TabStop = false;
            this.groupBoxInput_LAV.Text = "Ввод данных";
            // 
            // textBoxFile_LAV
            // 
            this.textBoxFile_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFile_LAV.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxFile_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxFile_LAV.Location = new System.Drawing.Point(10, 27);
            this.textBoxFile_LAV.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.textBoxFile_LAV.Multiline = true;
            this.textBoxFile_LAV.Name = "textBoxFile_LAV";
            this.textBoxFile_LAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxFile_LAV.Size = new System.Drawing.Size(407, 301);
            this.textBoxFile_LAV.TabIndex = 0;
            // 
            // panelResultFile_LAV
            // 
            this.panelResultFile_LAV.Controls.Add(this.groupBoxOutPut_LAV);
            this.panelResultFile_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultFile_LAV.Location = new System.Drawing.Point(419, 153);
            this.panelResultFile_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelResultFile_LAV.Name = "panelResultFile_LAV";
            this.panelResultFile_LAV.Size = new System.Drawing.Size(443, 330);
            this.panelResultFile_LAV.TabIndex = 0;
            this.panelResultFile_LAV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelResultFile_LAV_Paint);
            // 
            // groupBoxOutPut_LAV
            // 
            this.groupBoxOutPut_LAV.Controls.Add(this.textBoxResult_LAV);
            this.groupBoxOutPut_LAV.Controls.Add(this.splitterWindows_LAV);
            this.groupBoxOutPut_LAV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxOutPut_LAV.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LAV.Name = "groupBoxOutPut_LAV";
            this.groupBoxOutPut_LAV.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxOutPut_LAV.Size = new System.Drawing.Size(443, 330);
            this.groupBoxOutPut_LAV.TabIndex = 1;
            this.groupBoxOutPut_LAV.TabStop = false;
            this.groupBoxOutPut_LAV.Text = "Вывод данных";
            // 
            // textBoxResult_LAV
            // 
            this.textBoxResult_LAV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult_LAV.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxResult_LAV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxResult_LAV.Location = new System.Drawing.Point(11, 27);
            this.textBoxResult_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_LAV.Multiline = true;
            this.textBoxResult_LAV.Name = "textBoxResult_LAV";
            this.textBoxResult_LAV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_LAV.Size = new System.Drawing.Size(430, 301);
            this.textBoxResult_LAV.TabIndex = 1;
            // 
            // splitterWindows_LAV
            // 
            this.splitterWindows_LAV.Location = new System.Drawing.Point(2, 16);
            this.splitterWindows_LAV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitterWindows_LAV.Name = "splitterWindows_LAV";
            this.splitterWindows_LAV.Size = new System.Drawing.Size(2, 312);
            this.splitterWindows_LAV.TabIndex = 0;
            this.splitterWindows_LAV.TabStop = false;
            // 
            // openFileDialog_LAV
            // 
            this.openFileDialog_LAV.FileName = "InPutFileTask6V14";
            // 
            // toolTip_LAV
            // 
            this.toolTip_LAV.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_LAV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 483);
            this.Controls.Add(this.panelResultFile_LAV);
            this.Controls.Add(this.panelOpenFile_LAV);
            this.Controls.Add(this.panelData_LAV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(878, 522);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 14 | Лачугин А.В.";
            this.panelData_LAV.ResumeLayout(false);
            this.groupBoxData_LAV.ResumeLayout(false);
            this.groupBoxData_LAV.PerformLayout();
            this.panelOpenFile_LAV.ResumeLayout(false);
            this.groupBoxInput_LAV.ResumeLayout(false);
            this.groupBoxInput_LAV.PerformLayout();
            this.panelResultFile_LAV.ResumeLayout(false);
            this.groupBoxOutPut_LAV.ResumeLayout(false);
            this.groupBoxOutPut_LAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData_LAV;
        private System.Windows.Forms.Panel panelOpenFile_LAV;
        private System.Windows.Forms.Panel panelResultFile_LAV;
        private System.Windows.Forms.GroupBox groupBoxData_LAV;
        private System.Windows.Forms.GroupBox groupBoxOutPut_LAV;
        private System.Windows.Forms.Splitter splitterWindows_LAV;
        private System.Windows.Forms.GroupBox groupBoxInput_LAV;
        private System.Windows.Forms.Button buttonInfo_LAV;
        private System.Windows.Forms.Button buttonDone_LAV;
        private System.Windows.Forms.TextBox textBoxTask_LAV;
        private System.Windows.Forms.TextBox textBoxFile_LAV;
        private System.Windows.Forms.TextBox textBoxResult_LAV;
        private System.Windows.Forms.Button buttonOpenFile_LAV;
        private System.Windows.Forms.ToolTip toolTip_LAV;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LAV;
    }
}