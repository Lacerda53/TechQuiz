using Quiz.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz._Repositorys.core
{
    public interface IAlternativaRepository
    {
        void Include(Alternativa item);
        void Update(Alternativa item);
        void Delete(int IDAlternativa);
        Alternativa GetbyID(int IDAlternativa);
        IEnumerable<Alternativa> Get();
    }
}
