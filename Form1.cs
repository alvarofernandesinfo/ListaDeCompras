using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {        
        private String sPROGRAMA = "Lista de compras";          // Nome do programa
        private List<Itens> arrItens = new List<Itens>();       // Array de itens
        private List<Emails> arrEmails = new List<Emails>();    // Array de emails

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Seta nome do programa e versão
            this.Text = sPROGRAMA;

            tbxItem.Select();
        }

        private void btnInserirItem_Click(object sender, EventArgs e)
        {
            string sTmpItem  = tbxItem.Text;
            int    iTmpQuant = Convert.ToInt32(tbxQuant.Text);
            int    iTmpPreco = Convert.ToInt32(tbxPreco.Text);

            // Acrescenta esse item na lista
            Itens newItem = new Itens(sTmpItem, iTmpQuant, iTmpPreco);
            arrItens.Add(newItem);

            // Acrescenta esse item no TextBox apenas para informativo do que já foi incluído
            tbxItens.Text += tbxItem.Text + " " + tbxQuant.Text + " " + tbxPreco.Text + Environment.NewLine;

            // Limpa caixas de texto e preparar para inserir novo item
            tbxItem.Clear();
            tbxQuant.Clear();
            tbxPreco.Clear();
            tbxItem.Select();

            //foreach (Itens myitem in arrItens)
            //{
            //    Console.WriteLine($"Item: {myitem.item}:{myitem.quantidade}:{myitem.preco}");
            //}
        }

        private void btnInserirEmail_Click(object sender, EventArgs e)
        {
            string sTmpEmail = tbxEmail.Text;

            // Acrescenta esse email na lista com valor zerado
            Emails newEmail = new Emails(sTmpEmail, 0);
            arrEmails.Add(newEmail);

            // Acrescenta esse item no TextBox apenas para informativo do que já foi incluído
            tbxEmails.Text += tbxEmail.Text + Environment.NewLine;

            // Limpa caixa de texto e prepara para inserir novo item
            tbxEmail.Clear();
            tbxEmail.Select();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int iValTotal = 0;
            int iValPorEmail;

            // Calcula valor de cada item e soma ao total;
            foreach (Itens eachitem in arrItens)
            {
                iValTotal += (eachitem.quantidade * eachitem.preco); 
            }

            // Divide o total pela quant de emails
            iValPorEmail = iValTotal / arrEmails.Count;

            // Verifica se tem resto
            int resto = iValTotal % arrEmails.Count;

            // Percorre a lista de emails
            foreach (Emails eachemail in arrEmails)
            {
                // enquanto ainda houver resto  
                if (resto > 0)
                {
                    eachemail.valor = iValPorEmail + 1; // esse email recebe 1 centavo a mais
                    resto--;
                }
                else
                {
                    eachemail.valor = iValPorEmail; // se não, recebe o valor calculado normal
                }
            }

            // Acrescenta esse item no TextBox para informar qual o valor para cada email
            int i = 0;
            foreach (Emails eachemail in arrEmails)
            {
                tbxValores.Text += arrEmails[i++].email + " " + eachemail.valor.ToString() + Environment.NewLine;
            }
        }
    }
}
