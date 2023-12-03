using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LachuginAV.Sprint6.Task2.V5.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task2.V5
{
    public partial class FormMain_LAV : Form
    {
        DataService ds = new DataService();
        public FormMain_LAV()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDone_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStart_LAV.Text);
                int stop = Convert.ToInt32(textBoxStop_LAV.Text);
                int len = ds.GetMassFunction(start, stop).Length;
                double[] valueA = new double[len];
                valueA = ds.GetMassFunction(start, stop);
                this.chartResult_LAV.Titles.Add("График функции (2х-3/Cos(x)-2x)+5x-6");
                this.chartResult_LAV.ChartAreas[0].AxisX.Title = "Ось Х";
                this.chartResult_LAV.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewXY_LAV.Rows.Add(Convert.ToString(start), Convert.ToString(valueA[i]));
                    this.chartResult_LAV.Series[0].Points.AddXY(start, valueA[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonHelp_LAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУБ-23-3 Лачугин Артем Викторович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_LAV_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStart_LAV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonDone_LAV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_LAV.BackColor = Color.Red;
        }

        private void buttonDone_LAV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_LAV.BackColor = Color.Green;
        }

        private void buttonDone_LAV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_LAV.BackColor = Color.Blue;
        }
    }
}