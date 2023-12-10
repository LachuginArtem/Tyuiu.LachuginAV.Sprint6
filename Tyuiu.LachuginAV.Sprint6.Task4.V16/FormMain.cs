using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.LachuginAV.Sprint6.Task4.V16.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task4.V16
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

                int startStep = Convert.ToInt32(textBoxStart_LAV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_LAV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunc_LAV.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunc_LAV.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxRes_LAV.Text = "";

                chartFunc_LAV.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunc_LAV.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxRes_LAV.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonFile_LAV_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\visual studio\Tyuiu.LachuginAV.Sprint6\Tyuiu.LachuginAV.Sprint6.Task4.V16\bin\Debug\OutPutFileTask4V16.txt";
                File.WriteAllText(path, textBoxRes_LAV.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonHelp_LAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы АСОиУБ-23-3 Лачугин Артем Викторович", "Cообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      
    }
}