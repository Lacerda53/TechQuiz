using Quiz.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz._Repositorys.core
{
    public interface IQuestaoRepository
    {
        void Include(Questao item);
        void Update(Questao item);
        void Delete(int IDQuestao);
        Questao GetbyID(int IDQuestao);
        IEnumerable<Questao> Get();
    }
}
