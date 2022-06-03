using System;
using System.Data;

namespace ModelLibraries
{
    public class Grupa
    {
        public int IdGrupa { get; set; }
        public int NumarGrupa { get; set; }
        public int NrStudenti { get; set; }
        public string SefGrupa { get; set; }
        public int IdFacultate { get; set; }
        public string NumeFacultate { get; set; }



        public Grupa(int numarGrupa, int nrStudenti, string sefGrupa, int idFacultate)
        {
            IdGrupa = 0;
            NumarGrupa = numarGrupa;
            NrStudenti = nrStudenti;
            SefGrupa = sefGrupa;
            IdFacultate = idFacultate;
        }

        public Grupa(int numarGrupa, int nrStudenti, string sefGrupa, int idFacultate, string numeFacultate)
        {
            IdGrupa = 0;
            NumarGrupa = numarGrupa;
            NrStudenti = nrStudenti;
            SefGrupa = sefGrupa;
            IdFacultate = idFacultate;
            NumeFacultate = numeFacultate;
        }

        public Grupa(DataRow linieBD)
        {
            IdGrupa = Convert.ToInt32(linieBD["idGrupa"].ToString());
            NrStudenti = Convert.ToInt32(linieBD["NrStudenti"].ToString());
            SefGrupa = linieBD["SefGrupa"].ToString();
            IdFacultate = Convert.ToInt32(linieBD["idFacultate"].ToString());
            NumeFacultate = linieBD["numeFacultate"].ToString();
            if (Convert.ToInt32(linieBD["NUMARGRUPA"].ToString()) != null)
                NumarGrupa = Convert.ToInt32(linieBD["NUMARGRUPA"].ToString());
            else
                NumarGrupa = 0;
        }

        public void GrupaAfisare(DataRow linieBD)
        {
            NumeFacultate = linieBD["numeFacultate"].ToString();
        }
    }
}