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
    /// <summary>
    /// Função que permite a conneção e comunicação entre o programa e a base de dados SQL
    /// </summary>
    /// <returns></returns>
    private static string CnnString()
    {
        return ConfigurationManager.ConnectionStrings["GestaoCursosOnline"].ConnectionString;
    }

    /// <summary>
    /// Recebe CursoModel e constroi o curso no sql
    /// </summary>
    /// <param name="model"></param>
    public void AdicionarCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
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

    /// <summary>
    /// Recebe AlunoModel e constroi o aluno no sql
    /// </summary>
    /// <param name="model"></param>
    public void AdicionarAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
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

    /// <summary>
    /// Recebe InscricaoModel e constroi a inscrição no sql
    /// </summary>
    /// <param name="model"></param>
    public void AssociarAlunoCurso(InscricaoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
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

    /// <summary>
    /// Recebe CursoModel, verifica a existencia deste no sql com o ID indicado, e modifica os outros valores do curso na base de dados
    /// </summary>
    /// <param name="model"></param>
    public void AtualizarCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
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

    /// <summary>
    /// Recebe AlunoModel, verifica a existencia deste no sql com o ID indicado, e modifica os outros valores do aluno na base de dados
    /// </summary>
    /// <param name="model"></param>
    public void AtualizarAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
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

    /// <summary>
    /// Recebe CursoModel, procura o curso no sql com o ID indicado, e elimina esse registo
    /// </summary>
    /// <param name="model"></param>
    public void RemoverCurso(CursoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);

            connection.Execute("dbo.spRemoverCurso", p, commandType: CommandType.StoredProcedure);
        }
    }

    /// <summary>
    /// Recebe AlunoModel, procura o aluno no sql com o ID indicado, e elimina esse registo
    /// </summary>
    /// <param name="model"></param>
    public void RemoverAluno(AlunoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            var p = new DynamicParameters();
            p.Add("@IdAluno", model.IdAluno);

            connection.Execute("dbo.spRemoverAluno", p, commandType: CommandType.StoredProcedure);
        }
    }

    /// <summary>
    /// Recebe InscricaoModel, procura a inscrição no sql com o ID indicado, e elimina esse registo
    /// </summary>
    /// <param name="model"></param>
    public void RemoverAlunoCurso(InscricaoModel model)
    {
        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso_Aluno", model.IdCurso_Aluno);

            connection.Execute("dbo.spRemoverAlunoCurso", p, commandType: CommandType.StoredProcedure);
        }
    }

    /// <summary>
    /// Devolve a lista de todos os registos dentro da tabela de cursos no sql
    /// </summary>
    /// <returns></returns>
    public List<CursoModel> ListarCursos()
    {
        List<CursoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            output = connection.Query<CursoModel>("dbo.spListarCursos").ToList();
        }
        return output;
    }

    /// <summary>
    /// Devolve a lista de todos os registos dentro da tabela de alunos no sql
    /// </summary>
    /// <returns></returns>
    public List<AlunoModel> ListarAlunos()
    {
        List<AlunoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            output = connection.Query<AlunoModel>("dbo.spListarAlunos").ToList();
        }
        return output;
    }

    /// <summary>
    /// Recebe CursoModel e devolve uma lista de inscrições quando estas contem o ID do curso que indicamos
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public List<InscricaoModel> ListarAlunosPorCurso(CursoModel model)
    {
        List<InscricaoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            var p = new DynamicParameters();
            p.Add("@IdCurso", model.IdCurso);

            output = connection.Query<InscricaoModel>("dbo.spListarAlunosPorCurso", p, commandType: CommandType.StoredProcedure).ToList();

        }
        return output;
    }

    /// <summary>
    /// Recebe AlunoModel e devolve uma lista de inscrições quando estas contem o ID do aluno que indicamos
    /// </summary>
    /// <param name="model"></param>
    /// <returns></returns>
    public List<InscricaoModel> ListarCursosPorAluno(AlunoModel model)
    {
        List<InscricaoModel> output;

        using (IDbConnection connection = new Microsoft.Data.SqlClient.SqlConnection(CnnString()))
        {
            var p = new DynamicParameters();
            p.Add("@IdAluno", model.IdAluno);

            output = connection.Query<InscricaoModel>("dbo.spListarCursosPorAluno", p, commandType: CommandType.StoredProcedure).ToList();

        }
        return output;
    }

}
