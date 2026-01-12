using GestaoCursosOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCursosOnline;

public partial class ConsultaInscricoesForm : Form
{
    SqlConnector sqlConnector = new SqlConnector();
    List<AlunoModel> alunos;
    List<InscricaoModel> inscricoes;
    List<CursoModel> cursos;

    public ConsultaInscricoesForm()
    {
        InitializeComponent();
        WireUpAluno();
        if (alunos != null)
        {
            WireUpCursos();
        }
    }

    public void WireUpAluno()
    {
        //TODO - WireUpAlunos when returning to this form from GestaoInscriçoes
        alunos = sqlConnector.ListarAlunos();
        cbAlunos.DataSource = null;
        cbAlunos.DataSource = alunos;
        cbAlunos.DisplayMember = "nome";
    }

    public void WireUpCursos()
    {
        AlunoModel alunoSelecionado = (AlunoModel)cbAlunos.SelectedItem;
        inscricoes = sqlConnector.ListarCursosPorAluno(alunoSelecionado);
        cursos = sqlConnector.ListarCursos();

        List<CursoModel> cursosInscritos = new List<CursoModel>();
        lbCursosPorAluno.DataSource = null;

        foreach (var c in cursos)
        {
            foreach (var i in inscricoes)
            {
                if (c.IdCurso == i.IdCurso)
                {
                    cursosInscritos.Add(c);
                }
            }
        }

        lbCursosPorAluno.DataSource = cursosInscritos;
        lbCursosPorAluno.DisplayMember = "nomeData";

    }

    private void cbAlunos_SelectionChangeCommitted(object sender, EventArgs e)
    {
        if (cbAlunos.SelectedItem != null)
        {
            WireUpCursos();
        }
    }

    private void btnNovaInscricao_Click(object sender, EventArgs e)
    {
        GestaoInscricoesForm gif = new GestaoInscricoesForm();
        gif.Show();
    }

    private void btnRemoverInscricao_Click(object sender, EventArgs e)
    {
        if (lbCursosPorAluno.SelectedItem != null)
        {
            CursoModel cursoSelecionado = (CursoModel)lbCursosPorAluno.SelectedItem;

            foreach (var i in inscricoes)
            {
                if (cursoSelecionado.IdCurso == i.IdCurso)
                {
                    sqlConnector.RemoverAlunoCurso(i);
                }
            }

            WireUpCursos();

        }

    }

    

    
}
