using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibraries
{
    public class Cont
    {
        public int IdCont { get; set; }
        public string NumeUtilizator { get; set; }
        public string Parola { get; set; }

        public Cont(int idCont, string numeUtilizator, string parola)
        {
            IdCont = idCont;
            NumeUtilizator = numeUtilizator;
            Parola = parola;
        }

        public Cont(DataRow linieBD)
        {
            IdCont = Convert.ToInt32(linieBD["idCont"].ToString());
            NumeUtilizator = linieBD["NumeUtilizator"].ToString();
            Parola = linieBD["Parola"].ToString();
        }
    }
}
