using System.Collections.Generic;
using ModelLibraries;

namespace DataAccess
{
    public interface IStocareGrupe : IStocareFactory
    {
        List<Grupa> GetGrupe();
        List<Grupa> GetGrupeByFaculty(int idFacultate);
        Grupa GetGrupa(int id);
        List<Grupa> GetGrupeAfisare();
        bool AddGrupa(Grupa g, Facultate f);

        bool UpdateGrupa(Grupa m);
        bool DeleteGrupa(Grupa m);
        bool ValideazaExistentaGrupa(Grupa grupa);
    }
}