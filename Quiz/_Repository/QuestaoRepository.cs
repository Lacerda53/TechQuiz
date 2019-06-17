using Quiz._infra;
using Quiz._Repositorys.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Quiz.Areas.Admin.Models;

namespace Quiz._Repository
{
    public class QuestaoRepository : IQuestaoRepository
    {
        private IDB DB;
        public QuestaoRepository(IDB _db)
        {
            DB = _db;
        }
        public void Delete(int IDQuestao)
        {
            using (var con = DB.GetConnection())
            {
                var query = "update Questao set habilitado = 0 where IDQuestao = @IDQuestao";
                con.Execute(query, new { IDQuestao });
            }
        }

        public IEnumerable<Questao> Get()
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Questao where habilitado=1";
                return con.Query<Questao>(query);
            }
        }

        public Questao GetbyID(int IDQuestao)
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Questao where IDQuestao=@IDQuestao";
                return con.QueryFirstOrDefault<Questao>(query, new { IDQuestao });
            }
        }

        public void Include(Questao item)
        {
            using (var con = DB.GetConnection())
            {
                var query = "insert into Questao (Enunciado,habilitado) values (@Enunciado,1)";
                con.Execute(query, new { item.Enunciado });
            }
        }

        public void Update(Questao item)
        {
            using (var con = DB.GetConnection())
            {
                var query = "update Questao set Enunciado=@Enunciado where IDQuestao=@IDQuestao";
                con.Execute(query, new { item.Enunciado, item.IDQuestao });
            }
        }

    }
}
