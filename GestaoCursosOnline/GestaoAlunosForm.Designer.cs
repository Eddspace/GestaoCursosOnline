namespace GestaoCursosOnline
{
    partial class GestaoAlunosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoAlunosForm));
            gb1 = new GroupBox();
            tbNome = new TextBox();
            lblNome = new Label();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            gb2 = new GroupBox();
            tbEmail = new TextBox();
            lblEmail = new Label();
            gb3 = new GroupBox();
            dtpDataNasc = new DateTimePicker();
            lblDataNasc = new Label();
            gb4 = new GroupBox();
            tbTele = new TextBox();
            lblTele = new Label();
            gb1.SuspendLayout();
            gb2.SuspendLayout();
            gb3.SuspendLayout();
            gb4.SuspendLayout();
            SuspendLayout();
            // 
            // gb1
            // 
            gb1.Controls.Add(tbNome);
            gb1.Controls.Add(lblNome);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(424, 72);
            gb1.TabIndex = 3;
            gb1.TabStop = false;
            // 
            // tbNome
            // 
            tbNome.Location = new Point(77, 28);
            tbNome.MaxLength = 45;
            tbNome.Name = "tbNome";
            tbNome.Size = new Size(324, 25);
            tbNome.TabIndex = 1;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(19, 32);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(52, 17);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.WhiteSmoke;
            btnConfirmar.Location = new Point(12, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(200, 64);
            btnConfirmar.TabIndex = 4;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(236, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 64);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // gb2
            // 
            gb2.Controls.Add(tbEmail);
            gb2.Controls.Add(lblEmail);
            gb2.Location = new Point(12, 90);
            gb2.Name = "gb2";
            gb2.Size = new Size(424, 72);
            gb2.TabIndex = 4;
            gb2.TabStop = false;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(77, 28);
            tbEmail.MaxLength = 45;
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(324, 25);
            tbEmail.TabIndex = 1;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(19, 32);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 17);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email:";
            // 
            // gb3
            // 
            gb3.Controls.Add(dtpDataNasc);
            gb3.Controls.Add(lblDataNasc);
            gb3.Location = new Point(12, 168);
            gb3.Name = "gb3";
            gb3.Size = new Size(424, 72);
            gb3.TabIndex = 4;
            gb3.TabStop = false;
            // 
            // dtpDataNasc
            // 
            dtpDataNasc.Location = new Point(168, 28);
            dtpDataNasc.Name = "dtpDataNasc";
            dtpDataNasc.ShowUpDown = true;
            dtpDataNasc.Size = new Size(233, 25);
            dtpDataNasc.TabIndex = 1;
            dtpDataNasc.Value = new DateTime(2026, 1, 7, 0, 0, 0, 0);
            // 
            // lblDataNasc
            // 
            lblDataNasc.AutoSize = true;
            lblDataNasc.Location = new Point(19, 32);
            lblDataNasc.Name = "lblDataNasc";
            lblDataNasc.Size = new Size(143, 17);
            lblDataNasc.TabIndex = 0;
            lblDataNasc.Text = "Data de Nascimento:";
            // 
            // gb4
            // 
            gb4.Controls.Add(tbTele);
            gb4.Controls.Add(lblTele);
            gb4.Location = new Point(12, 246);
            gb4.Name = "gb4";
            gb4.Size = new Size(424, 72);
            gb4.TabIndex = 4;
            gb4.TabStop = false;
            // 
            // tbTele
            // 
            tbTele.Location = new Point(93, 28);
            tbTele.MaxLength = 9;
            tbTele.Name = "tbTele";
            tbTele.Size = new Size(308, 25);
            tbTele.TabIndex = 1;
            // 
            // lblTele
            // 
            lblTele.AutoSize = true;
            lblTele.Location = new Point(19, 32);
            lblTele.Name = "lblTele";
            lblTele.Size = new Size(68, 17);
            lblTele.TabIndex = 0;
            lblTele.Text = "Telefone:";
            // 
            // GestaoAlunosForm
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(448, 407);
            Controls.Add(gb4);
            Controls.Add(gb3);
            Controls.Add(gb2);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(gb1);
            Font = new Font("Calisto MT", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "GestaoAlunosForm";
            Text = "Gestor de Alunos";
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            gb3.ResumeLayout(false);
            gb3.PerformLayout();
            gb4.ResumeLayout(false);
            gb4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gb1;
        private Button btnConfirmar;
        private Button btnCancelar;
        private TextBox tbNome;
        private Label lblNome;
        private GroupBox gb2;
        private TextBox tbEmail;
        private Label lblEmail;
        private GroupBox gb3;
        private Label lblDataNasc;
        private GroupBox gb4;
        private TextBox tbTele;
        private Label lblTele;
        private DateTimePicker dtpDataNasc;
    }
}