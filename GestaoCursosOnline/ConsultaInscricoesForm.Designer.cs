namespace GestaoCursosOnline
{
    partial class ConsultaInscricoesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaInscricoesForm));
            cbAlunos = new ComboBox();
            lbCursosPorAluno = new ListBox();
            btnNovaInscricao = new Button();
            btnRemoverInscricao = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // cbAlunos
            // 
            cbAlunos.FormattingEnabled = true;
            cbAlunos.Location = new Point(12, 29);
            cbAlunos.Name = "cbAlunos";
            cbAlunos.Size = new Size(529, 25);
            cbAlunos.TabIndex = 0;
            cbAlunos.DropDown += cbAlunos_DropDown;
            cbAlunos.SelectionChangeCommitted += cbAlunos_SelectionChangeCommitted;
            // 
            // lbCursosPorAluno
            // 
            lbCursosPorAluno.FormattingEnabled = true;
            lbCursosPorAluno.ItemHeight = 17;
            lbCursosPorAluno.Location = new Point(12, 97);
            lbCursosPorAluno.Name = "lbCursosPorAluno";
            lbCursosPorAluno.Size = new Size(529, 310);
            lbCursosPorAluno.TabIndex = 1;
            // 
            // btnNovaInscricao
            // 
            btnNovaInscricao.BackColor = Color.WhiteSmoke;
            btnNovaInscricao.Location = new Point(12, 419);
            btnNovaInscricao.Name = "btnNovaInscricao";
            btnNovaInscricao.Size = new Size(159, 52);
            btnNovaInscricao.TabIndex = 2;
            btnNovaInscricao.Text = "Gerir\r\nInscrições";
            btnNovaInscricao.UseVisualStyleBackColor = false;
            btnNovaInscricao.Click += btnNovaInscricao_Click;
            // 
            // btnRemoverInscricao
            // 
            btnRemoverInscricao.BackColor = Color.WhiteSmoke;
            btnRemoverInscricao.Enabled = false;
            btnRemoverInscricao.Location = new Point(382, 419);
            btnRemoverInscricao.Name = "btnRemoverInscricao";
            btnRemoverInscricao.Size = new Size(159, 52);
            btnRemoverInscricao.TabIndex = 3;
            btnRemoverInscricao.Text = "Remover\r\nInscrição";
            btnRemoverInscricao.UseVisualStyleBackColor = false;
            btnRemoverInscricao.Click += btnRemoverInscricao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 4;
            label1.Text = "Aluno a Perquisar:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(213, 17);
            label2.TabIndex = 5;
            label2.Text = "Inscrições do Aluno selecionado";
            // 
            // ConsultaInscricoesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(555, 481);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRemoverInscricao);
            Controls.Add(btnNovaInscricao);
            Controls.Add(lbCursosPorAluno);
            Controls.Add(cbAlunos);
            Font = new Font("Calisto MT", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "ConsultaInscricoesForm";
            Text = "Consulta de Inscrições";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbAlunos;
        private ListBox lbCursosPorAluno;
        private Button btnNovaInscricao;
        private Button btnRemoverInscricao;
        private Label label1;
        private Label label2;
    }
}