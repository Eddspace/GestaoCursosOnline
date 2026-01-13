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
    ConsultaInscricoesForm formConsulta;
    List<CursoModel> cursos;
    List<AlunoModel> alunos;

    public GestaoInscricoesForm(ConsultaInscricoesForm cif)
    {
        InitializeComponent();
        WireUpLists();
        formConsulta = cif;
    }

    /// <summary>
    /// Carrega os dados dos alunos e cursos existentes no SQL, depois coloca os resultados nas listas do GestaoInscricoesForm
    /// Ativa e desativa os botões de editar e remover alunos e cursos quando não existem alunos e cursos para remover e vise versa
    /// </summary>
    public void WireUpLists()
    {
        alunos = sqlConnector.ListarAlunos();
        lbAlunos.DataSource = null;
        lbAlunos.DataSource = alunos;
        lbAlunos.DisplayMember = "nome";

        cursos = sqlConnector.ListarCursos();
        lbCursos.DataSource = null;
        lbCursos.DataSource = cursos;
        lbCursos.DisplayMember = "nomeData";

        if (alunos.Count != 0)
        {
            btnEditarAluno.Enabled = true;
            btnRemoverAluno.Enabled = true;
        }
        else
        {
            btnEditarAluno.Enabled = false;
            btnRemoverAluno.Enabled = false;
        }

        if (cursos.Count != 0)
        {
            btnEditarCurso.Enabled = true;
            btnRemoverCurso.Enabled = true;
        }
        else
        {
            btnEditarCurso.Enabled = false;
            btnRemoverCurso.Enabled = false;
        }

    }

    private void btnCancelar_Click(object sender, EventArgs e) //A forma pretendida para voltar ao form previo, atualiza as listas do form consulta antes de fechar este
    {
        formConsulta.WireUpAluno();
        formConsulta.WireUpCursos();
        this.Close();
    }

    private void btnNovoCurso_Click(object sender, EventArgs e) //Inicia o form de criação e edição dos cursos
    {
        GestaoCursosForm gcf = new GestaoCursosForm(this);
        gcf.Show();
    }

    private void btnEditarCurso_Click(object sender, EventArgs e) //Inicia o form de criação e edição dos cursos
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
            if (sqlConnector.ListarAlunosPorCurso(cursoSelecionado).Count != 0) //se o curso atual tem inscrições de qualquer aluno
            {
                MessageBox.Show("Não é possivel remover um curso onde alunos já se encontram inscritos", "Erro");
            }
            else
            {
                sqlConnector.RemoverCurso(cursoSelecionado);
                WireUpLists();
            }
                
        }
        else
        {
            MessageBox.Show("Um curso selecionado é necessario para fazer o processo de remoção, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }
    }

    private void btnNovoAluno_Click(object sender, EventArgs e) //Inicia o form de criação e edição dos alunos
    {
        GestaoAlunosForm gaf = new GestaoAlunosForm(this);
        gaf.Show();
    }

    private void btnEditarAluno_Click(object sender, EventArgs e) //Inicia o form de criação e edição dos alunos
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
            if (sqlConnector.ListarCursosPorAluno(alunoSelecionado).Count != 0) //se o aluno atual tem qualquer inscrição em seu nome
            {
                MessageBox.Show("Não é possivel remover um aluno que se encontra inscrito num curso", "Erro");
            }
            else
            {
                sqlConnector.RemoverAluno(alunoSelecionado);
                WireUpLists();
            }  
        }
        else
        {
            MessageBox.Show("Um aluno selecionado é necessario para fazer o processo de remoção, por favor crie um primeiro ou selecione um da lista em baixo", "Erro");
        }
    }

    private void btnConcluirInscricao_Click(object sender, EventArgs e)
    {
        if (lbCursos.SelectedItem != null && lbAlunos.SelectedItem != null) //se temos ambos um aluno e um curso selecionados
        {
            CursoModel cursoSelecionado = (CursoModel)lbCursos.SelectedItem;
            AlunoModel alunoSelecionado = (AlunoModel)lbAlunos.SelectedItem;
            InscricaoModel inscricaoModel = new InscricaoModel(cursoSelecionado.IdCurso, alunoSelecionado.IdAluno, monthCalendar.SelectionRange.Start);
            List<InscricaoModel> inscricoesDoAluno = sqlConnector.ListarCursosPorAluno(alunoSelecionado); //uma lista com todos os cursos onde o aluno selecionado já está inscrito
            bool Repeat = false; //uma variavel boleana que nos vai indicar se a inscrição é repetida ou não

            foreach (var insc in inscricoesDoAluno) //por cada inscrição na lista de inscrições do aluno selecionado
            {
                if (insc.IdCurso == inscricaoModel.IdCurso) //se o curso onde o aluno se quer inscrevere for o mesmo
                {
                    Repeat = true; //então a inscrição é repetida
                }
            }

            if (Repeat) //se a inscrição for repetida devolve um erro
            {
                MessageBox.Show("O aluno já tem uma inscrição ativa para este curso", "Erro");
            }
            else //caso contrario fazemos a inscrição
            {
                sqlConnector.AssociarAlunoCurso(inscricaoModel);
                MessageBox.Show("Inscrição criada com sucesso");
            }
        }
        else
        {
            MessageBox.Show("Verifique que selecionou ambos um curso e um aluno para fazer a inscrição", "Erro");
        }
    }
}
