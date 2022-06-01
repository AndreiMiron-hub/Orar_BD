using ModelLibraries;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace DataAccess
{
    public class AdministrareGrupe : IStocareGrupe
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceGrupe");
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

        public List<Grupa> GetGrupeAfisare()
        {
            var result = new List<Grupa>();
            var dsGrupe = SqlDBHelper.ExecuteDataSet("select g.idGrupa, g.nrStudenti, g.sefGrupa, g.idFacultate, f.numeFacultate " +
                                                    "from facultati_andm f, grupe_andm g " +
                                                    "where g.idFacultate = f.idFacultate", CommandType.Text);

            foreach (DataRow linieBD in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                var grupa = new Grupa(linieBD);
                grupa.GrupaAfisare(linieBD);
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
                new OracleParameter(":IdFacultate", OracleDbType.Int32, idFacultate, ParameterDirection.Input));

            foreach (DataRow linieBD in dsGrupe.Tables[PRIMUL_TABEL].Rows)
            {
                var grupa = new Grupa(linieBD);
                result.Add(grupa);
            }
            return result;




        }

        public bool AddGrupa(Grupa g, Facultate f)
        {
            return SqlDBHelper.ExecuteNonQuery(
                 $"INSERT INTO GRUPE_ANDM VALUES ( :idGrupa, :nrStudenti , :sefGrupa, :idFacultate)", CommandType.Text,
                 new OracleParameter(":idGrupa", OracleDbType.Int32, g.IdGrupa, ParameterDirection.Input),
                 new OracleParameter(":nrStudenti", OracleDbType.Int32, g.NrStudenti, ParameterDirection.Input),
                 new OracleParameter(":sefGrupa", OracleDbType.Varchar2, g.SefGrupa, ParameterDirection.Input),
                 new OracleParameter(":idFacultate", OracleDbType.Int32, f.IdFacultate, ParameterDirection.Input)
                 );
        }

        public Grupa GetGrupa(int id)
        {
            Grupa result = null;
            var dsGrupa = SqlDBHelper.ExecuteDataSet("select * from grupe_ANDM where idGrupa = :idGrupa",
                CommandType.Text,
                new OracleParameter(":idGrupa", OracleDbType.Int32, id, ParameterDirection.Input)
                );

            if (dsGrupa.Tables[PRIMUL_TABEL].Rows.Count > 0)
            {
                DataRow linieBD = dsGrupa.Tables[PRIMUL_TABEL].Rows[PRIMA_LINIE];
                result = new Grupa(linieBD);
            }
            return result;
        }


        public bool UpdateGrupa(Grupa m)
        {
            throw new NotImplementedException();
        }

        public bool DeleteGrupa(Grupa m)
        {
            return SqlDBHelper.ExecuteNonQuery(
                $"DELETE FROM grupe_andm WHERE IdGrupa = :IdGrupa", CommandType.Text,
                new OracleParameter(":IdGrupa", OracleDbType.Int32, m.IdGrupa, ParameterDirection.Input));
        }

        public bool ValideazaExistentaGrupa(Grupa grupa)
        {
            var dsGrupe = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM grupe_andm WHERE idGrupa = '{grupa.IdGrupa}'",
                CommandType.Text);

            return dsGrupe.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }

       
    }
}