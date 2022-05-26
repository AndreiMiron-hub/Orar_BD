using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibraries;

namespace DataAccess
{
    public interface IStocareFacultati : IStocareFactory
    {
        List<Facultate> GetFacultati();
        Facultate GetFacultate(int id);
        bool AddFacultate(Facultate m);

        bool UpdateFacultate(Facultate m);
    }
}
