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
    

    public partial class Task2 : Form
    {
        private List<Student> students = new List<Student>();

        public Task2()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        
            private void Task2_Load(object sender, EventArgs e)
            {
                List<Student> students = new List<Student>();
                students.Add(new Student { FIO = "Иванов Александр Дмитриевич", Speciality = "Геофизическое исследование скважин", Course = 2 });
                students.Add(new Student { FIO = "Суминова Марина Сергеевна", Speciality = "Прикладная математика", Course = 3 });
                students.Add(new Student { FIO = "Сидоренко Олег Дмитриевич", Speciality = "Четвертичная геология", Course = 4 });
                students.Add(new Student { FIO = "Колтырина Виктория Сергеевна", Speciality = "Электротехника", Course = 5 });
                students.Add(new Student { FIO = "Гасанова Александра Вугаровна", Speciality = "Метрология, стандартизация и сертификация", Course = 1 });

            DataGridViewTextBoxColumn fullNameColumn = new DataGridViewTextBoxColumn();
            fullNameColumn.DataPropertyName = "FullName";
            fullNameColumn.HeaderText = "ФИО";
            dataGridView1.Columns.Add(fullNameColumn);

            DataGridViewTextBoxColumn specialtyColumn = new DataGridViewTextBoxColumn();
            specialtyColumn.DataPropertyName = "Specialty";
            specialtyColumn.HeaderText = "Специальность";
            dataGridView1.Columns.Add(specialtyColumn);

            DataGridViewTextBoxColumn courseColumn = new DataGridViewTextBoxColumn();
            courseColumn.DataPropertyName = "Course";
            courseColumn.HeaderText = "Курс";
            dataGridView1.Columns.Add(courseColumn);

            dataGridView1.DataSource = students;

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

    }
    public class Student
    {
        public string? FIO { get; set; }
        public string? Speciality { get; set; }
        public int Course { get; set; }
    }
}
