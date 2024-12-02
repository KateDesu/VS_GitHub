namespace VS_GitHub
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Операции при загрузке формы
        }
    }
}
