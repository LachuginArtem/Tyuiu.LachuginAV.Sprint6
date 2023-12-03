using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LachuginAV.Sprint6.Task1.V9.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task1.V9
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_LAV.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_LAV.Text);

                string strLine;

                int len = ds.GetMassFunction(startValue, stopValue).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_LAV.Text = "";
                textBoxResult_LAV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_LAV.AppendText("|     X    |    f(x)  |" + Environment.NewLine);
                textBoxResult_LAV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}     |  {1, 5:f1}   | ", startValue, valueArray[i]);
                    textBoxResult_LAV.AppendText(strLine + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_LAV.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_LAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1, вариант 9 выполнил студент группы АСОиУб-23-3 Лачугин артем Викторович", "Справка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}