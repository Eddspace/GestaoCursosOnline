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

    //TODO - WIREUP do outro lado?!?
    public GestaoInscricoesForm()
    {
        InitializeComponent();
        cursos = sqlConnector.ListarCursos();
        WireUpLists();
    }

    public void WireUpLists()
    {

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
        GestaoCursosForm gcf = new GestaoCursosForm();
        gcf.Show();
    }

    private void btnEditarCurso_Click(object sender, EventArgs e)
    {
        CursoModel cursoSelecionado = (CursoModel)lbCursos.SelectedItem;

        GestaoCursosForm gcf = new GestaoCursosForm(cursoSelecionado);
        gcf.Show();
    }


}
