using ModelLibraries;
using System;
using System.Collections.Generic;
using Oracle.DataAccess.Client;
using System.Data;
using System.Configuration;

namespace DataAccess
{
    public class AdministrareCursuri : IStocareCursuri
    {
        private const int PRIMUL_TABEL = 0;
        private const int PRIMA_LINIE = 0;

        private readonly string _tableSequence = ConfigurationManager.AppSettings.Get("TableSequenceCursuri");
        public List<Curs> GetCursuri()
        {
            var result = new List<Curs>();
            var dsCursuri = SqlDBHelper.ExecuteDataSet("select * from cursuri_ANDM", CommandType.Text);

            foreach (DataRow linieBD in dsCursuri.Tables[PRIMUL_TABEL].Rows)
            {
                var curs = new Curs(linieBD);
                result.Add(curs);
            }
            return result;
        }

        public List<Curs> GetCursuriByGrupaSiFacultate(int idGrupa, int idFacultate)
        {
            var result = new List<Curs>();

            var dsCursuri = SqlDBHelper.ExecuteDataSet(
                "select  c.IDCURS, c.IDFACULTATE, c.INTERVALORAR, c.SAPTAMANI, c.SALA, c.PROFESOR, c.TIP, c.NUMEMATERIE, c.NUMESCURT " +
                "from cursuri_andm c, C_G_INTERMEDIAR_ANDM cg " +
                "where c.idFacultate = :idFacultate AND c.idcurs = cg.idcurs AND cg.idgrupa = :idGrupa",
                CommandType.Text,
                new OracleParameter(":idFacultate", OracleDbType.Int32, idFacultate, ParameterDirection.Input),
                new OracleParameter(":idGrupa", OracleDbType.Int32, idGrupa, ParameterDirection.Input)
                );

            foreach (DataRow linieBD in dsCursuri.Tables[PRIMUL_TABEL].Rows)
            {
                var curs = new Curs(linieBD);
                result.Add(curs);
            }
            return result;
        }
        public List<Curs> GetCursuriByGrupa(int idGrupa)
        {
            var result = new List<Curs>();

            var dsCursuri = SqlDBHelper.ExecuteDataSet(
                "select  c.IDCURS, c.IDFACULTATE, c.INTERVALORAR, c.SAPTAMANI, c.SALA, c.PROFESOR, c.TIP, c.NUMEMATERIE, c.NUMESCURT " +
                "from cursuri_andm c, C_G_INTERMEDIAR_ANDM cg " +
                "where c.IDCURS = cg.IDCURS AND cg.IDGRUPA = :idGrupa",
                CommandType.Text,
                new OracleParameter(":idGrupa", OracleDbType.Int32, idGrupa, ParameterDirection.Input)
                );

            foreach (DataRow linieBD in dsCursuri.Tables[PRIMUL_TABEL].Rows)
            {
                var curs = new Curs(linieBD);
                result.Add(curs);
            }
            return result;
        }
        public bool AddCurs(Curs m, Facultate f)
        {
             bool x = SqlDBHelper.ExecuteNonQuery(
                 "INSERT INTO cursuri_ANDM (idCurs, IdFacultate, IntervalOrar, Saptamani, Sala, Profesor, Tip, NUMEMATERIE, NUMESCURT ) " +
                 $"VALUES({_tableSequence}.NEXTVAL, :IdFacultate, :IntervalOrar, :Saptamani, :Sala, :Profesor, :Tip,:NUMEMATERIE, :NUMESCURT) "
                 , CommandType.Text,
                 new OracleParameter(":IdFacultate", OracleDbType.Int32, f.IdFacultate, ParameterDirection.Input),
                 new OracleParameter(":IntervalOrar", OracleDbType.Varchar2, m.IntervalOrar, ParameterDirection.Input),
                 new OracleParameter(":Saptamani", OracleDbType.Varchar2, m.Saptamani, ParameterDirection.Input),
                 new OracleParameter(":Sala", OracleDbType.Varchar2, m.Sala, ParameterDirection.Input),
                 new OracleParameter(":Profesor", OracleDbType.Varchar2, m.Profesor, ParameterDirection.Input),
                 new OracleParameter(":Tip", OracleDbType.Varchar2, m.Tip, ParameterDirection.Input),
                 new OracleParameter(":NUMEMATERIE", OracleDbType.Varchar2, m.NumeMaterie, ParameterDirection.Input),
                 new OracleParameter(":NUMESCURT", OracleDbType.Varchar2, m.NumeScurt, ParameterDirection.Input)
                 );
            return x;
        }

        public Curs GetCurs(int id)
        {
            throw new NotImplementedException();
        }


        public bool UpdateCurs(Curs m)
        {
            throw new NotImplementedException();
        }

        public List<Curs> GetCursuriByFacultate(int idFacultate)
        {
            throw new NotImplementedException();
        }

        public bool ValideazaExistentaCurs(Curs curs)
        {
            var dsCursuri = SqlDBHelper.ExecuteDataSet(
                $"SELECT * FROM cursuri_andm WHERE idCurs = '{curs.IdCurs}'",
                CommandType.Text);

            return dsCursuri.Tables[PRIMUL_TABEL].Rows.Count > 0 ? true : false;
        }
    }
}
