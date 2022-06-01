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
        List<Curs> GetCursuriByGrupaSiFacultate(int idGrupa, int idFacultate);
        List<Curs> GetCursuriByGrupa(int idGrupa);
        List<Curs> GetCursuriByFacultate(int idFacultate);
        Curs GetCurs(int id);

        bool AddCurs(Curs m);

        bool UpdateCurs(Curs m);
    }
}
