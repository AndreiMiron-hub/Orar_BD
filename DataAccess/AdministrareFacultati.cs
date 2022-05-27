using ModelLibraries;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class AdministrareFacultati : IStocareFacultati
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;


        public List<Facultate> GetFacultati()
        {
            var result = new List<Facultate>();
            var dsFacultati = SqlDBHelper.ExecuteDataSet("select * from facultati_andm", CommandType.Text);

            foreach (DataRow linieBD in dsFacultati.Tables[PRIMUL_TABEL].Rows)
            {
                var facultate = new Facultate(linieBD);
                result.Add(facultate);
            }
            return result;
        }

        public bool AddFacultate(Facultate m)
        {
            throw new NotImplementedException();
        }

        public Facultate GetFacultate(int id)
        {
            throw new NotImplementedException();
        }


        public bool UpdateFacultate(Facultate m)
        {
            throw new NotImplementedException();
        }
    }
}
