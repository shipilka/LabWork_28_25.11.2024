using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace LabWork_28_25._11._2024
{
    public partial class Task3 : Form
    {
        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {

            DataGridViewTextBoxColumn codeColumn = new DataGridViewTextBoxColumn();
            codeColumn.HeaderText = "Код";
            codeColumn.Name = "Код";
            codeColumn.Visible = false;
            dataGridView1.Columns.Add(codeColumn);

            DataGridViewTextBoxColumn nameColumn = new DataGridViewTextBoxColumn();
            nameColumn.HeaderText = "Название";
            nameColumn.Name = "Название";
            dataGridView1.Columns.Add(nameColumn);

            DataGridViewTextBoxColumn priceColumn = new DataGridViewTextBoxColumn();
            priceColumn.HeaderText = "Цена";
            priceColumn.Name = "Цена";
            dataGridView1.Columns.Add(priceColumn);

            DataGridViewCheckBoxColumn addToCartColumn = new DataGridViewCheckBoxColumn();
            addToCartColumn.HeaderText = "В корзину";
            addToCartColumn.Name = "В корзину";
            dataGridView1.Columns.Add(addToCartColumn);


            for (int i = 1; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i, $"Товар {i}", i * 100, false);
            }


            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;


            dataGridView1.Columns["Цена"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["Цена"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;




            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            for (int i = 1; i <= 10; i++)
            {
                dataGridView1.Rows.Add(i, $"Товар {i}", i * 100, false);
            }

            dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dataGridView1.Columns["Цена"].DefaultCellStyle.Format = "C";
            dataGridView1.Columns["Цена"].DefaultCellStyle.FormatProvider = CultureInfo.CurrentCulture;

            button1.Click += button1_Click;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0;
            string orderSummary = "";
            bool itemsSelected = false;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1["В корзину", i].Value != null && (bool)dataGridView1["В корзину", i].Value)
                {
                    string productName = dataGridView1["Название", i].Value.ToString();
                    decimal productPrice = decimal.Parse(dataGridView1["Цена", i].Value.ToString());
                    orderSummary += $"{productName} - {productPrice:C}\n";
                    totalCost += productPrice;
                    itemsSelected = true;
                }
            }
            if (itemsSelected)
            {
                label1.Text = $"{orderSummary}\nИтого: {totalCost:C}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, отметьте товары для заказа.");
            }
        }
    }

}
