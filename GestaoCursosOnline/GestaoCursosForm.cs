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
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestaoCursosOnline;

public partial class GestaoCursosForm : Form
{
    bool NovoCurso;
    CursoModel cursoAnterior;
    SqlConnector connector;

    public GestaoCursosForm()
    {
        InitializeComponent();

        dtpDataInicio.CustomFormat = "dd/MM/yyyy";
        NovoCurso = true; //define que estamos a criar um novo curso

        connector = new SqlConnector();
    }

    public GestaoCursosForm(CursoModel cursoSelecionado)
    {
        InitializeComponent();

        dtpDataInicio.CustomFormat = "dd/MM/yyyy";
        NovoCurso = false; //define que estamos a editar um curso
        cursoAnterior = cursoSelecionado;

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
                this.Close();
            }
            else
            {
                MessageBox.Show("Este curso tem informação invalida, por favor verifique os campos inseridos", "Erro, Informação invalida");
            }
        }

        if (!NovoCurso) //ou seja quando estamos a editar um curso
        {
            if (ValidarValores())
            {
                CursoModel model = new CursoModel(cursoAnterior.IdCurso, tbNome.Text, tbDesc.Text, Convert.ToInt32(nudCarga.Value), dtpDataInicio.Value);
                connector.AtualizarCurso(model);
                this.Close();
            }
            else
            {
                MessageBox.Show("Este curso tem informação invalida, por favor verifique os campos inseridos", "Erro, Informação invalida");
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
        }

        //validar Descrição
        else if (tbDesc.Text == string.Empty)
        {
            valido = false;
        }

        //validar CargaHoraria
        else if (nudCarga.Value == null || nudCarga.Value <= 0)
        {
            valido = false;
        }

        //validar DataInicio
        else if (dtpDataInicio.Value == null)
        {
            valido = false;
        }

        return valido;
    }
}
