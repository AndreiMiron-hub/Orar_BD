using ModelLibraries;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class AdministrareCursuri : IStocareCursuri
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;


        public List<Curs> GetCursuri()
        {
            var result = new List<Curs>();
            var dsCursuri = SqlDBHelper.ExecuteDataSet("select * from cursuri_ANDM", CommandType.Text);

            foreach (DataRow linieBD in dsCursuri.Tables[PRIMUL_TABEL].Rows)
            {
                var curs = new Curs(linieBD);
                //incarca entitatile aditionale
                // AICI EXEMPLU DE FOEIGN KEY CRED !!!!
                //masina.Companie = new AdministrareCompanii().GetCompanie(masina.IdCompanie);
                result.Add(curs);
            }
            return result;
        }

        public bool AddCurs(Curs m)
        {
            throw new NotImplementedException();
        }

        public Curs GetCurs(int id)
        {
            throw new NotImplementedException();
        }


        public bool UpdateCurs(Curs m)
        {
            throw new NotImplementedException();
        }
    }
}
