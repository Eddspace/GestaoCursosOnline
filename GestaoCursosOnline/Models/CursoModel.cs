using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class CursoModel
{
    /// <summary>
    /// Representa o identificador do curso em formato int
    /// </summary>
    public int IdCurso { get; set; }


    /// <summary>
    /// Representa o nome do curso em formato string
    /// </summary>
    public string Nome { get; set; }


    /// <summary>
    /// Representa a descrição do curso em formato string
    /// </summary>
    public string Descricao { get; set; }


    /// <summary>
    /// Representa a carga horaria do curso em formato int
    /// </summary>
    public int CargaHoraria { get; set; }


    /// <summary>
    /// Representa a data de inicio do curso em formato datetime
    /// </summary>
    public DateTime DataInicio { get; set; }


    /// <summary>
    /// Permite a representação de ambos o nome e data de inicio do curso durante listagens
    /// </summary>
    public string nomeData { get { return $"{Nome} | Data de Inicio: {DataInicio.Day}/{DataInicio.Month}/{DataInicio.Year}"; } }


    /// <summary>
    /// Contrutor basico do modelo curso (sem IdCurso), usado durante o processo de criação de registos na base de dados
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="descricao"></param>
    /// <param name="cargaHoraria"></param>
    /// <param name="dataInicio"></param>
    public CursoModel(string nome, string descricao, int cargaHoraria, DateTime dataInicio)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
        DataInicio = dataInicio;
    }


    /// <summary>
    /// Contrutor mais complexo do modelo curso (com IdCurso), usado para o resto dos processos como edição e remoção
    /// </summary>
    /// <param name="idCurso"></param>
    /// <param name="nome"></param>
    /// <param name="descricao"></param>
    /// <param name="cargaHoraria"></param>
    /// <param name="dataInicio"></param>
    public CursoModel(int idCurso, string nome, string descricao, int cargaHoraria, DateTime dataInicio)
    {
        IdCurso = idCurso;
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
        DataInicio = dataInicio;
    }

}

