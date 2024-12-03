using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_28_25._11._2024
{
    public partial class Task1 : Form
    {
        public Task1()
        {
            InitializeComponent();
        }



        private void Task1_Load(object sender, EventArgs e)
        {
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);



            
            dataGridView1.ColumnCount = 8; 
            for (int i = 0; i < 8; i++)
            {
                dataGridView1.Columns[i].HeaderText = (i + 2).ToString();
                dataGridView1.Columns[i].DefaultCellStyle.BackColor = Color.LightGreen; // Зеленый фон для столбцов множителей

            }

            dataGridView1.RowCount = 8;  
            for (int i = 2; i <= 9; i++)
            {
                dataGridView1.Rows[i - 2].HeaderCell.Value = i.ToString();
                dataGridView1.Rows[i - 2].HeaderCell.Style.BackColor = Color.LightGreen; // Зеленый фон для строк множителей
                for (int j = 2; j <= 9; j++)
                {
                    dataGridView1.Rows[i - 2].Cells[j - 2].Value = i * j;
                }
            }

            dataGridView1.CellClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int row = e.RowIndex + 2; 
                int col = e.ColumnIndex + 2; 
                MessageBox.Show($"{row} x {col} = {row * col}");
            }
        }
}
}
