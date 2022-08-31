using DLLErstellen;

namespace DLLNutzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            lblDisplay.Text = vespa + "";
            vespa.Beschleunigen(20);
            lblDisplay.Text += "\n" + vespa;
        }
    }
}