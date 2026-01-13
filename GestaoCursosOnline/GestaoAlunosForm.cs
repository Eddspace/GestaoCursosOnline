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

    public GestaoAlunosForm(GestaoInscricoesForm gIF) //a inicialização usada caso o utilizador escolha para criar um novo aluno
    {
        InitializeComponent();
        dtpDataNasc.CustomFormat = "dd/MM/yyyy";

        NovoAluno = true; //define que estamos a criar um novo aluno para editar a função final do btnconfirmar

        connector = new SqlConnector();
        formAnterior = gIF;

    }

    public GestaoAlunosForm(AlunoModel alunoSelecionado, GestaoInscricoesForm gIF) //a inicialização usada caso o utilizador escolha editar um aluno
    {
        InitializeComponent();
        dtpDataNasc.CustomFormat = "dd/MM/yyyy";
        
        alunoAnterior = alunoSelecionado;
        formAnterior = gIF;
        connector = new SqlConnector();

        NovoAluno = false; //define que estamos a editar um aluno para editar a função final do btnconfirmar

        //quando estamos a editar vamos inserir os valores previos nas caixas de texto para facil compreenção
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
            if (ValidarValores()) //verificamos se é valido
            {
                AlunoModel model = new AlunoModel(tbNome.Text, tbEmail.Text, dtpDataNasc.Value, tbTele.Text); //cria um aluno com os valores inseridos
                connector.AdicionarAluno(model); //e envia o tal aluno para a base de dados
                formAnterior.WireUpLists();
                this.Close();
            }
        }
        else //quando estamos a editar um aluno
        {
            if (ValidarValores()) //verificamos se é valido
            {
                AlunoModel model = new AlunoModel(alunoAnterior.IdAluno, tbNome.Text, tbEmail.Text, dtpDataNasc.Value, tbTele.Text); //cria um aluno com os valores inseridos
                connector.AtualizarAluno(model); //e envia os valores do tal aluno para atualizar o mesmo na base de dados
                formAnterior.WireUpLists();
                this.Close();
            }
        }
    }

    private bool ValidarValores()
    {
        bool valido = true;

        //validar Nome
        if (tbNome.Text == string.Empty) //quando vazio
        {
            valido = false;
            MessageBox.Show("O nome deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Email
        string verificacaoEmail = @"^[^@]+@[^@]+.[^@]+$";
        if (Regex.IsMatch(tbEmail.Text, verificacaoEmail) == false) //quando o email não se verifica com um formato espectado, ou seja se não contem @ e acaba com .algo
        {
            valido = false;
            MessageBox.Show("O email deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Data de Nascimento
        else if (dtpDataNasc.Value >= (DateTime.Now.AddYears(-18))) //quando menor que 18 anos
        {
            valido = false;
            MessageBox.Show("A data de nascimento deste aluno é invalida, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        //validar Telefone
        string verificacaoTele = "^[9][1236]([0-9]{7})$";
        if (Regex.IsMatch(tbTele.Text, verificacaoTele) == false) //verifica se o telefone começa com 9, seguido por 1/2/3/6 e tem 9 numeros totais.
        {
            valido = false;
            MessageBox.Show("O telefone deste aluno é invalido, por favor verifique a informação inserida", "Erro, Informação invalida");
        }

        return valido;
    }
}
