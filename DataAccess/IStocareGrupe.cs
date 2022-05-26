using System.Collections.Generic;
using ModelLibraries;

namespace DataAccess
{
    public interface IStocareGrupe : IStocareFactory
    {
        List<Grupa> GetGrupe();
        List<Grupa> GetGrupeByFaculty(int idFacultate);
        Grupa GetGrupa(int id);
        bool AddGrupa(Grupa m);

        bool UpdateGrupa(Grupa m);
    }
}
