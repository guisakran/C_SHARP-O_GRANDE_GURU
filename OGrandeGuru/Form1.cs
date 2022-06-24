using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OGrandeGuru
{
    public partial class Form1 : Form
    {
        bool EscreveResposta;
        string Pesgunta;
        string Resposta;

        public Form1()
        {
            InitializeComponent();
        
            EscreveResposta = false;
            Pesgunta = "ola grandioso magnifico e eximio guru o detentor de todo o conhecimento universal, eu humildemente lhe peço um minuto do seu tempo para que responda uma pergunta de extra importancia";
            Resposta = "";
        }

        private void txtPergunta_KeyDown(object sender, KeyEventArgs e)
        {
            //Ctrl
            if ((e.KeyValue == 17) && (EscreveResposta == false))
                EscreveResposta = true;
            else if ((e.KeyValue == 17) && (EscreveResposta == true))
                EscreveResposta = false;

            //Enter
            else if (e.KeyValue == 13)
                btnResponder_Click(btnResponder, null);
        }

        private void txtPergunta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (EscreveResposta == true && e.KeyChar.ToString().Length == 1)
            {
                Resposta = Resposta + e.KeyChar;

                txtPergunta.Text = Pesgunta.Substring(0, txtPergunta.Text.Length + 1);
                txtPergunta.Focus();
                txtPergunta.Select(txtPergunta.Text.Length, 0);

                e.Handled = true;//anula evento do digito
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            if (Resposta == "")
                Responder();

            lblResposta.Text = Resposta;
            EscreveResposta = false;
            Resposta = "";
        }

        private void Responder()
        {
            Random rnd = new Random();

            string[] TEXTO = { "",
                            "Não vou responder!",
                            "Não quero me comprometer com isso, uma vez que \nneste momento tenho outras prioridades.",
                            "Não é um bom momento, estou no meio de uma coisa.",
                            "Podemos conversar outra hora!",
                            "Deixe-me pensar primeiro e outro dia darei \nminha resposta.",
                            "Não sou o melhor ser para ajudar com isso.",
                            "Não, não posso responder.",
                            "Desculpe, mas eu não posso ajudar.",
                            "Desconheço a questão.",
                            "Não tenho uma resposta apropriada.",
                            "Meus conhecimentos não serve a essa finalidade.",
                            "Não tenho vontade de responder.",
                            "Falar a verdade, fico até envergonhado em responder.",
                            "Essa é uma pergunta importante e eu não quero dar \numa resposta incompleta. \nDeixe-me responder outra hora.",
                            "Não posso dizer com certeza." };



            Resposta = TEXTO[rnd.Next(1, 16)];
        }

    }
}
