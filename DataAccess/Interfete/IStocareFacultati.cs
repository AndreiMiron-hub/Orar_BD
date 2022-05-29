using System.Collections.Generic;
using ModelLibraries;

namespace DataAccess
{
    public interface IStocareFacultati : IStocareFactory
    {
        List<Facultate> GetFacultati();
        Facultate GetFacultate(int id);
        bool AddFacultate(Facultate m);

        bool UpdateFacultate(Facultate m);
        bool DeleteFacultate(Facultate m);
        bool ValideazaExistentaFacultate(Facultate facultate);
    }
}
