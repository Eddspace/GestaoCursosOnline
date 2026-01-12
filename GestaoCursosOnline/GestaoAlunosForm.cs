using GestaoCursosOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoCursosOnline;

public partial class GestaoAlunosForm : Form
{

    bool NovoAluno;
    AlunoModel alunoAnterior;
    GestaoInscricoesForm formAnterior;
    SqlConnector connector;

    public GestaoAlunosForm(GestaoInscricoesForm gIF)
    {
        InitializeComponent();

        dtpDataNasc.CustomFormat = "dd/MM/yyyy";
        NovoAluno = true; //define que estamos a criar um novo aluno

        connector = new SqlConnector();
        formAnterior = gIF;

    }

    public GestaoAlunosForm(AlunoModel alunoSelecionado, GestaoInscricoesForm gIF)
    {
        InitializeComponent();

        dtpDataNasc.CustomFormat = "dd/MM/yyyy";
        NovoAluno = false; //define que estamos a editar um aluno
        alunoAnterior = alunoSelecionado;
        connector = new SqlConnector();
        formAnterior = gIF;

        tbNome.Text = alunoAnterior.Nome;
        tbEmail.Text = alunoAnterior.Email;
        dtpDataNasc.Value = alunoAnterior.DataNascimento;
        tbTele.Text = alunoAnterior.Telefone;
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnConfirmar_Click(object sender, EventArgs e)
    {
        if (NovoAluno) //quando estamos a criar um novo aluno
        {
            if (ValidarValores())
            {
                AlunoModel model = new AlunoModel(tbNome.Text, tbEmail.Text, dtpDataNasc.Value, tbTele.Text);
                connector.AdicionarAluno(model);
                formAnterior.WireUpLists();
                this.Close();
            }
        }
        else //quando estamos a editar um aluno
        {
            if (ValidarValores())
            {
                AlunoModel model = new AlunoModel(alunoAnterior.IdAluno, tbNome.Text, tbEmail.Text, dtpDataNasc.Value, tbTele.Text);
                connector.AtualizarAluno(model);
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
            MessageBox.Show("O nome deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Email
        string verificacaoEmail = @"^[^@]+@[^@]+.[^@]+$";
        if (Regex.IsMatch(tbEmail.Text, verificacaoEmail) == false)
        {
            valido = false;
            MessageBox.Show("O email deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Data de Nascimento
        else if (dtpDataNasc.Value >= (DateTime.Now.AddYears(-18)))
        {
            valido = false;
            MessageBox.Show("A data de nascimento deste aluno é invalida, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Telefone
        string verificacaoTele = "^[9][1236]([0-9]{7})$";
        if (Regex.IsMatch(tbTele.Text, verificacaoTele) == false)
        {
            valido = false;
            MessageBox.Show("O telefone deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        return valido;
    }
}
