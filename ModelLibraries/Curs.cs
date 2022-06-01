using System;
using System.Data;
using System.Linq;

namespace ModelLibraries
{
    public class Curs
    {
        public int IdCurs { get; set; }
        public int IdFacultate { get; set; }
        public string NumeMaterie { get; set; }
        public string NumeScurt { get; set; }
        public string Sala { get; set; }
        public string IntervalOrar { get; set; }
        public string Saptamani { get; set; }
        public string Profesor { get; set; }
        public string Tip { get; set; }
        
        

        public Curs(int idCurs, string numeMaterie, int idFacultate,string sala, string intervalOrar, string saptamani, string profesor, string tip)
        {
            IdCurs = idCurs;
            IdFacultate = idFacultate;
            IntervalOrar = intervalOrar;
            Sala = sala;
            Saptamani = saptamani;
            Profesor = profesor;
            Tip = tip;
            NumeMaterie = numeMaterie;
            NumeScurt = acronim(numeMaterie);
        }
        public Curs( string numeMaterie, int idFacultate, string sala, string intervalOrar, string saptamani, string profesor, string tip)
        {
            IdCurs = 0;
            IdFacultate = idFacultate;
            IntervalOrar = intervalOrar;
            Sala = sala;
            Saptamani = saptamani;
            Profesor = profesor;
            Tip = tip;
            NumeMaterie = numeMaterie;
            NumeScurt = acronim(numeMaterie);
        }

        public Curs(DataRow linieBD)
        {
            IdCurs = Convert.ToInt32(linieBD["idCurs"].ToString());
            IdFacultate = Convert.ToInt32(linieBD["idFacultate"].ToString());
            IntervalOrar = linieBD["intervalOrar"].ToString();
            Sala = linieBD["Sala"].ToString();
            Saptamani = linieBD["Saptamani"].ToString();
            Profesor = linieBD["Profesor"].ToString();
            Tip = linieBD["Tip"].ToString();
            NumeMaterie = linieBD["NumeMaterie"].ToString();
            NumeScurt = linieBD["NumeScurt"].ToString();
        }

        private string acronim(string input)
        {
                return string.Join(string.Empty,
            input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s[0])
            );
        }
    }
}
