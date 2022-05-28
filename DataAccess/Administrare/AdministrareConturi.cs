using ModelLibraries;
using System.Data;

namespace DataAccess
{
    public class AdministrareConturi : IStocareConturi
    {
        private const int PRIMUL_TABEL = 0;
        public bool CheckCont(string numeUtilizator, string parola)
        {
            var dsConturi = SqlDBHelper.ExecuteDataSet("select  * from conturi_andm where numeUtilizator = 'admin' AND parola = '1234'", CommandType.Text);

            foreach (DataRow linieBD in dsConturi.Tables[PRIMUL_TABEL].Rows)
            {
                Cont cont = new Cont(linieBD);

                if (cont.NumeUtilizator == numeUtilizator && cont.Parola == parola)
                    return true;
            }
            return false;
        }
    }
}
