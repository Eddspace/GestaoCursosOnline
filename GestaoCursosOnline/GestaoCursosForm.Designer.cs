namespace GestaoCursosOnline
{
    partial class GestaoCursosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoCursosForm));
            gb3 = new GroupBox();
            nudCarga = new NumericUpDown();
            lbCarga = new Label();
            gb2 = new GroupBox();
            tbDesc = new TextBox();
            lbDesc = new Label();
            btnCancelar = new Button();
            btnConfirmar = new Button();
            gb1 = new GroupBox();
            tbNome = new TextBox();
            lbNome = new Label();
            gb4 = new GroupBox();
            dtpDataInicio = new DateTimePicker();
            lbData = new Label();
            gb3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCarga).BeginInit();
            gb2.SuspendLayout();
            gb1.SuspendLayout();
            gb4.SuspendLayout();
            SuspendLayout();
            // 
            // gb3
            // 
            gb3.Controls.Add(nudCarga);
            gb3.Controls.Add(lbCarga);
            gb3.Location = new Point(12, 168);
            gb3.Name = "gb3";
            gb3.Size = new Size(424, 72);
            gb3.TabIndex = 8;
            gb3.TabStop = false;
            // 
            // nudCarga
            // 
            nudCarga.Location = new Point(127, 30);
            nudCarga.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            nudCarga.Name = "nudCarga";
            nudCarga.Size = new Size(274, 25);
            nudCarga.TabIndex = 1;
            // 
            // lbCarga
            // 
            lbCarga.AutoSize = true;
            lbCarga.Location = new Point(19, 32);
            lbCarga.Name = "lbCarga";
            lbCarga.Size = new Size(101, 17);
            lbCarga.TabIndex = 0;
            lbCarga.Text = "Carga Horaria:";
            // 
            // gb2
            // 
            gb2.Controls.Add(tbDesc);
            gb2.Controls.Add(lbDesc);
            gb2.Location = new Point(12, 90);
            gb2.Name = "gb2";
            gb2.Size = new Size(424, 72);
            gb2.TabIndex = 9;
            gb2.TabStop = false;
            // 
            // tbDesc
            // 
            tbDesc.Location = new Point(100, 28);
            tbDesc.MaxLength = 45;
            tbDesc.Name = "tbDesc";
            tbDesc.Size = new Size(301, 25);
            tbDesc.TabIndex = 1;
            // 
            // lbDesc
            // 
            lbDesc.AutoSize = true;
            lbDesc.Location = new Point(19, 32);
            lbDesc.Name = "lbDesc";
            lbDesc.Size = new Size(75, 17);
            lbDesc.TabIndex = 0;
            lbDesc.Text = "Descrição:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(236, 331);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 64);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = Color.WhiteSmoke;
            btnConfirmar.Location = new Point(12, 331);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(200, 64);
            btnConfirmar.TabIndex = 10;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = false;
            // 
            // gb1
            // 
            gb1.Controls.Add(tbNome);
            gb1.Controls.Add(lbNome);
            gb1.Location = new Point(12, 12);
            gb1.Name = "gb1";
            gb1.Size = new Size(424, 72);
            gb1.TabIndex = 6;
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
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.Location = new Point(19, 32);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(52, 17);
            lbNome.TabIndex = 0;
            lbNome.Text = "Nome:";
            // 
            // gb4
            // 
            gb4.Controls.Add(dtpDataInicio);
            gb4.Controls.Add(lbData);
            gb4.Location = new Point(12, 246);
            gb4.Name = "gb4";
            gb4.Size = new Size(424, 72);
            gb4.TabIndex = 9;
            gb4.TabStop = false;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Location = new Point(127, 28);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.RightToLeft = RightToLeft.No;
            dtpDataInicio.ShowUpDown = true;
            dtpDataInicio.Size = new Size(274, 25);
            dtpDataInicio.TabIndex = 1;
            dtpDataInicio.Value = new DateTime(2026, 1, 7, 0, 0, 0, 0);
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(19, 32);
            lbData.Name = "lbData";
            lbData.Size = new Size(102, 17);
            lbData.TabIndex = 0;
            lbData.Text = "Data de Inicio:";
            // 
            // GestaoCursosForm
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(449, 406);
            Controls.Add(gb4);
            Controls.Add(gb3);
            Controls.Add(gb2);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(gb1);
            Font = new Font("Calisto MT", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "GestaoCursosForm";
            Text = "Gestor de Cursos";
            gb3.ResumeLayout(false);
            gb3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCarga).EndInit();
            gb2.ResumeLayout(false);
            gb2.PerformLayout();
            gb1.ResumeLayout(false);
            gb1.PerformLayout();
            gb4.ResumeLayout(false);
            gb4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox gb3;
        private Label lbCarga;
        private GroupBox gb2;
        private TextBox tbDesc;
        private Label lbDesc;
        private Button btnCancelar;
        private Button btnConfirmar;
        private GroupBox gb1;
        private TextBox tbNome;
        private Label lbNome;
        private GroupBox gb4;
        private DateTimePicker dtpDataInicio;
        private Label lbData;
        private NumericUpDown nudCarga;
    }
}