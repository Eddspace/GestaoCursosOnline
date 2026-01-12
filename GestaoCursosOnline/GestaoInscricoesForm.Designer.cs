namespace GestaoCursosOnline
{
    partial class GestaoInscricoesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestaoInscricoesForm));
            gbAlunos = new GroupBox();
            btnRemoverAluno = new Button();
            btnEditarAluno = new Button();
            btnNovoAluno = new Button();
            lbAlunos = new ListBox();
            gbCursos = new GroupBox();
            btnRemoverCurso = new Button();
            lbCursos = new ListBox();
            btnEditarCurso = new Button();
            btnNovoCurso = new Button();
            monthCalendar = new MonthCalendar();
            btnCancelar = new Button();
            gbInscricao = new GroupBox();
            btnConcluirInscricao = new Button();
            gbAlunos.SuspendLayout();
            gbCursos.SuspendLayout();
            gbInscricao.SuspendLayout();
            SuspendLayout();
            // 
            // gbAlunos
            // 
            gbAlunos.Controls.Add(btnRemoverAluno);
            gbAlunos.Controls.Add(btnEditarAluno);
            gbAlunos.Controls.Add(btnNovoAluno);
            gbAlunos.Controls.Add(lbAlunos);
            gbAlunos.Location = new Point(12, 12);
            gbAlunos.Name = "gbAlunos";
            gbAlunos.Size = new Size(403, 380);
            gbAlunos.TabIndex = 0;
            gbAlunos.TabStop = false;
            gbAlunos.Text = "Lista de Alunos";
            // 
            // btnRemoverAluno
            // 
            btnRemoverAluno.BackColor = Color.WhiteSmoke;
            btnRemoverAluno.Enabled = false;
            btnRemoverAluno.Location = new Point(265, 24);
            btnRemoverAluno.Name = "btnRemoverAluno";
            btnRemoverAluno.Size = new Size(113, 50);
            btnRemoverAluno.TabIndex = 3;
            btnRemoverAluno.Text = "Remover\r\nAluno";
            btnRemoverAluno.UseVisualStyleBackColor = false;
            btnRemoverAluno.Click += btnRemoverAluno_Click;
            // 
            // btnEditarAluno
            // 
            btnEditarAluno.BackColor = Color.WhiteSmoke;
            btnEditarAluno.Enabled = false;
            btnEditarAluno.Location = new Point(144, 24);
            btnEditarAluno.Name = "btnEditarAluno";
            btnEditarAluno.Size = new Size(113, 50);
            btnEditarAluno.TabIndex = 2;
            btnEditarAluno.Text = "Editar\r\nAluno";
            btnEditarAluno.UseVisualStyleBackColor = false;
            btnEditarAluno.Click += btnEditarAluno_Click;
            // 
            // btnNovoAluno
            // 
            btnNovoAluno.BackColor = Color.WhiteSmoke;
            btnNovoAluno.Location = new Point(23, 24);
            btnNovoAluno.Name = "btnNovoAluno";
            btnNovoAluno.Size = new Size(113, 50);
            btnNovoAluno.TabIndex = 1;
            btnNovoAluno.Text = "Novo\r\nAluno";
            btnNovoAluno.UseVisualStyleBackColor = false;
            btnNovoAluno.Click += btnNovoAluno_Click;
            // 
            // lbAlunos
            // 
            lbAlunos.FormattingEnabled = true;
            lbAlunos.ItemHeight = 17;
            lbAlunos.Location = new Point(23, 84);
            lbAlunos.Name = "lbAlunos";
            lbAlunos.Size = new Size(355, 276);
            lbAlunos.TabIndex = 0;
            // 
            // gbCursos
            // 
            gbCursos.Controls.Add(btnRemoverCurso);
            gbCursos.Controls.Add(lbCursos);
            gbCursos.Controls.Add(btnEditarCurso);
            gbCursos.Controls.Add(btnNovoCurso);
            gbCursos.Location = new Point(427, 12);
            gbCursos.Name = "gbCursos";
            gbCursos.Size = new Size(403, 380);
            gbCursos.TabIndex = 1;
            gbCursos.TabStop = false;
            gbCursos.Text = "Lista de Cursos";
            // 
            // btnRemoverCurso
            // 
            btnRemoverCurso.BackColor = Color.WhiteSmoke;
            btnRemoverCurso.Enabled = false;
            btnRemoverCurso.Location = new Point(266, 24);
            btnRemoverCurso.Name = "btnRemoverCurso";
            btnRemoverCurso.Size = new Size(113, 50);
            btnRemoverCurso.TabIndex = 6;
            btnRemoverCurso.Text = "Remover\r\nCurso";
            btnRemoverCurso.UseVisualStyleBackColor = false;
            btnRemoverCurso.Click += btnRemoverCurso_Click;
            // 
            // lbCursos
            // 
            lbCursos.FormattingEnabled = true;
            lbCursos.ItemHeight = 17;
            lbCursos.Location = new Point(24, 84);
            lbCursos.Name = "lbCursos";
            lbCursos.Size = new Size(355, 276);
            lbCursos.TabIndex = 1;
            // 
            // btnEditarCurso
            // 
            btnEditarCurso.BackColor = Color.WhiteSmoke;
            btnEditarCurso.Enabled = false;
            btnEditarCurso.Location = new Point(145, 24);
            btnEditarCurso.Name = "btnEditarCurso";
            btnEditarCurso.Size = new Size(113, 50);
            btnEditarCurso.TabIndex = 5;
            btnEditarCurso.Text = "Editar\r\nCurso";
            btnEditarCurso.UseVisualStyleBackColor = false;
            btnEditarCurso.Click += btnEditarCurso_Click;
            // 
            // btnNovoCurso
            // 
            btnNovoCurso.BackColor = Color.WhiteSmoke;
            btnNovoCurso.Location = new Point(24, 24);
            btnNovoCurso.Name = "btnNovoCurso";
            btnNovoCurso.Size = new Size(113, 50);
            btnNovoCurso.TabIndex = 4;
            btnNovoCurso.Text = "Novo\r\nCurso";
            btnNovoCurso.UseVisualStyleBackColor = false;
            btnNovoCurso.Click += btnNovoCurso_Click;
            // 
            // monthCalendar
            // 
            monthCalendar.CalendarDimensions = new Size(1, 2);
            monthCalendar.Location = new Point(25, 18);
            monthCalendar.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            monthCalendar.MaxSelectionCount = 1;
            monthCalendar.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.ShowToday = false;
            monthCalendar.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(140, 320);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 50);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar\r\nIncrição";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // gbInscricao
            // 
            gbInscricao.Controls.Add(btnConcluirInscricao);
            gbInscricao.Controls.Add(btnCancelar);
            gbInscricao.Controls.Add(monthCalendar);
            gbInscricao.Location = new Point(842, 12);
            gbInscricao.Name = "gbInscricao";
            gbInscricao.Size = new Size(284, 380);
            gbInscricao.TabIndex = 10;
            gbInscricao.TabStop = false;
            gbInscricao.Text = "Data da Inscrição";
            // 
            // btnConcluirInscricao
            // 
            btnConcluirInscricao.BackColor = Color.WhiteSmoke;
            btnConcluirInscricao.Location = new Point(25, 320);
            btnConcluirInscricao.Name = "btnConcluirInscricao";
            btnConcluirInscricao.Size = new Size(113, 50);
            btnConcluirInscricao.TabIndex = 10;
            btnConcluirInscricao.Text = "Concluir\r\nInscrição";
            btnConcluirInscricao.UseVisualStyleBackColor = false;
            btnConcluirInscricao.Click += btnConcluirInscricao_Click;
            // 
            // GestaoInscricoesForm
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1138, 404);
            Controls.Add(gbInscricao);
            Controls.Add(gbCursos);
            Controls.Add(gbAlunos);
            Font = new Font("Calisto MT", 11.25F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "GestaoInscricoesForm";
            Text = "Gestor de Inscrições";
            gbAlunos.ResumeLayout(false);
            gbCursos.ResumeLayout(false);
            gbInscricao.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbAlunos;
        private ListBox lbAlunos;
        private GroupBox gbCursos;
        private ListBox lbCursos;
        private Button btnEditarAluno;
        private Button btnNovoAluno;
        private Button btnRemoverAluno;
        private MonthCalendar monthCalendar;
        private Button btnRemoverCurso;
        private Button btnEditarCurso;
        private Button btnNovoCurso;
        private Button btnCancelar;
        private GroupBox gbInscricao;
        private Button btnConcluirInscricao;
    }
}