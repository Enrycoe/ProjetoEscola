namespace ProjetoForms.Front.Alunos
{
    partial class FormEditarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditarAluno));
            this.brnExcluir = new System.Windows.Forms.Button();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.cbTurma = new System.Windows.Forms.ComboBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNomeCompleto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomeCompleto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTelefoneFixo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneResponsavel2 = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefoneResponsavel = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonePessoal = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlEndereço = new System.Windows.Forms.Panel();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbCidade = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.pnlEndereço.SuspendLayout();
            this.SuspendLayout();
            // 
            // brnExcluir
            // 
            this.brnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.brnExcluir.BackColor = System.Drawing.Color.Maroon;
            this.brnExcluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("brnExcluir.BackgroundImage")));
            this.brnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.brnExcluir.FlatAppearance.BorderSize = 0;
            this.brnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brnExcluir.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnExcluir.ForeColor = System.Drawing.Color.RosyBrown;
            this.brnExcluir.Location = new System.Drawing.Point(12, 535);
            this.brnExcluir.Name = "brnExcluir";
            this.brnExcluir.Size = new System.Drawing.Size(60, 60);
            this.brnExcluir.TabIndex = 45;
            this.brnExcluir.UseVisualStyleBackColor = false;
            this.brnExcluir.Click += new System.EventHandler(this.brnExcluir_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNascimento.Location = new System.Drawing.Point(178, 108);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(385, 26);
            this.dtNascimento.TabIndex = 44;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.BackgroundImage")));
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Green;
            this.btnCadastrar.Location = new System.Drawing.Point(535, 535);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(60, 60);
            this.btnCadastrar.TabIndex = 40;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // cbTurma
            // 
            this.cbTurma.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTurma.FormattingEnabled = true;
            this.cbTurma.Location = new System.Drawing.Point(412, 501);
            this.cbTurma.Name = "cbTurma";
            this.cbTurma.Size = new System.Drawing.Size(157, 28);
            this.cbTurma.TabIndex = 37;
            // 
            // txtRA
            // 
            this.txtRA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRA.Enabled = false;
            this.txtRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(78, 501);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(157, 26);
            this.txtRA.TabIndex = 36;
            // 
            // txtNomeCompleto
            // 
            this.txtNomeCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNomeCompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCompleto.Location = new System.Drawing.Point(178, 76);
            this.txtNomeCompleto.Name = "txtNomeCompleto";
            this.txtNomeCompleto.Size = new System.Drawing.Size(385, 26);
            this.txtNomeCompleto.TabIndex = 35;
            this.txtNomeCompleto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCompleto_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(349, 505);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 34;
            this.label5.Text = "Turma:";
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(38, 505);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(34, 18);
            this.lblEmail.TabIndex = 33;
            this.lblEmail.Text = "RA:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Data de Nascimento:";
            // 
            // lblNomeCompleto
            // 
            this.lblNomeCompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNomeCompleto.AutoSize = true;
            this.lblNomeCompleto.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCompleto.ForeColor = System.Drawing.Color.White;
            this.lblNomeCompleto.Location = new System.Drawing.Point(38, 76);
            this.lblNomeCompleto.Name = "lblNomeCompleto";
            this.lblNomeCompleto.Size = new System.Drawing.Size(112, 18);
            this.lblNomeCompleto.TabIndex = 31;
            this.lblNomeCompleto.Text = "Nome Completo:";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.txtTelefoneFixo);
            this.panel2.Controls.Add(this.txtTelefoneResponsavel2);
            this.panel2.Controls.Add(this.txtTelefoneResponsavel);
            this.panel2.Controls.Add(this.txtTelefonePessoal);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-27, 326);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 167);
            this.panel2.TabIndex = 42;
            // 
            // txtTelefoneFixo
            // 
            this.txtTelefoneFixo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneFixo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneFixo.Location = new System.Drawing.Point(196, 90);
            this.txtTelefoneFixo.Mask = "(00)0000-0000";
            this.txtTelefoneFixo.Name = "txtTelefoneFixo";
            this.txtTelefoneFixo.Size = new System.Drawing.Size(114, 26);
            this.txtTelefoneFixo.TabIndex = 17;
            // 
            // txtTelefoneResponsavel2
            // 
            this.txtTelefoneResponsavel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneResponsavel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneResponsavel2.Location = new System.Drawing.Point(474, 90);
            this.txtTelefoneResponsavel2.Mask = "(00)00000-0000";
            this.txtTelefoneResponsavel2.Name = "txtTelefoneResponsavel2";
            this.txtTelefoneResponsavel2.Size = new System.Drawing.Size(113, 26);
            this.txtTelefoneResponsavel2.TabIndex = 16;
            // 
            // txtTelefoneResponsavel
            // 
            this.txtTelefoneResponsavel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefoneResponsavel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefoneResponsavel.Location = new System.Drawing.Point(474, 33);
            this.txtTelefoneResponsavel.Mask = "(00)00000-0000";
            this.txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            this.txtTelefoneResponsavel.Size = new System.Drawing.Size(113, 26);
            this.txtTelefoneResponsavel.TabIndex = 15;
            // 
            // txtTelefonePessoal
            // 
            this.txtTelefonePessoal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefonePessoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonePessoal.Location = new System.Drawing.Point(196, 30);
            this.txtTelefonePessoal.Mask = "(00)00000-0000";
            this.txtTelefonePessoal.Name = "txtTelefonePessoal";
            this.txtTelefonePessoal.Size = new System.Drawing.Size(114, 26);
            this.txtTelefonePessoal.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(324, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 13;
            this.label7.Text = "Telefone Responsável: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(324, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefone Responsável: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Telefone Fixo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefone Pessoal: ";
            // 
            // pnlEndereço
            // 
            this.pnlEndereço.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlEndereço.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlEndereço.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlEndereço.BackgroundImage")));
            this.pnlEndereço.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEndereço.Controls.Add(this.txtNumeroCasa);
            this.pnlEndereço.Controls.Add(this.txtRua);
            this.pnlEndereço.Controls.Add(this.txtBairro);
            this.pnlEndereço.Controls.Add(this.lblNumero);
            this.pnlEndereço.Controls.Add(this.lblRua);
            this.pnlEndereço.Controls.Add(this.lblBairro);
            this.pnlEndereço.Controls.Add(this.lblCidade);
            this.pnlEndereço.Controls.Add(this.lblEstado);
            this.pnlEndereço.Controls.Add(this.cbCidade);
            this.pnlEndereço.Controls.Add(this.cbEstado);
            this.pnlEndereço.Location = new System.Drawing.Point(-14, 153);
            this.pnlEndereço.Name = "pnlEndereço";
            this.pnlEndereço.Size = new System.Drawing.Size(726, 167);
            this.pnlEndereço.TabIndex = 41;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumeroCasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(461, 94);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(86, 26);
            this.txtNumeroCasa.TabIndex = 9;
            this.txtNumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCasa_KeyPress);
            // 
            // txtRua
            // 
            this.txtRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.Location = new System.Drawing.Point(147, 94);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(233, 26);
            this.txtRua.TabIndex = 8;
            this.txtRua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRua_KeyPress);
            // 
            // txtBairro
            // 
            this.txtBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.Location = new System.Drawing.Point(147, 65);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(400, 26);
            this.txtBairro.TabIndex = 7;
            this.txtBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBairro_KeyPress);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(397, 97);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(62, 18);
            this.lblNumero.TabIndex = 6;
            this.lblNumero.Text = "Número:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRua.Location = new System.Drawing.Point(86, 97);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(38, 18);
            this.lblRua.TabIndex = 5;
            this.lblRua.Text = "Rua:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(86, 65);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(54, 18);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(363, 34);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(60, 18);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade: ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(87, 34);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 18);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado: ";
            // 
            // cbCidade
            // 
            this.cbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCidade.FormattingEnabled = true;
            this.cbCidade.Location = new System.Drawing.Point(426, 31);
            this.cbCidade.Name = "cbCidade";
            this.cbCidade.Size = new System.Drawing.Size(121, 24);
            this.cbCidade.TabIndex = 1;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Location = new System.Drawing.Point(147, 33);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 24);
            this.cbEstado.TabIndex = 0;
            this.cbEstado.TextChanged += new System.EventHandler(this.cbEstado_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(220)))));
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Red;
            this.btnCancelar.Location = new System.Drawing.Point(545, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(50, 50);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormEditarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(51)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(607, 607);
            this.Controls.Add(this.brnExcluir);
            this.Controls.Add(this.dtNascimento);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlEndereço);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cbTurma);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtNomeCompleto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNomeCompleto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditarAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edição de Aluno";
            this.Load += new System.EventHandler(this.FormEditarAluno_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormEditarAluno_MouseDown);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlEndereço.ResumeLayout(false);
            this.pnlEndereço.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button brnExcluir;
        private System.Windows.Forms.DateTimePicker dtNascimento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFixo;
        private System.Windows.Forms.MaskedTextBox txtTelefoneResponsavel2;
        private System.Windows.Forms.MaskedTextBox txtTelefoneResponsavel;
        private System.Windows.Forms.MaskedTextBox txtTelefonePessoal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlEndereço;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbCidade;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ComboBox cbTurma;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtNomeCompleto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomeCompleto;
        private System.Windows.Forms.Button btnCancelar;
    }
}