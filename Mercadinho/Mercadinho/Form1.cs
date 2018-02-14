using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mercadinho
{
    public partial class Form1 : Form
    {
        public double y = 0;
        public double valor = 0, tvalor = 0;
        public int cupom = 1;
        int seq = 1;



        public Form1()
        {


            InitializeComponent();

            lbData.Text = DateTime.Now.ToString("dd/MM/yyyy");



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            lbQuantidade.Text = "1";
            pegaCupom();





            tbBarCode.Focus();



        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtLB_TextChanged(object sender, EventArgs e)
        {

        }



        private void limpa_Foto()
        {
            // Limpa campos para nova pesquisa

            pictureBox1.Image = Properties.Resources.Apu;
            tbBarCode.Focus();
            lbBarCode.Text = "";


        }



        private void pegaCupom()
        {
            conexao comb = new conexao();

            int maxCupom = 0;

            comb.open();

            comb.sql = "Select max(tb02_cupom) from tb02_vendas ";
            comb.sql += " where tb02_nro_caixa = '" + lbCaixa.Text + "'";

            maxCupom = Convert.ToInt32(comb.ExecuteScalar());

            if (maxCupom > 0)
            {
                cupom = maxCupom;
                cupom++;
                seq = 1;
            }

            comb.close();
        }



        private void ColetaSQL()
        {


            conexao comb = new conexao();
            comb.open();

            comb.sql = "Select * from tb01_produtos ";
            comb.sql += " where tb01_cod_produto = '" + tbBarCode.Text + "'";


            MySqlDataReader dados = comb.Execsql();

            if (dados.HasRows)
            {
                while (dados.Read())
                {


                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");


                    valor = System.Convert.ToDouble(dados["tb01_desconto"]);
                    lbDesconto.Text = string.Format("{0:C}", Convert.ToDouble(valor));

                    valor = (System.Convert.ToDouble(dados["tb01_preco"]) - System.Convert.ToDouble(dados["tb01_desconto"])) * System.Convert.ToDouble(lbQuantidade.Text);
                    lbTotal.Text = string.Format("{0:C}", Convert.ToDouble(valor));

                    y = valor;

                    valor = System.Convert.ToDouble(dados["tb01_preco"]);
                    lbPreco.Text = string.Format("{0:C}", Convert.ToDouble(valor));

                    label1.Text = dados["tb01_descricao"].ToString();

                    dgCompra.Rows.Add(label1.Text, lbPreco.Text, lbDesconto.Text, lbQuantidade.Text, lbTotal.Text);

                    tvalor = (System.Convert.ToDouble(dados["tb01_preco"]) - System.Convert.ToDouble(dados["tb01_desconto"])) * System.Convert.ToDouble(lbQuantidade.Text) + tvalor;
                    label3.Text = string.Format("{0:C}", Convert.ToDouble(tvalor));

                   Gravar();


                    seq = seq + 1;


                }

            }
            comb.close();
        }


        private void Gravar()
        {


            conexao comb2 = new conexao();

            comb2.open();

            comb2.sql = "insert into tb02_vendas values ('" + lbCaixa.Text + "','" + cupom + "','" + seq + "','" + tbBarCode.Text + "','" + lbQuantidade.Text + "','" + y + "')";



            int qn = comb2.Runsql();
            comb2.close();



        }



        private void txtLB_KeyDown(object sender, KeyEventArgs e)
        {





            if (tbBarCode.Text.Length.Equals(12))
            {
                ColetaSQL();
                e.Handled = true;
                SendKeys.Send("{ENTER}");
            }


            if (tbBarCode.Text.Length.Equals(13))
            {
                ColetaSQL();

                lbBarCode.Text = tbBarCode.Text;

                String arqFoto = tbBarCode.Text;
                string letra = System.AppDomain.CurrentDomain.BaseDirectory.ToString().Substring(0, 2);
                string local = letra + "/ImagensProdutos/";




                string fotoString = System.IO.Path.Combine(local + @"/" + arqFoto + @".jpg");


                if (!System.IO.File.Exists(fotoString))
                {
                    limpa_Foto();
                    MessageBox.Show("Imagem não encontrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    label1.Text = "";
                    return;
                    tbBarCode.Text = "";
                }


                pictureBox1.Image = Image.FromFile(fotoString);



                tbBarCode.Text = "";


                //label1.Focus();



            }
        }

        private void lbPreco_Click(object sender, EventArgs e)
        {

        }

        private void dgCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void lbBarCode_Click(object sender, EventArgs e)
        {

        }

        private void FinalCompra_Click(object sender, EventArgs e)
        {
            EncerrarCompra();

        }

        private void lbCaixa_Click(object sender, EventArgs e)
        {

        }

        private void Totalcompralb_Click(object sender, EventArgs e)
        {

        }


        private void EncerrarCompra()
        {


            dgCompra.Rows.Clear();
            lbPreco.Text = "";
            tbBarCode.Text = "";
            lbBarCode.Text = "";
            lbTotal.Text = "";
            lbDesconto.Text = "";
            label3.Text = "";
            seq = 1;
            valor = 0;
            tvalor = 0;
            label1.Text = "";
            cupom++;


            pictureBox1.Image = Properties.Resources.ApuC;
            tbBarCode.Focus();

        }






        private void tbBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Escape)
            {
                EncerrarCompra();
            }






        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
          //  if (e.KeyChar >= 49 && e.KeyChar <= 57)
          //  {
            //    EncerrarCompra();


            // }
        }
    }
}
