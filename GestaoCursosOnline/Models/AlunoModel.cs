using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class AlunoModel
{
    public int IdAluno { get; set; }

    public string Nome { get; set; }

    public string Email { get; set; }

    public DateTime DataNascimento { get; set; }

    public string Telefone { get; set; }

    public AlunoModel(string nome, string email, DateTime dataNascimento, string telefone)
    {
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }

    public AlunoModel(int idAluno, string nome, string email, DateTime dataNascimento, string telefone)
    {
        IdAluno = idAluno;
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        Telefone = telefone;
    }
}
