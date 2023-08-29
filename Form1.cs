namespace Laboratorio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(minutostxt.Text, out int minutos))
            {
                int horas = minutos / 60;
                int minutosRestantes = minutos % 60;
                resultadolbl.Text = $"Horas: {horas} y minutos: {minutosRestantes}";
            }
            else
            {
                resultadolbl.Text = "Ingresa un valor válido en minutos.";
            }
        }
    }
}