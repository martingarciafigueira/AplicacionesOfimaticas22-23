namespace Actividad6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPulsame_Click(object sender, EventArgs e)
        {
            lblContenido.Text = "Hola Mundo!";
            lblContenido.ForeColor = Color.Red;
        }
    }
}