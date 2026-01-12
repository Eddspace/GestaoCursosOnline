using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline.Models;

public class CursoModel
{
    public int IdCurso { get; set; }

    public string Nome { get; set; }

    public string Descricao { get; set; }

    public int CargaHoraria { get; set; }

    public DateTime DataInicio { get; set; }

    public string nomeData { get { return $"{Nome} | Data de Inicio: {DataInicio.Day}/{DataInicio.Month}/{DataInicio.Year}"; } }

    public CursoModel(string nome, string descricao, int cargaHoraria, DateTime dataInicio)
    {
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
        DataInicio = dataInicio;
    }

    public CursoModel(int idCurso, string nome, string descricao, int cargaHoraria, DateTime dataInicio)
    {
        IdCurso = idCurso;
        Nome = nome;
        Descricao = descricao;
        CargaHoraria = cargaHoraria;
        DataInicio = dataInicio;
    }

}

