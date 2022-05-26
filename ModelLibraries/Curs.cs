using System;
using System.Data;

namespace ModelLibraries
{
    public class Curs
    {
        public int IdCurs { get; set; }
        public int IdFacultate { get; set; }
        public string InvervalOrar { get; set; }
        public string Saptamani { get; set; }
        public string Profesor { get; set; }
        public string Tip { get; set; }

        public Curs(int idCurs, int idFacultate, string invervalOrar, string saptamani, string profesor, string tip)
        {
            IdCurs = idCurs;
            IdFacultate = idFacultate;
            InvervalOrar = invervalOrar;
            Saptamani = saptamani;
            Profesor = profesor;
            Tip = tip;
        }

        public Curs(DataRow linieBD)
        {
            IdCurs = Convert.ToInt32(linieBD["idCurs"].ToString());
            IdFacultate = Convert.ToInt32(linieBD["idFacultate"].ToString());
            InvervalOrar = linieBD["IntervalOrar"].ToString();
            Saptamani = linieBD["Saptamani"].ToString();
            Profesor = linieBD["Profesor"].ToString();
            Tip = linieBD["Tip"].ToString();
        }
    }
}
