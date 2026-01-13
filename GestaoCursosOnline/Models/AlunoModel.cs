using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class AlunoModel
{
    /// <summary>
    /// Representa o identificador do aluno em formato int
    /// </summary>
    public int IdAluno { get; set; }


    /// <summary>
    /// Representa o nome do aluno em formato string
    /// </summary>
    public string Nome { get; set; }


    /// <summary>
    /// Representa o email do aluno em formato string
    /// </summary>
    public string Email { get; set; }


    /// <summary>
    /// Representa a Data de Nascimento do aluno em formato datetime
    /// </summary>
    public DateTime DataNascimento { get; set; }


    /// <summary>
    /// Representa o numero de telefone do aluno em formato string (não necessitamos que este seja int pois não vamos calcular com o mesmo)
    /// </summary>
    public string Telefone { get; set; }


    /// <summary>
    /// Contrutor basico do modelo aluno (sem IdAluno), usado durante o processo de criação de registos na base de dados
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="email"></param>
    /// <param name="dataNascimento"></param>
    /// <param name="telefone"></param>
    public AlunoModel(string nome, string email, DateTime dataNascimento, string telefone)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }


    /// <summary>
    /// Contrutor mais complexo do modelo aluno (com IdAluno), usado para o resto dos processos como edição e remoção
    /// </summary>
    /// <param name="idAluno"></param>
    /// <param name="nome"></param>
    /// <param name="email"></param>
    /// <param name="dataNascimento"></param>
    /// <param name="telefone"></param>
    public AlunoModel(int idAluno, string nome, string email, DateTime dataNascimento, string telefone)
    {
        IdAluno = idAluno;
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }
}
