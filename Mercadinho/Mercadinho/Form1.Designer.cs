namespace Mercadinho
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbBarCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBarCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbHora = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbtxtPreco = new System.Windows.Forms.Label();
            this.lbtxtDesc = new System.Windows.Forms.Label();
            this.lbtxtQuant = new System.Windows.Forms.Label();
            this.lbxtTotal = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.lbDesconto = new System.Windows.Forms.Label();
            this.lbPreco = new System.Windows.Forms.Label();
            this.dgCompra = new System.Windows.Forms.DataGridView();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Totalcompralb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.FinalCompra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Caixa = new System.Windows.Forms.Label();
            this.lbCaixa = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbBarCode
            // 
            this.lbBarCode.AutoSize = true;
            this.lbBarCode.Font = new System.Drawing.Font("Free 3 of 9 Extended", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarCode.Location = new System.Drawing.Point(42, 227);
            this.lbBarCode.Name = "lbBarCode";
            this.lbBarCode.Size = new System.Drawing.Size(65, 22);
            this.lbBarCode.TabIndex = 0;
            this.lbBarCode.Text = "12223";
            this.lbBarCode.Click += new System.EventHandler(this.lbBarCode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 2;
            // 
            // tbBarCode
            // 
            this.tbBarCode.Location = new System.Drawing.Point(46, 259);
            this.tbBarCode.MaxLength = 13;
            this.tbBarCode.Name = "tbBarCode";
            this.tbBarCode.Size = new System.Drawing.Size(100, 20);
            this.tbBarCode.TabIndex = 3;
            this.tbBarCode.TextChanged += new System.EventHandler(this.txtLB_TextChanged);
            this.tbBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLB_KeyDown);
            this.tbBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBarCode_KeyPress);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(813, 424);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(89, 25);
            this.lbHora.TabIndex = 4;
            this.lbHora.Text = "Horário";
            this.lbHora.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbData.Location = new System.Drawing.Point(0, 424);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(68, 25);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Data:";
            this.lbData.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbtxtPreco
            // 
            this.lbtxtPreco.AutoSize = true;
            this.lbtxtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtPreco.Location = new System.Drawing.Point(-4, 8);
            this.lbtxtPreco.Name = "lbtxtPreco";
            this.lbtxtPreco.Size = new System.Drawing.Size(133, 24);
            this.lbtxtPreco.TabIndex = 6;
            this.lbtxtPreco.Text = "Preço Unitário:";
            // 
            // lbtxtDesc
            // 
            this.lbtxtDesc.AutoSize = true;
            this.lbtxtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtDesc.Location = new System.Drawing.Point(-4, 41);
            this.lbtxtDesc.Name = "lbtxtDesc";
            this.lbtxtDesc.Size = new System.Drawing.Size(100, 24);
            this.lbtxtDesc.TabIndex = 7;
            this.lbtxtDesc.Text = "Desconto: ";
            // 
            // lbtxtQuant
            // 
            this.lbtxtQuant.AutoSize = true;
            this.lbtxtQuant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtxtQuant.Location = new System.Drawing.Point(-4, 65);
            this.lbtxtQuant.Name = "lbtxtQuant";
            this.lbtxtQuant.Size = new System.Drawing.Size(118, 24);
            this.lbtxtQuant.TabIndex = 8;
            this.lbtxtQuant.Text = "Quantidade: ";
            // 
            // lbxtTotal
            // 
            this.lbxtTotal.AutoSize = true;
            this.lbxtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxtTotal.Location = new System.Drawing.Point(-4, 104);
            this.lbxtTotal.Name = "lbxtTotal";
            this.lbxtTotal.Size = new System.Drawing.Size(61, 24);
            this.lbxtTotal.TabIndex = 9;
            this.lbxtTotal.Text = "Total: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(161, 100);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(20, 24);
            this.lbTotal.TabIndex = 13;
            this.lbTotal.Text = "0";
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidade.Location = new System.Drawing.Point(161, 65);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(20, 24);
            this.lbQuantidade.TabIndex = 12;
            this.lbQuantidade.Text = "0";
            // 
            // lbDesconto
            // 
            this.lbDesconto.AutoSize = true;
            this.lbDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesconto.Location = new System.Drawing.Point(161, 41);
            this.lbDesconto.Name = "lbDesconto";
            this.lbDesconto.Size = new System.Drawing.Size(20, 24);
            this.lbDesconto.TabIndex = 11;
            this.lbDesconto.Text = "0";
            // 
            // lbPreco
            // 
            this.lbPreco.AutoSize = true;
            this.lbPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreco.Location = new System.Drawing.Point(161, 8);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(20, 24);
            this.lbPreco.TabIndex = 10;
            this.lbPreco.Text = "0";
            this.lbPreco.Click += new System.EventHandler(this.lbPreco_Click);
            // 
            // dgCompra
            // 
            this.dgCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Produto,
            this.Preco,
            this.Desconto,
            this.Quantidade,
            this.Total});
            this.dgCompra.Location = new System.Drawing.Point(275, 178);
            this.dgCompra.Name = "dgCompra";
            this.dgCompra.Size = new System.Drawing.Size(440, 123);
            this.dgCompra.TabIndex = 14;
            this.dgCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCompra_CellContentClick);
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::Mercadinho.Properties.Resources.Apu;
            this.pictureBox3.Location = new System.Drawing.Point(736, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(166, 150);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mercadinho.Properties.Resources.kwik_e_mart_sign_paul_van_scott;
            this.pictureBox2.Location = new System.Drawing.Point(615, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(296, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Mercadinho.Properties.Resources.ApuC;
            this.pictureBox1.Location = new System.Drawing.Point(28, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Totalcompralb
            // 
            this.Totalcompralb.AutoSize = true;
            this.Totalcompralb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Totalcompralb.Location = new System.Drawing.Point(3, 17);
            this.Totalcompralb.Name = "Totalcompralb";
            this.Totalcompralb.Size = new System.Drawing.Size(128, 24);
            this.Totalcompralb.TabIndex = 18;
            this.Totalcompralb.Text = "Total Compra:";
            this.Totalcompralb.Click += new System.EventHandler(this.Totalcompralb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "0";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // Sair
            // 
            this.Sair.BackgroundImage = global::Mercadinho.Properties.Resources._1;
            this.Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(736, 298);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(166, 50);
            this.Sair.TabIndex = 20;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // FinalCompra
            // 
            this.FinalCompra.BackColor = System.Drawing.SystemColors.HotTrack;
            this.FinalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalCompra.Location = new System.Drawing.Point(242, 3);
            this.FinalCompra.Name = "FinalCompra";
            this.FinalCompra.Size = new System.Drawing.Size(130, 53);
            this.FinalCompra.TabIndex = 21;
            this.FinalCompra.Text = "Finalizar Compra";
            this.FinalCompra.UseVisualStyleBackColor = false;
            this.FinalCompra.Click += new System.EventHandler(this.FinalCompra_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbBarCode);
            this.panel1.Controls.Add(this.lbBarCode);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 336);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbtxtPreco);
            this.panel2.Controls.Add(this.lbPreco);
            this.panel2.Controls.Add(this.lbtxtDesc);
            this.panel2.Controls.Add(this.lbDesconto);
            this.panel2.Controls.Add(this.lbtxtQuant);
            this.panel2.Controls.Add(this.lbQuantidade);
            this.panel2.Controls.Add(this.lbxtTotal);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Location = new System.Drawing.Point(275, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 130);
            this.panel2.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Totalcompralb);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.FinalCompra);
            this.panel3.Location = new System.Drawing.Point(275, 324);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(375, 62);
            this.panel3.TabIndex = 24;
            // 
            // Caixa
            // 
            this.Caixa.AutoSize = true;
            this.Caixa.Location = new System.Drawing.Point(774, 272);
            this.Caixa.Name = "Caixa";
            this.Caixa.Size = new System.Drawing.Size(36, 13);
            this.Caixa.TabIndex = 25;
            this.Caixa.Text = "Caixa:";
            // 
            // lbCaixa
            // 
            this.lbCaixa.AutoSize = true;
            this.lbCaixa.Location = new System.Drawing.Point(806, 272);
            this.lbCaixa.Name = "lbCaixa";
            this.lbCaixa.Size = new System.Drawing.Size(19, 13);
            this.lbCaixa.TabIndex = 26;
            this.lbCaixa.Text = "15";
            this.lbCaixa.Click += new System.EventHandler(this.lbCaixa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 448);
            this.Controls.Add(this.lbCaixa);
            this.Controls.Add(this.Caixa);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dgCompra);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbHora);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kwik-e-Mart";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbBarCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBarCode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbtxtPreco;
        private System.Windows.Forms.Label lbtxtDesc;
        private System.Windows.Forms.Label lbtxtQuant;
        private System.Windows.Forms.Label lbxtTotal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.Label lbDesconto;
        private System.Windows.Forms.Label lbPreco;
        private System.Windows.Forms.DataGridView dgCompra;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label Totalcompralb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button FinalCompra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Caixa;
        private System.Windows.Forms.Label lbCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

