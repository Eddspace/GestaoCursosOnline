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
        if (alunos != null) //se já existirem alunos na dropbox durante a inicialização, caregamos tambem os elementos da lista de cursos
        {
            WireUpCursos();
        }
    }

    /// <summary>
    /// Função que faz a pesquisa ao sql pelos alunos existentes e depois atualiza os dados da dropbox dos alunos
    /// </summary>
    public void WireUpAluno()
    {
        alunos = sqlConnector.ListarAlunos();
        cbAlunos.DataSource = null;
        cbAlunos.DataSource = alunos;
        cbAlunos.DisplayMember = "nome";
    }

    /// <summary>
    /// Função que faz a pesquisa ao sql pelos cursos onde o aluno selecionado está inscrito e depois atualiza os dados da lista principal
    /// </summary>
    public void WireUpCursos()
    {
        if (cbAlunos.SelectedItem != null) //quando um aluno é selecionado na dropbox
        {
            AlunoModel alunoSelecionado = (AlunoModel)cbAlunos.SelectedItem; //o aluno especificado
            inscricoes = sqlConnector.ListarCursosPorAluno(alunoSelecionado); //todas as inscrições do aluno
            cursos = sqlConnector.ListarCursos(); //todos os cursos existentes

            List<CursoModel> cursosInscritos = new List<CursoModel>(); //criamos uma lista temporaria onde vamos depois guardamos os cursos onde o aluno esta inscrito
            lbCursosPorAluno.DataSource = null;

            foreach (var c in cursos) //por cada curso na lista total dos cursos
            {
                foreach (var i in inscricoes) //por cada incrição que o aluno tem
                {
                    if (c.IdCurso == i.IdCurso) //verificamos se a inscrição é deste curso em particular
                    {
                        cursosInscritos.Add(c); //adicionamos o curso a lista temporaria
                    }
                }
            }

            lbCursosPorAluno.DataSource = cursosInscritos; //listamos apenas os cursos onde o aluno esta inscrito (e não as inscrições em si)
            lbCursosPorAluno.DisplayMember = "nomeData";

            if (cursosInscritos.Count != 0) //se o aluno estiver inscrito em qualquer curso
            {
                btnRemoverInscricao.Enabled = true; //o botão de remover cursos fica premivel
            }
            else
            {
                btnRemoverInscricao.Enabled = false; //se não for esse o caso, desativamos o botão
            }
        }
        else
        {
            lbCursosPorAluno.DataSource = null; //caso não exista aluno selecionado, limpamos a lista de inscrições
        }

    }

    private void cbAlunos_SelectionChangeCommitted(object sender, EventArgs e) //quando o utilizador seleciona algum valor na dropbox
    {
        if (cbAlunos.SelectedItem != null)
        {
            WireUpCursos();
        }
    }

    private void btnNovaInscricao_Click(object sender, EventArgs e) //limpamos as listas deste form e abrimos o gestor de inscrições
    {
        cbAlunos.DataSource = null;
        lbCursosPorAluno.DataSource = null;
        GestaoInscricoesForm gif = new GestaoInscricoesForm(this);
        gif.Show(this);
    }

    private void btnRemoverInscricao_Click(object sender, EventArgs e)
    {
        if (lbCursosPorAluno.SelectedItem != null)
        {
            CursoModel cursoSelecionado = (CursoModel)lbCursosPorAluno.SelectedItem; //como a lista de inscrições demonstra cursos em vez de inscrições

            foreach (var i in inscricoes) //por cada inscrição do aluno selecionado
            {
                if (cursoSelecionado.IdCurso == i.IdCurso) //verificamos se a inscrição corresponde ao curso selecionado
                {
                    sqlConnector.RemoverAlunoCurso(i); //removemos todos os resultados, pois um aluno não pode estar inscrito no mesmo curso multiplas vezes
                }
            }

            WireUpCursos();

        }
        else
        {
            MessageBox.Show("Não é possivel remover uma reserva deste aluno pois não existem reservas", "Erro");
        }

    }

    private void cbAlunos_DropDown(object sender, EventArgs e) 
    {
        //no caso do utilizador fechar o gestor de inscrições não devidamente, para evitar erros, populamos a lista de alunos quando a dropbox é selecionada
        if (cbAlunos.SelectedItem == null)
        {
            WireUpAluno();
        }
    }
}
