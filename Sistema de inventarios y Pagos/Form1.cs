namespace Sistema_de_inventarios_y_Pagos_
{
    public partial class Form1 : Form
    {
        private bool isMaximized = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (isMaximized)
            {
                // Restaurar el tamaño original
                this.WindowState = FormWindowState.Normal;
                this.StartPosition = FormStartPosition.CenterScreen;

            }
            else
            {
                // Maximizar el formulario
                this.WindowState = FormWindowState.Maximized;

            }
            isMaximized = !isMaximized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
