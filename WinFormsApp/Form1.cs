using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool res1 = int.TryParse(textBox1.Text, out int i);
            bool res2 = int.TryParse(textBox2.Text, out int j);

            if (!res1 || !res2)
            {
                MessageBox.Show("Operacja niedozwolona.");
                return;
            }

            short operation = 0;
            if (cbDodaj.Checked)
                operation = 1;
            else if (cbOdejmij.Checked)
                operation = 2;
            else if (cbPomnoz.Checked)
                operation = 3;
            else if (cbPodziel.Checked)
                operation = 4;

            int wynikI;
            float wynikF;
            switch (operation)
            {
                case 1:
                    wynikI = i + j;
                    MessageBox.Show($"Wynik dodawania to: {wynikI}");
                    break;
                case 2:
                    wynikI = i - j;
                    MessageBox.Show($"Wynik odejmowania to: {wynikI}");
                    break;
                case 3:
                    wynikI = i * j;
                    MessageBox.Show($"Wynik mnożenia to: {wynikI}");
                    break;
                case 4:
                    wynikF = (float)i / j;
                    MessageBox.Show($"Wynik dzielenia to: {wynikF}");
                    break;
                default:
                    MessageBox.Show("Operacja niedozwolona.");
                    break;
            }

        }
    }
}