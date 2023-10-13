using Practica2._2.Entities;
namespace Practica2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Calculador gus = new();
        private void button1_Click(object sender, EventArgs e)
        {
            int Cantidad = int.Parse(textBox1.Text);
            gus.AgregarNumero(Cantidad);
            gus.CrearParesNones();
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            List<Numero> Numeros = gus.Numeros;
            foreach (var numero in Numeros) 
            {
                listBox1.Items.Add($"{numero.Num} ");
            }
            List<Numero> NumerosPares = gus.NumerosPares;
            foreach (var numero in NumerosPares)
            {
                listBox2.Items.Add($"{numero.Num} ");
            }
            List<Numero> NumerosImpares = gus.NumerosImpares;
            foreach (var numero in NumerosImpares)
            {
                listBox3.Items.Add($"{numero.Num} ");
            }
        }
    }
}