
namespace Tyuiu.LachuginAV.Sprint6.Task3.V30
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
            this.groupBoxOne_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxOne_LAV = new System.Windows.Forms.TextBox();
            this.dataGridViewInput_LAV = new System.Windows.Forms.DataGridView();
            this.groupBoxTwo_LAV = new System.Windows.Forms.GroupBox();
            this.textBoxTwo_LAV = new System.Windows.Forms.TextBox();
            this.buttonHelp_LAV = new System.Windows.Forms.Button();
            this.buttonStart_LAV = new System.Windows.Forms.Button();
            this.groupBoxOne_LAV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_LAV)).BeginInit();
            this.groupBoxTwo_LAV.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOne_LAV
            // 
            this.groupBoxOne_LAV.Controls.Add(this.textBoxOne_LAV);
            this.groupBoxOne_LAV.Location = new System.Drawing.Point(13, 13);
            this.groupBoxOne_LAV.Name = "groupBoxOne_LAV";
            this.groupBoxOne_LAV.Size = new System.Drawing.Size(235, 304);
            this.groupBoxOne_LAV.TabIndex = 0;
            this.groupBoxOne_LAV.TabStop = false;
            this.groupBoxOne_LAV.Text = "Условия";
            // 
            // textBoxOne_LAV
            // 
            this.textBoxOne_LAV.Location = new System.Drawing.Point(7, 20);
            this.textBoxOne_LAV.Multiline = true;
            this.textBoxOne_LAV.Name = "textBoxOne_LAV";
            this.textBoxOne_LAV.ReadOnly = true;
            this.textBoxOne_LAV.Size = new System.Drawing.Size(218, 235);
            this.textBoxOne_LAV.TabIndex = 0;
            this.textBoxOne_LAV.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в пятой строке на 0.";
            // 
            // dataGridViewInput_LAV
            // 
            this.dataGridViewInput_LAV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInput_LAV.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewInput_LAV.Name = "dataGridViewInput_LAV";
            this.dataGridViewInput_LAV.Size = new System.Drawing.Size(274, 245);
            this.dataGridViewInput_LAV.TabIndex = 1;
            this.dataGridViewInput_LAV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInput_LAV_CellContentClick);
            // 
            // groupBoxTwo_LAV
            // 
            this.groupBoxTwo_LAV.Controls.Add(this.textBoxTwo_LAV);
            this.groupBoxTwo_LAV.Controls.Add(this.dataGridViewInput_LAV);
            this.groupBoxTwo_LAV.Location = new System.Drawing.Point(254, 13);
            this.groupBoxTwo_LAV.Name = "groupBoxTwo_LAV";
            this.groupBoxTwo_LAV.Size = new System.Drawing.Size(286, 304);
            this.groupBoxTwo_LAV.TabIndex = 1;
            this.groupBoxTwo_LAV.TabStop = false;
            this.groupBoxTwo_LAV.Text = "Вывод данных";
            // 
            // textBoxTwo_LAV
            // 
            this.textBoxTwo_LAV.Location = new System.Drawing.Point(6, 19);
            this.textBoxTwo_LAV.Name = "textBoxTwo_LAV";
            this.textBoxTwo_LAV.ReadOnly = true;
            this.textBoxTwo_LAV.Size = new System.Drawing.Size(100, 20);
            this.textBoxTwo_LAV.TabIndex = 0;
            this.textBoxTwo_LAV.Text = "Результат:";
            this.textBoxTwo_LAV.TextChanged += new System.EventHandler(this.textBoxTwo_LAV_TextChanged);
            // 
            // buttonHelp_LAV
            // 
            this.buttonHelp_LAV.Location = new System.Drawing.Point(559, 249);
            this.buttonHelp_LAV.Name = "buttonHelp_LAV";
            this.buttonHelp_LAV.Size = new System.Drawing.Size(229, 55);
            this.buttonHelp_LAV.TabIndex = 2;
            this.buttonHelp_LAV.Text = "СПРАВКА";
            this.buttonHelp_LAV.UseVisualStyleBackColor = true;
            this.buttonHelp_LAV.Click += new System.EventHandler(this.buttonHelp_LAV_Click);
            // 
            // buttonStart_LAV
            // 
            this.buttonStart_LAV.Location = new System.Drawing.Point(559, 187);
            this.buttonStart_LAV.Name = "buttonStart_LAV";
            this.buttonStart_LAV.Size = new System.Drawing.Size(229, 56);
            this.buttonStart_LAV.TabIndex = 3;
            this.buttonStart_LAV.Text = "ВЫПОЛНИТЬ";
            this.buttonStart_LAV.UseVisualStyleBackColor = true;
            this.buttonStart_LAV.Click += new System.EventHandler(this.buttonStart_LAV_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 332);
            this.Controls.Add(this.buttonStart_LAV);
            this.Controls.Add(this.buttonHelp_LAV);
            this.Controls.Add(this.groupBoxTwo_LAV);
            this.Controls.Add(this.groupBoxOne_LAV);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "| Спринт 6 | Таск 3 | Вариант 30 | Гооге Р. А. ";
            this.Load += new System.EventHandler(this.FormMain_Load_LAV);
            this.groupBoxOne_LAV.ResumeLayout(false);
            this.groupBoxOne_LAV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInput_LAV)).EndInit();
            this.groupBoxTwo_LAV.ResumeLayout(false);
            this.groupBoxTwo_LAV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOne_LAV;
        private System.Windows.Forms.DataGridView dataGridViewInput_LAV;
        private System.Windows.Forms.TextBox textBoxOne_LAV;
        private System.Windows.Forms.GroupBox groupBoxTwo_LAV;
        private System.Windows.Forms.TextBox textBoxTwo_LAV;
        private System.Windows.Forms.Button buttonHelp_LAV;
        private System.Windows.Forms.Button buttonStart_LAV;
    }
}