using GestaoCursosOnline.Models;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoCursosOnline;

public partial class GestaoCursosForm : Form
{
    bool NovoCurso;
    CursoModel cursoAnterior;
    GestaoInscricoesForm formAnterior;
    SqlConnector connector;

    public GestaoCursosForm(GestaoInscricoesForm gIF)
    {
        InitializeComponent();

        dtpDataInicio.CustomFormat = "dd/MM/yyyy";
        NovoCurso = true; //define que estamos a criar um novo curso

        connector = new SqlConnector();
        formAnterior = gIF;
    }

    public GestaoCursosForm(CursoModel cursoSelecionado, GestaoInscricoesForm gIF)
    {
        InitializeComponent();

        dtpDataInicio.CustomFormat = "dd/MM/yyyy";
        NovoCurso = false; //define que estamos a editar um curso
        cursoAnterior = cursoSelecionado;
        formAnterior = gIF;

        connector = new SqlConnector();

        tbNome.Text = cursoAnterior.Nome;
        tbDesc.Text = cursoAnterior.Descricao;
        nudCarga.Value = cursoAnterior.CargaHoraria;
        dtpDataInicio.Value = cursoAnterior.DataInicio;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
        if (NovoCurso) //quando estamos a criar um novo curso
        {
            if (ValidarValores())
            {
                CursoModel model = new CursoModel(tbNome.Text, tbDesc.Text, Convert.ToInt32(nudCarga.Value), dtpDataInicio.Value);
                connector.AdicionarCurso(model);
                formAnterior.WireUpLists();
                this.Close();
            }
        }
        else //quando estamos a editar um curso
        {
            if (ValidarValores())
            {
                CursoModel model = new CursoModel(cursoAnterior.IdCurso, tbNome.Text, tbDesc.Text, Convert.ToInt32(nudCarga.Value), dtpDataInicio.Value);
                connector.AtualizarCurso(model);
                formAnterior.WireUpLists();
                this.Close();
            }
        }
    }

    private bool ValidarValores()
    {
        bool valido = true;

        //validar Nome
        if (tbNome.Text == string.Empty)
        {
            valido = false;
            MessageBox.Show("O nome deste curso é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Descrição
        else if (tbDesc.Text == string.Empty)
        {
            valido = false;
            MessageBox.Show("O descrição deste curso é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar CargaHoraria
        else if (nudCarga.Value <= 0)
        {
            valido = false;
            MessageBox.Show("A carga horaria deste curso é invalida, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar DataInicio
        else if (dtpDataInicio.Value == null)
        {
            valido = false;
            MessageBox.Show("A data de inicio deste curso é invalida, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        return valido;
    }
}
