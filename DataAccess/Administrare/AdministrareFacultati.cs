using ModelLibraries;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class AdministrareFacultati : IStocareFacultati
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceFacultati");

        public List<Facultate> GetFacultati()
        {
            var result = new List<Facultate>();
            var dsFacultati = SqlDBHelper.ExecuteDataSet("select * from facultati_ANDM", CommandType.Text);

            foreach (DataRow linieBD in dsFacultati.Tables[PRIMUL_TABEL].Rows)
            {
                var facultate = new Facultate(linieBD);
                //incarca entitatile aditionale
                // AICI EXEMPLU DE FOEIGN KEY CRED !!!!
                //masina.Companie = new AdministrareCompanii().GetCompanie(masina.IdCompanie);
                result.Add(facultate);
            }
            return result;
        }

        public bool AddFacultate(Facultate facultate)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"INSERT INTO FACULTATI_ANDM VALUES ( {_tableSequence}.NEXTVAL, :NUMEFACULTATE)", CommandType.Text,
                new OracleParameter(":NUMEFACULTATE", OracleDbType.Varchar2, facultate.NumeFacultate, ParameterDirection.Input)
                );
        }


        public Facultate GetFacultate(int id)
        {
            Facultate result = null;
            var dsFacultate = SqlDBHelper.ExecuteDataSet("select * from facultati_ANDM where idFacultate = :idFacultate", 
                CommandType.Text,
                new OracleParameter(":idFacultate", OracleDbType.Int32, id, ParameterDirection.Input)
                );

            if (dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsFacultate.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Facultate(linieBD);
            }
            return result;
        }

        public Facultate GetFacultateByName(string numeFacultate)
        {
            Facultate result = null;
            var dsFacultate = SqlDBHelper.ExecuteDataSet("select * from facultati_ANDM where NUMEFACULTATE = :numeFacultate",
                CommandType.Text,
                new OracleParameter(":numeFacultate", OracleDbType.Varchar2, numeFacultate, ParameterDirection.Input)
                );

            if (dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsFacultate.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Facultate(linieBD);
            }
            return result;
        }


        public bool UpdateFacultate(Facultate m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                "UPDATE facultati_andm set numeFacultate = :numeFacultate where idFacultate= :idFacultate", CommandType.Text,
                new OracleParameter(":numeFacultate", OracleDbType.Varchar2, m.NumeFacultate, ParameterDirection.Input),
                new OracleParameter(":idFacultate", OracleDbType.Int32, m.IdFacultate, ParameterDirection.Input)
            );
        }

        public bool DeleteFacultate(Facultate m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM facultati_andm WHERE IdFacultate = :IdFacultate", CommandType.Text,
                new OracleParameter(":IdFacultate", OracleDbType.Int32, m.IdFacultate, ParameterDirection.Input));
        }

        public bool ValideazaExistentaFacultate(Facultate facultate)
        {
            var dsFacultate = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM facultati_andm WHERE numefacultate = '{facultate.NumeFacultate}'",
                CommandType.Text);

            return dsFacultate.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }
    }
}
