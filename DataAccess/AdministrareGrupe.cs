using ModelLibraries;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace DataAccess
{
    public class AdministrareGrupe : IStocareGrupe
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;


        public List<Grupa> GetGrupe()
        {
            var result = new List<Grupa>();
            var dsGrupe = SqlDBHelper.ExecuteDataSet("select * from grupe_ANDM", CommandType.Text);

            foreach (DataRow linieBD in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                var grupa = new Grupa(linieBD);
                //incarca entitatile aditionale
                // AICI EXEMPLU DE FOEIGN KEY CRED !!!!
                //masina.Companie = new AdministrareCompanii().GetCompanie(masina.IdCompanie);
                result.Add(grupa);
            }
            return result;
        }

        public List<Grupa> GetGrupeByFaculty(int idFacultate)
        {
            var result = new List<Grupa>();

            var dsGrupe = SqlDBHelper.ExecuteDataSet("select * from grupe_andm where IdFacultate = :IdFacultate", CommandType.Text,
                new OracleParameter(":IdMaterie", OracleDbType.Int32, idFacultate, ParameterDirection.Input));

            foreach (DataRow linieBD in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                var grupa = new Grupa(linieBD);
                result.Add(grupa);
            }
            return result;




        }

        public bool AddGrupa(Grupa m)
        {
            throw new NotImplementedException();
        }

        public Grupa GetGrupa(int id)
        {
            throw new NotImplementedException();
        }


        public bool UpdateGrupa(Grupa m)
        {
            throw new NotImplementedException();
        }


    }
}