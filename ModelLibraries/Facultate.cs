using System;
using System.Data;


namespace ModelLibraries
{
    public class Facultate
    {
        public int IdFacultate { get; set; }
        public string NumeFacultate { get; set; }

        public Facultate(int idFacultate, string numeFacultate)
        {
            IdFacultate = idFacultate;
            NumeFacultate = numeFacultate;
        }

        public Facultate(DataRow linieBD)
        {
            IdFacultate = Convert.ToInt32(linieBD["idFacultate"].ToString());
            NumeFacultate = linieBD["numeFacultate"].ToString();
        }
    }
}