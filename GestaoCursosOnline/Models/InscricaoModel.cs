using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class InscricaoModel
{
    /// <summary>
    /// Representa o identificador da junção curso e aluno
    /// </summary>
    public int IdCurso_Aluno { get; set; }


    /// <summary>
    /// Representa o identificador do curso desta reserva
    /// </summary>
    public int IdCurso { get; set; }


    /// <summary>
    /// Representa o identificador do aluno desta reserva
    /// </summary>
    public int IdAluno { get; set; }


    /// <summary>
    /// Representa a data da inscrição inserida
    /// </summary>
    public DateTime DataInscricao { get; set; }


    /// <summary>
    /// Contrutor basico da junção curso e aluno (sem IdCurso_Aluno), usado para assossiar e remover inscrições
    /// </summary>
    /// <param name="idCurso"></param>
    /// <param name="idAluno"></param>
    /// <param name="dataInscricao"></param>
    public InscricaoModel(int idCurso, int idAluno, DateTime dataInscricao)
    {
        IdCurso = idCurso;
        IdAluno = idAluno;
        DataInscricao = dataInscricao;
    }


    /// <summary>
    /// Contrutor mais complexo da junção curso e aluno (com IdCurso_Aluno), usado nas listagens de inscrições
    /// </summary>
    /// <param name="idCurso_Aluno"></param>
    /// <param name="idCurso"></param>
    /// <param name="idAluno"></param>
    /// <param name="dataInscricao"></param>
    public InscricaoModel(int idCurso_Aluno, int idCurso, int idAluno, DateTime dataInscricao)
    {
        IdCurso_Aluno = idCurso_Aluno;
        IdCurso = idCurso;
        IdAluno = idAluno;
        DataInscricao = dataInscricao;
    }

}
