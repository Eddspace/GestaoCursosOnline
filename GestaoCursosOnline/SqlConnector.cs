using Dapper;
using GestaoCursosOnline.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoCursosOnline;

public class SqlConnector
{

    private const string db = "GestaoCursosOnline";

    private static string CnnString(string name)
    {
        return ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }

    public void AdicionarCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@Nome", model.Nome);
            p.Add("@Descricao", model.Descricao);
            p.Add("@CargaHoraria", model.CargaHoraria);
            p.Add("@DataInicio", model.DataInicio);
            p.Add("@IdCurso", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spAdicionarCurso", p, commandType: CommandType.StoredProcedure);

            model.IdCurso = p.Get<int>("@IdCurso");
        }
    }

    public void AdicionarAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@Nome", model.Nome);
            p.Add("@Email", model.Email);
            p.Add("@DataNascimento", model.DataNascimento);
            p.Add("@Telefone", model.Telefone);
            p.Add("@IdAluno", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spAdicionarAluno", p, commandType: CommandType.StoredProcedure);

            model.IdAluno = p.Get<int>("@IdAluno");
        }
    }

    public void AssociarAlunoCurso(InscricaoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);
            p.Add("@IdAluno", model.IdAluno);
            p.Add("@DataInscricao", model.DataInscricao);
            p.Add("@IdCurso_Aluno", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

            connection.Execute("dbo.spAssociarAlunoCurso", p, commandType: CommandType.StoredProcedure);

            model.IdCurso_Aluno = p.Get<int>("@IdCurso_Aluno");
        }
    }

    public void AtualizarCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);
            p.Add("@Nome", model.Nome);
            p.Add("@Descricao", model.Descricao);
            p.Add("@CargaHoraria", model.CargaHoraria);
            p.Add("@DataInicio", model.DataInicio);
            
            connection.Execute("dbo.spAtualizarCurso", p, commandType: CommandType.StoredProcedure);
        }
    }

    public void AtualizarAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdAluno", model.IdAluno);
            p.Add("@Nome", model.Nome);
            p.Add("@Email", model.Email);
            p.Add("@DataNascimento", model.DataNascimento);
            p.Add("@Telefone", model.Telefone);

            connection.Execute("dbo.spAtualizarAluno", p, commandType: CommandType.StoredProcedure);
        }
    }

    public void RemoverCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);

            connection.Execute("dbo.spRemoverCurso", p, commandType: CommandType.StoredProcedure);
        }
    }

    public void RemoverAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdAluno", model.IdAluno);

            connection.Execute("dbo.spRemoverAluno", p, commandType: CommandType.StoredProcedure);
        }
    }

    public void RemoverAlunoCurso(InscricaoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso_Aluno", model.IdCurso_Aluno);

            connection.Execute("dbo.spRemoverAlunoCurso", p, commandType: CommandType.StoredProcedure);
        }
    }

    public List<CursoModel> ListarCursos()
    {
        List<CursoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            output = connection.Query<CursoModel>("dbo.spListarCursos").ToList();
        }
        return output;
    }

    public List<AlunoModel> ListarAlunos()
    {
        List<AlunoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            output = connection.Query<AlunoModel>("dbo.spListarAlunos").ToList();
        }
        return output;
    }

    public List<InscricaoModel> ListarAlunosPorCurso(CursoModel model)
    {
        List<InscricaoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);

            output = connection.Query<InscricaoModel>("dbo.spListarAlunosPorCurso", p, commandType: CommandType.StoredProcedure).ToList();

        }
        return output;
    }

    public List<InscricaoModel> ListarCursosPorAluno(AlunoModel model)
    {
        List<InscricaoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString(db)))
        {
            var p = new DynamicParameters();
            p.Add("@IdAluno", model.IdAluno);

            output = connection.Query<InscricaoModel>("dbo.spListarCursosPorAluno", p, commandType: CommandType.StoredProcedure).ToList();

        }
        return output;
    }

}
