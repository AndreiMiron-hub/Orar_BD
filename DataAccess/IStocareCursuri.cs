using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLibraries;

namespace DataAccess
{
    public interface IStocareCursuri : IStocareFactory
    {
        List<Curs> GetCursuri();
        List<Curs> GetCursuriByGrupa(int idGrupa, int idFacultate);
        Curs GetCurs(int id);

        bool AddCurs(Curs m);

        bool UpdateCurs(Curs m);
    }
}
