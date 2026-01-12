using GestaoCursosOnline.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoCursosOnline;

public partial class GestaoInscricoesForm : Form
{
    SqlConnector sqlConnector = new SqlConnector();
    List<CursoModel> cursos;
    List<AlunoModel> alunos;

    public GestaoInscricoesForm()
    {
        InitializeComponent();
        WireUpLists();
    }

    public void WireUpLists()
    {
        alunos = sqlConnector.ListarAlunos();
        lbAlunos.DataSource = null;
        lbAlunos.DataSource = alunos;
        lbAlunos.DisplayMember = "nome";

        cursos = sqlConnector.ListarCursos();
        lbCursos.DataSource = null;
        lbCursos.DataSource = cursos;
        lbCursos.DisplayMember = "nome";

        if (alunos != null)
        {
            btnEditarAluno.Enabled = true;
            btnRemoverAluno.Enabled = true;
        }

        if (cursos != null)
        {
            btnEditarCurso.Enabled = true;
            btnRemoverCurso.Enabled = true;
        }


    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnNovoCurso_Click(object sender, EventArgs e)
    {
        GestaoCursosForm gcf = new GestaoCursosForm(this);
        gcf.Show();
    }

    private void btnEditarCurso_Click(object sender, EventArgs e)
    {
        if (lbCursos.SelectedItem != null)
        {
            CursoModel cursoSelecionado = (CursoModel)lbCursos.SelectedItem;

            GestaoCursosForm gcf = new GestaoCursosForm(cursoSelecionado, this);
            gcf.Show();

        }
        else
        {
            MessageBox.Show("Um curso selecionado é necessario para fazer o processo de edição, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }

    }

    private void btnRemoverCurso_Click(object sender, EventArgs e)
    {
        if (lbCursos.SelectedItem != null)
        {
            CursoModel cursoSelecionado = (CursoModel)lbCursos.SelectedItem;
            sqlConnector.RemoverCurso(cursoSelecionado);
            WireUpLists();
        }
        else
        {
            MessageBox.Show("Um curso selecionado é necessario para fazer o processo de remoção, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }
    }

    private void btnNovoAluno_Click(object sender, EventArgs e)
    {
        GestaoAlunosForm gaf = new GestaoAlunosForm(this);
        gaf.Show();
    }

    private void btnEditarAluno_Click(object sender, EventArgs e)
    {
        if (lbAlunos.SelectedItem != null)
        {
            AlunoModel alunoSelecionado = (AlunoModel)lbAlunos.SelectedItem;

            GestaoAlunosForm gaf = new GestaoAlunosForm(alunoSelecionado, this);
            gaf.Show();

        }
        else
        {
            MessageBox.Show("Um aluno selecionado é necessario para fazer o processo de edição, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }
    }

    private void btnRemoverAluno_Click(object sender, EventArgs e)
    {
        if (lbAlunos.SelectedItem != null)
        {
            AlunoModel alunoSelecionado = (AlunoModel)lbAlunos.SelectedItem;
            sqlConnector.RemoverAluno(alunoSelecionado);
            WireUpLists();
        }
        else
        {
            MessageBox.Show("Um aluno selecionado é necessario para fazer o processo de remoção, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }
    }
}
