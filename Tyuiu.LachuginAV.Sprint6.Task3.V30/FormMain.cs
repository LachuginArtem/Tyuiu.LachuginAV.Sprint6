using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.LachuginAV.Sprint6.Task3.V30.Lib;

namespace Tyuiu.LachuginAV.Sprint6.Task3.V30
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -9, -4, 17, -1, -20,},
                                          { -19, 18, -4, 2, 14,},
                                          { -12, 16, -2, 7, 18,},
                                          { -16, 15, 4, -12, -13,},
                                          { -15, -4, -16, 1, -14,}, };
        public FormMain()
        {
            InitializeComponent();

        }

        private void buttonHelp_LAV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Задание выполнил студент группы AСОиУБ-23-3 Лачугин А.В.", "Справка");
        }

        private void dataGridViewInput_LAV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormMain_Load_LAV(object sender, EventArgs e)
        {

            dataGridViewInput_LAV.RowCount = matrix.GetLength(0);
            dataGridViewInput_LAV.ColumnCount = matrix.GetLength(1);
            for (int i = 0; i < dataGridViewInput_LAV.ColumnCount; i++)
            {
                dataGridViewInput_LAV.Columns[i].Width = 25;
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput_LAV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }

        }

        private void buttonStart_LAV_Click(object sender, EventArgs e)
        {
            matrix = ds.Calculate(matrix);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    dataGridViewInput_LAV.Rows[i].Cells[j].Value = matrix[i, j];
                }
            }
        }

        private void textBoxTwo_LAV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}