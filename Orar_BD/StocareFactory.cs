using System;
using System.Configuration;
using DataAccess;
using ModelLibraries;

namespace Orar_BD
{
    public class StocareFactory
    {
        public IStocareFactory GetTipStocare(Type tipEntitate)
        {
            var formatSalvare = ConfigurationManager.AppSettings["FormatSalvare"];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "BazaDateOracle":

                        if (tipEntitate == typeof(Facultate))
                        {
                            return new AdministrareFacultati();
                        }
                        if (tipEntitate == typeof(Grupa))
                        {
                            return new AdministrareGrupe();
                        }
                        break;

                    case "BIN":
                        //instantiere clase care realizeaza salvarea in fisier binar
                        break;
                }
            }
            return null;
        }
    }
}
