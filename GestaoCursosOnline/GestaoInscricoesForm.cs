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

public partial class GestaoInscricoesForm : Form
{
    SqlConnector sqlConnector = new SqlConnector();
    List<CursoModel> cursos;

    public GestaoInscricoesForm()
    {
        InitializeComponent();
        WireUpLists();
    }

    public void WireUpLists()
    {
        //lbAlunos.DataSource = null;
        //lbAlunos.DataSource = alunos;
        //lbAlunos.DisplayMember = "nome";

        cursos = sqlConnector.ListarCursos();
        lbCursos.DataSource = null;
        lbCursos.DataSource = cursos;
        lbCursos.DisplayMember = "nome";
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
            MessageBox.Show("Selecione um curso para editar", "Erro");
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
            MessageBox.Show("Selecione um curso para eliminar", "Erro");
        }
    }
}
