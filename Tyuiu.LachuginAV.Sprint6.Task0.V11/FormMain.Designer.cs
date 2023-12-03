
namespace Tyuiu.LachuginAV.Sprint6.Task0.V11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonResult_AV = new System.Windows.Forms.Button();
            this.buttonHelp_AV = new System.Windows.Forms.Button();
            this.textBoxPress_AV = new System.Windows.Forms.TextBox();
            this.textBoxResult_AV = new System.Windows.Forms.TextBox();
            this.labelX_AV = new System.Windows.Forms.Label();
            this.labelRezult = new System.Windows.Forms.Label();
            this.labelFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonResult_AV
            // 
            this.buttonResult_AV.Location = new System.Drawing.Point(489, 311);
            this.buttonResult_AV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonResult_AV.Name = "buttonResult_AV";
            this.buttonResult_AV.Size = new System.Drawing.Size(102, 45);
            this.buttonResult_AV.TabIndex = 0;
            this.buttonResult_AV.Text = "Применить";
            this.buttonResult_AV.UseVisualStyleBackColor = true;
            this.buttonResult_AV.Click += new System.EventHandler(this.buttonResult_AV_Click);
            // 
            // buttonHelp_AV
            // 
            this.buttonHelp_AV.Location = new System.Drawing.Point(430, 311);
            this.buttonHelp_AV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHelp_AV.Name = "buttonHelp_AV";
            this.buttonHelp_AV.Size = new System.Drawing.Size(56, 45);
            this.buttonHelp_AV.TabIndex = 1;
            this.buttonHelp_AV.Text = "?";
            this.buttonHelp_AV.UseVisualStyleBackColor = true;
            this.buttonHelp_AV.Click += new System.EventHandler(this.buttonHelp_AV_Click);
            // 
            // textBoxPress_AV
            // 
            this.textBoxPress_AV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPress_AV.Location = new System.Drawing.Point(34, 263);
            this.textBoxPress_AV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPress_AV.Name = "textBoxPress_AV";
            this.textBoxPress_AV.Size = new System.Drawing.Size(147, 27);
            this.textBoxPress_AV.TabIndex = 2;
            // 
            // textBoxResult_AV
            // 
            this.textBoxResult_AV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_AV.Location = new System.Drawing.Point(430, 263);
            this.textBoxResult_AV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxResult_AV.Name = "textBoxResult_AV";
            this.textBoxResult_AV.ReadOnly = true;
            this.textBoxResult_AV.Size = new System.Drawing.Size(162, 27);
            this.textBoxResult_AV.TabIndex = 3;
            this.textBoxResult_AV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResult_AV_KeyPress);
            // 
            // labelX_AV
            // 
            this.labelX_AV.AutoSize = true;
            this.labelX_AV.Location = new System.Drawing.Point(34, 234);
            this.labelX_AV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelX_AV.Name = "labelX_AV";
            this.labelX_AV.Size = new System.Drawing.Size(112, 13);
            this.labelX_AV.TabIndex = 4;
            this.labelX_AV.Text = "Введите значение Х:";
            // 
            // labelRezult
            // 
            this.labelRezult.AutoSize = true;
            this.labelRezult.Location = new System.Drawing.Point(428, 234);
            this.labelRezult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRezult.Name = "labelRezult";
            this.labelRezult.Size = new System.Drawing.Size(62, 13);
            this.labelRezult.TabIndex = 5;
            this.labelRezult.Text = "Результат:";
            // 
            // labelFormula
            // 
            this.labelFormula.AutoSize = true;
            this.labelFormula.Location = new System.Drawing.Point(32, 7);
            this.labelFormula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormula.Name = "labelFormula";
            this.labelFormula.Size = new System.Drawing.Size(51, 13);
            this.labelFormula.TabIndex = 6;
            this.labelFormula.Text = "Условие";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Вычислить выражение по формуле :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(259, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 42);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelFormula);
            this.Controls.Add(this.labelRezult);
            this.Controls.Add(this.labelX_AV);
            this.Controls.Add(this.textBoxResult_AV);
            this.Controls.Add(this.textBoxPress_AV);
            this.Controls.Add(this.buttonHelp_AV);
            this.Controls.Add(this.buttonResult_AV);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonResult_AV;
        private System.Windows.Forms.Button buttonHelp_AV;
        private System.Windows.Forms.TextBox textBoxPress_AV;
        private System.Windows.Forms.TextBox textBoxResult_AV;
        private System.Windows.Forms.Label labelX_AV;
        private System.Windows.Forms.Label labelRezult;
        private System.Windows.Forms.Label labelFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}