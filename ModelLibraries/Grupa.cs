using System;
using System.Data;

namespace ModelLibraries
{
    public class Grupa
    {
        public int IdGrupa{ get; set; }
        public int NrStudenti { get; set; }
        public string SefGrupa { get; set; }
        public int IdFacultate { get; set; }

        public Grupa(int idGrupa, int nrStudenti, string sefGrupa, int idFacultate)
        {
            IdGrupa = idGrupa;
            NrStudenti = nrStudenti;
            SefGrupa = sefGrupa;
            IdFacultate = idFacultate;
        }

        public Grupa(DataRow linieBD)
        {
            IdGrupa = Convert.ToInt32(linieBD["idGrupa"].ToString());
            NrStudenti = Convert.ToInt32(linieBD["NrStudenti"].ToString());
            SefGrupa = linieBD["SefGrupa"].ToString();
            IdFacultate = Convert.ToInt32(linieBD["idFacultate"].ToString());
        }
    }
}
