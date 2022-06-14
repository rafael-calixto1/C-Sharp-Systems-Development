using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcSimples
{
    public partial class frmCalculadora : Form
    {
        int contVisor;
        double valor1;
        double memAux;
        string operador;

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {
            contVisor = 0;
            valor1 = 0;
            memAux = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
          if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '1'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '2'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '3'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '4'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '5'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '6'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '7'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '8'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '9'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (contVisor != 9) //Verificando se o limite do visor foi ultrapassado 
            {
                txtVisor.Text += '0'; //Concatenação do valor 1 ao texto do visor
                contVisor++; //Incremento da variavel de controle de texto do visor
            }
         }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text !="") // Compara se a caixa de testo é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazenao valor do visor numa memória auxiliar
                operador = "+"; // atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto 
                contVisor = 0; //Zera o contador do visor 

                btnSoma.Enabled = false;
                btnsubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
            }
        }

        private void btnsubtracao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") // Compara se a caixa de testo é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazenao valor do visor numa memória auxiliar
                operador = "-"; // atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto 
                contVisor = 0; //Zera o contador do visor 

                btnSoma.Enabled = false;
                btnsubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
            }
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") // Compara se a caixa de testo é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazenao valor do visor numa memória auxiliar
                operador = "*"; // atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto 
                contVisor = 0; //Zera o contador do visor 

                btnSoma.Enabled = false;
                btnsubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
            }
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") // Compara se a caixa de testo é diferente de vazio
            {
                valor1 = Convert.ToDouble(txtVisor.Text); // Armazenao valor do visor numa memória auxiliar
                operador = "/"; // atribui o tipo de operação
                txtVisor.Clear(); //Limpa a caixa de texto 
                contVisor = 0; //Zera o contador do visor 

                btnSoma.Enabled = false;
                btnsubtracao.Enabled = false;
                btnMultiplicacao.Enabled = false;
                btnDivisao.Enabled = false;
            }
        }

        private void btnigual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "") //Compara se a caixa de texto é diferente de vazio)
            {
                memAux = Convert.ToDouble(txtVisor.Text);

                switch (operador)
                {
                    case "+":
                        valor1 += memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;
                    case "-":
                        valor1 -= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;
                    case "*":
                        valor1 *= memAux;
                        txtVisor.Text = Convert.ToString(valor1);
                        valor1 = 0;
                        break;
                    case "/":
                        if (valor1 != 0 && memAux != 0)
                        {
                            valor1 = valor1 / memAux;
                            txtVisor.Text = Convert.ToString(valor1);
                            valor1 = 0;
                        } else
                        {
                            MessageBox.Show("Impossivel realizar divisão por Zero!", "Erro de execução");
                            valor1 = 0;
                            memAux = 0;
                            txtVisor.Clear();
                        }
                        break;
                    default:
                        break;
                }
                contVisor = 0;

                btnSoma.Enabled = true;
                btnsubtracao.Enabled = true;
                btnMultiplicacao.Enabled = true;
                btnDivisao.Enabled = true;

            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            valor1 = memAux = contVisor = 0;

            btnSoma.Enabled = true;
            btnsubtracao.Enabled = true;
            btnMultiplicacao.Enabled = true;
            btnDivisao.Enabled = true;
        }
    }
}
