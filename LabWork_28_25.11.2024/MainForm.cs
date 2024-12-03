namespace LabWork_28_25._11._2024
{
    

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            Task1 form = new Task1();
            form.ShowDialog();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            Task2 form = new Task2();
            form.ShowDialog();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            Task3 form = new Task3();
            form.ShowDialog();
        }

        

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
