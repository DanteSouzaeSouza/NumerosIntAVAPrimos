using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerosIntAVA
{
    public partial class FrmNumeros : Form
    {
        public FrmNumeros()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            // Limpando a lista
            lstNumeros.Items.Clear();

            // Iterar pelos números um a um
            for ( int i = 0; i <= 100; i++ )
            {
                // adicionando um a um dentro da ListBox
                lstNumeros.Items.Add(i);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpando a lista
            lstNumeros.Items.Clear();
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            // Limpando a lista
            lstNumeros.Items.Clear();

            // Criando a variável de controle
            int i = 0;

            while ( i <= 100)
            {
                // adicionando os elementos à lista
                lstNumeros.Items.Add(i);
                // incrementando a variável de controle
                i++;
            }



        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            // Limpando a lista
            lstNumeros.Items.Clear();

            // Criando a variável de controle
            int i = 0;

            do
            {
                // adicionando os elementos à lista
                lstNumeros.Items.Add(i);
                // incrementando a variável de controle
                i++;
            } while (i <= 100);
        }

        private void btnPrimos_Click(object sender, EventArgs e)
        {
            // Limpando a lista
            lstNumeros.Items.Clear();

            // Declaração das variáveis:
            int num = 1;
            int cont;

            // fazer o código ser rodado enquanto o tamanho da lista é menor ou igual a 100
            while (lstNumeros.Items.Count <= 100)
            {
                // variáveis de controle
                cont = 0;
                num++;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        cont++;
                    }
                }
                if (cont == 2)
                {
                    lstNumeros.Items.Add(num);
                }
            }
        }
    }
}
