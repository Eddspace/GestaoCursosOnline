using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class InscricaoModel
{
    public int IdCurso_Aluno { get; set; }

    public int IdCurso { get; set; }

    public int IdAluno { get; set; }

    public DateTime DataInscricao { get; set; }

    public InscricaoModel(int idCurso, int idAluno, DateTime dataInscricao)
    {
        IdCurso = idCurso;
        IdAluno = idAluno;
        DataInscricao = dataInscricao;
    }

}
