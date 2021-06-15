using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorNumeros {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void RESULTADO_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {

            Random Aleatorio = new Random();
            int Inicial = Convert.ToInt32(textBox1.Text);
            int Final = Convert.ToInt32(textBox2.Text);
            int Limite = Convert.ToInt32(textBox3.Text);

            int Sorteados;
            int[] verificador = new int[100];

            String Resultado = "";

            for (int i = 0; i <= Limite - 1; i++) {
            Inicio:
                Sorteados = Aleatorio.Next(Inicial, Final + 1);

                for (int x = 0; x <= Limite -1; x++) {
                    
                    if (verificador[x] == Sorteados) {
                        goto Inicio;
                    }
                }

                Resultado = Resultado + " " + Sorteados ;
                RESULTADO.Text = Resultado;
                verificador[i] = Sorteados;
            }
        }

       

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }
    }
}
