namespace CadastroUsuarios
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
            txtRM = new TextBox();
            lblRM = new Label();
            lblCPF = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            mskCPF = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            lbldatadenascimento = new Label();
            lblsexo = new Label();
            lblNaturalidade = new Label();
            comboBox2 = new ComboBox();
            btnExibir = new Button();
            btnSair = new Button();
            btnLimpar = new Button();
            btnBlocodenotas = new Button();
            button2 = new Button();
            btnCalculadora = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // txtRM
            // 
            txtRM.Location = new Point(50, 55);
            txtRM.Margin = new Padding(4, 5, 4, 5);
            txtRM.Name = "txtRM";
            txtRM.Size = new Size(141, 31);
            txtRM.TabIndex = 0;
            // 
            // lblRM
            // 
            lblRM.AutoSize = true;
            lblRM.Location = new Point(50, 25);
            lblRM.Margin = new Padding(4, 0, 4, 0);
            lblRM.Name = "lblRM";
            lblRM.Size = new Size(39, 25);
            lblRM.TabIndex = 1;
            lblRM.Text = "RM";
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.Location = new Point(201, 25);
            lblCPF.Margin = new Padding(4, 0, 4, 0);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(42, 25);
            lblCPF.TabIndex = 3;
            lblCPF.Text = "CPF";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(376, 25);
            lblNome.Margin = new Padding(4, 0, 4, 0);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(61, 25);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(376, 55);
            txtNome.Margin = new Padding(4, 5, 4, 5);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(323, 31);
            txtNome.TabIndex = 4;
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(201, 55);
            mskCPF.Margin = new Padding(4, 5, 4, 5);
            mskCPF.Mask = "###.###.###-##";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(141, 31);
            mskCPF.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(50, 137);
            dateTimePicker1.Margin = new Padding(4, 5, 4, 5);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(284, 31);
            dateTimePicker1.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Feminino", "Masculino" });
            comboBox1.Location = new Point(376, 137);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 33);
            comboBox1.TabIndex = 8;
            // 
            // lbldatadenascimento
            // 
            lbldatadenascimento.AutoSize = true;
            lbldatadenascimento.Location = new Point(50, 107);
            lbldatadenascimento.Margin = new Padding(4, 0, 4, 0);
            lbldatadenascimento.Name = "lbldatadenascimento";
            lbldatadenascimento.Size = new Size(173, 25);
            lbldatadenascimento.TabIndex = 9;
            lbldatadenascimento.Text = "Data de Nascimento";
            // 
            // lblsexo
            // 
            lblsexo.AutoSize = true;
            lblsexo.Location = new Point(376, 107);
            lblsexo.Margin = new Padding(4, 0, 4, 0);
            lblsexo.Name = "lblsexo";
            lblsexo.Size = new Size(50, 25);
            lblsexo.TabIndex = 10;
            lblsexo.Text = "Sexo";
            // 
            // lblNaturalidade
            // 
            lblNaturalidade.AutoSize = true;
            lblNaturalidade.Location = new Point(555, 109);
            lblNaturalidade.Margin = new Padding(4, 0, 4, 0);
            lblNaturalidade.Name = "lblNaturalidade";
            lblNaturalidade.Size = new Size(113, 25);
            lblNaturalidade.TabIndex = 12;
            lblNaturalidade.Text = "Naturalidade";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Jaboticabal-SP", "Guariba-SP", "Matão-SP", "Monte alto-SP", "Taquarintiga-SP" });
            comboBox2.Location = new Point(555, 139);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(171, 33);
            comboBox2.TabIndex = 11;
            // 
            // btnExibir
            // 
            btnExibir.Location = new Point(59, 200);
            btnExibir.Name = "btnExibir";
            btnExibir.Size = new Size(112, 46);
            btnExibir.TabIndex = 13;
            btnExibir.Text = "Exibir";
            btnExibir.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(314, 200);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(112, 46);
            btnSair.TabIndex = 14;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(177, 200);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(112, 46);
            btnLimpar.TabIndex = 15;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnBlocodenotas
            // 
            btnBlocodenotas.Location = new Point(177, 337);
            btnBlocodenotas.Name = "btnBlocodenotas";
            btnBlocodenotas.Size = new Size(142, 50);
            btnBlocodenotas.TabIndex = 18;
            btnBlocodenotas.Text = "Bloco de notas";
            btnBlocodenotas.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(314, 337);
            button2.Name = "button2";
            button2.Size = new Size(123, 60);
            button2.TabIndex = 17;
            button2.Text = "Visual Studio Code";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnCalculadora
            // 
            btnCalculadora.Location = new Point(59, 337);
            btnCalculadora.Name = "btnCalculadora";
            btnCalculadora.Size = new Size(112, 50);
            btnCalculadora.TabIndex = 16;
            btnCalculadora.Text = "Calculadora";
            btnCalculadora.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(177, 421);
            button4.Name = "button4";
            button4.Size = new Size(131, 59);
            button4.TabIndex = 21;
            button4.Text = "Informações do sistema";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(314, 421);
            button5.Name = "button5";
            button5.Size = new Size(123, 59);
            button5.TabIndex = 20;
            button5.Text = "Informações do usuário";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(50, 421);
            button6.Name = "button6";
            button6.Size = new Size(121, 59);
            button6.TabIndex = 19;
            button6.Text = "Painel de Controle";
            button6.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(466, 200);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(290, 304);
            listBox1.TabIndex = 22;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(listBox1);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(btnBlocodenotas);
            Controls.Add(button2);
            Controls.Add(btnCalculadora);
            Controls.Add(btnLimpar);
            Controls.Add(btnSair);
            Controls.Add(btnExibir);
            Controls.Add(lblNaturalidade);
            Controls.Add(comboBox2);
            Controls.Add(lblsexo);
            Controls.Add(lbldatadenascimento);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(mskCPF);
            Controls.Add(lblNome);
            Controls.Add(txtNome);
            Controls.Add(lblCPF);
            Controls.Add(lblRM);
            Controls.Add(txtRM);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRM;
        private Label lblRM;
        private Label lblCPF;
        private Label lblNome;
        private TextBox txtNome;
        private MaskedTextBox mskCPF;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label lbldatadenascimento;
        private Label lblsexo;
        private Label lblNaturalidade;
        private ComboBox comboBox2;
        private Button btnExibir;
        private Button btnSair;
        private Button btnLimpar;
        private Button btnBlocodenotas;
        private Button button2;
        private Button btnCalculadora;
        private Button button4;
        private Button button5;
        private Button button6;
        private ListBox listBox1;
    }
}
