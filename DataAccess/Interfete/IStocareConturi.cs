using ModelLibraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IStocareConturi : IStocareFactory
    {
        bool CheckCont(string numeUtilizator, string parola);
    }
}
