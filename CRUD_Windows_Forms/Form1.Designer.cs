
namespace CRUD_Windows_Forms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbQtdSerie = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtInsDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtInsAno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInsTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInsGenero = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.txtEditarDescricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditarAno = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditarTitulo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEdiGenero = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listEdiSeriesTxt = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.listDelSeriesTxt = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.txtLista = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 365);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbQtdSerie);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.txtInsDescricao);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtInsAno);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtInsTitulo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtInsGenero);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Série";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Enter += new System.EventHandler(this.tabPage1_Enter);
            // 
            // lbQtdSerie
            // 
            this.lbQtdSerie.AutoSize = true;
            this.lbQtdSerie.Location = new System.Drawing.Point(162, 298);
            this.lbQtdSerie.Name = "lbQtdSerie";
            this.lbQtdSerie.Size = new System.Drawing.Size(13, 15);
            this.lbQtdSerie.TabIndex = 11;
            this.lbQtdSerie.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qtd Séries cadastradas:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnInserir);
            // 
            // txtInsDescricao
            // 
            this.txtInsDescricao.Location = new System.Drawing.Point(319, 110);
            this.txtInsDescricao.Name = "txtInsDescricao";
            this.txtInsDescricao.Size = new System.Drawing.Size(270, 23);
            this.txtInsDescricao.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição";
            // 
            // txtInsAno
            // 
            this.txtInsAno.Location = new System.Drawing.Point(27, 110);
            this.txtInsAno.Name = "txtInsAno";
            this.txtInsAno.Size = new System.Drawing.Size(275, 23);
            this.txtInsAno.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano";
            // 
            // txtInsTitulo
            // 
            this.txtInsTitulo.Location = new System.Drawing.Point(319, 47);
            this.txtInsTitulo.Name = "txtInsTitulo";
            this.txtInsTitulo.Size = new System.Drawing.Size(270, 23);
            this.txtInsTitulo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Título";
            // 
            // txtInsGenero
            // 
            this.txtInsGenero.Location = new System.Drawing.Point(27, 47);
            this.txtInsGenero.Name = "txtInsGenero";
            this.txtInsGenero.Size = new System.Drawing.Size(275, 23);
            this.txtInsGenero.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gênero";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.txtEditarDescricao);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtEditarAno);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtEditarTitulo);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtEdiGenero);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.listEdiSeriesTxt);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editar Série";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(19, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 18;
            this.button3.Text = "Editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtEditarDescricao
            // 
            this.txtEditarDescricao.Location = new System.Drawing.Point(311, 239);
            this.txtEditarDescricao.Name = "txtEditarDescricao";
            this.txtEditarDescricao.Size = new System.Drawing.Size(270, 23);
            this.txtEditarDescricao.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(311, 220);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Descrição";
            // 
            // txtEditarAno
            // 
            this.txtEditarAno.Location = new System.Drawing.Point(19, 239);
            this.txtEditarAno.Name = "txtEditarAno";
            this.txtEditarAno.Size = new System.Drawing.Size(275, 23);
            this.txtEditarAno.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ano";
            // 
            // txtEditarTitulo
            // 
            this.txtEditarTitulo.Location = new System.Drawing.Point(311, 176);
            this.txtEditarTitulo.Name = "txtEditarTitulo";
            this.txtEditarTitulo.Size = new System.Drawing.Size(270, 23);
            this.txtEditarTitulo.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Título";
            // 
            // txtEdiGenero
            // 
            this.txtEdiGenero.Location = new System.Drawing.Point(19, 176);
            this.txtEdiGenero.Name = "txtEdiGenero";
            this.txtEdiGenero.Size = new System.Drawing.Size(275, 23);
            this.txtEdiGenero.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Gênero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Selecione a série abaixo para editar";
            // 
            // listEdiSeriesTxt
            // 
            this.listEdiSeriesTxt.FormattingEnabled = true;
            this.listEdiSeriesTxt.ItemHeight = 15;
            this.listEdiSeriesTxt.Location = new System.Drawing.Point(19, 32);
            this.listEdiSeriesTxt.Name = "listEdiSeriesTxt";
            this.listEdiSeriesTxt.Size = new System.Drawing.Size(642, 109);
            this.listEdiSeriesTxt.TabIndex = 0;
            this.listEdiSeriesTxt.Click += new System.EventHandler(this.listSeriesTxt_Click);
            this.listEdiSeriesTxt.Enter += new System.EventHandler(this.listSeriesTxt_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.listDelSeriesTxt);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Apagar Série";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 15);
            this.label11.TabIndex = 2;
            this.label11.Text = "Selecione a série abaixo para apagar";
            // 
            // listDelSeriesTxt
            // 
            this.listDelSeriesTxt.FormattingEnabled = true;
            this.listDelSeriesTxt.ItemHeight = 15;
            this.listDelSeriesTxt.Location = new System.Drawing.Point(31, 39);
            this.listDelSeriesTxt.Name = "listDelSeriesTxt";
            this.listDelSeriesTxt.Size = new System.Drawing.Size(714, 139);
            this.listDelSeriesTxt.TabIndex = 1;
            this.listDelSeriesTxt.DoubleClick += new System.EventHandler(this.listDelSeriesTxt_DoubleClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.txtLista);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 337);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Listar Séries";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(28, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Listar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtLista
            // 
            this.txtLista.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLista.Location = new System.Drawing.Point(28, 42);
            this.txtLista.Multiline = true;
            this.txtLista.Name = "txtLista";
            this.txtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLista.Size = new System.Drawing.Size(719, 231);
            this.txtLista.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(709, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Cadastro de Séries";
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbQtdSerie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtInsDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtInsAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInsTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInsGenero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtEditarDescricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditarAno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEditarTitulo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEdiGenero;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listEdiSeriesTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox listDelSeriesTxt;
        private System.Windows.Forms.TextBox txtLista;
        private System.Windows.Forms.Button button4;
    }
}

