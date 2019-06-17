using Quiz._infra;
using Quiz._Repositorys.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using Quiz.Areas.Admin.Models;

namespace Quiz._Repositorys
{
    public class AlternativaRepository : IAlternativaRepository
    {
        private IDB DB;
        public AlternativaRepository(IDB _db)
        {
            DB = _db;
        }
        public void Delete(int IDAlternativa)
        {
            using (var con = DB.GetConnection())
            {
                var query = "update Alternativa set habilitado=0 where IDAlternativa=@IDAlternativa";
                    con.Execute(query, new { IDAlternativa });
            }
        }

        public void Include(Alternativa item)
        {
            using (var con = DB.GetConnection())
            {
                var query = "insert into Alternativa (Resposta, habilitado, Correta, IDQuestao) values (@Resposta,1,@Correta,@IDQuestao)";
                con.Execute(query, new { item.Resposta, item.Correta, item.IDQuestao });
            }
        }

        public void Update(Alternativa item)
        {
            using (var con = DB.GetConnection())
            {
                var query = "update Alternativa set Resposta=@Resposta, Correta=@Correta where IDAlternativa=@IDAlternativa";
                con.Execute(query, new { item.Resposta, item.Correta, item.IDAlternativa });
            }
        }

        IEnumerable<Alternativa> IAlternativaRepository.Get()
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Alternativa as A INNER JOIN Questao as Q ON A.IDQuestao = Q.IDQuestao where A.habilitado=1";
                return con.Query<Alternativa>(query);
            }
        }

        Alternativa IAlternativaRepository.GetbyID(int IDAlternativa)
        {
            using (var con = DB.GetConnection())
            {
                var query = "select * from Alternativa where IDAlternativa=@IDAlternativa";
                return con.QueryFirstOrDefault<Alternativa>(query, new { IDAlternativa });
            }
            
        }
    }
}
