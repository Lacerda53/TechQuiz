using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Quiz._infra
{
    public interface IDB : IDisposable
    {
        DbConnection GetConnection();
    }
}
