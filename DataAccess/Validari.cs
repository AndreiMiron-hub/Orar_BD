using ModelLibraries;
using System;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace DataAccess
{
    public class Validari
    {
       
        public static ExitString ValideazaDenumireFacultate(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new ExitString(null, "Campul nu trebuie sa fie gol");

            str = str.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                if (Char.IsDigit(str[i]) && i != str.Length - 1)
                    return new ExitString(null, "Campul introdus are cifre introduse gresit");
            }

            string caractereSpeciale;
            if (SpecialChars(str, out caractereSpeciale))
                return new ExitString(null, $"Campul introdus nu trebuie sa contina caractere speciale: {caractereSpeciale}");

            return new ExitString(str.ToUpper(), "Succes");
        }


        public static ExitString ValideazaInterval(string str1, string str2)
        {
            if (string.IsNullOrEmpty(str1))
                return new ExitString(null, "Campul nu trebuie sa fie gol");
            if (string.IsNullOrEmpty(str2))
                return new ExitString(null, "Campul nu trebuie sa fie gol");
            
            str1 = str1.Trim();
            str2 = str2.Trim();

            if (!IsValidTime(str1))
                return new ExitString(null, "Ora de start trebuie sa fie in format HH:MM");

            if (!IsValidTime(str2))
                return new ExitString(null, "Ora de sfarsit trebuie sa fie in format HH:MM");



            return new ExitString(str1.ToUpper() + " : " + str2.ToUpper(), "Succes");
        }

        static public bool IsValidTime(string thetime)
        {
            Regex checktime =
             new Regex(@"^(([0-1][0-9])|([2][0-3])):([0-5][0-9])");

            return checktime.IsMatch(thetime);
        }

        public static ExitString ValideazaNumarGrupa(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new ExitString(null, "Campul nu trebuie sa fie gol");

            str = str.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]) && i != str.Length - 1)
                    return new ExitString(null, "Campul introdus are litere introduse gresit");
            }

            string caractereSpeciale;
            if (SpecialChars(str, out caractereSpeciale))
                return new ExitString(null, $"Campul introdus nu trebuie sa contina caractere speciale: {caractereSpeciale}");

            return new ExitString(str.ToUpper(), "Succes");
        }

        public static ExitString ValideazaNumarStudenti(string str)
        {
            if (string.IsNullOrEmpty(str))
                return new ExitString(null, "Campul nu trebuie sa fie gol");

            str = str.Trim();

            for (int i = 0; i < str.Length; i++)
            {
                if (!Char.IsDigit(str[i]) && i != str.Length - 1)
                    return new ExitString(null, "Campul introdus are litere introduse gresit");
            }

            if(int.Parse(str) > 30)
            {
                return new ExitString(null, "Numarul de studenti este prea mare. Introduceti un numar mai mic de 30.");
            }

            string caractereSpeciale;
            if (SpecialChars(str, out caractereSpeciale))
                return new ExitString(null, $"Campul introdus nu trebuie sa contina caractere speciale: {caractereSpeciale}");

            return new ExitString(str.ToUpper(), "Succes");
        }
      


        /// <summary>
        /// Forma de raspuns dupa validare -> {Text, MesajEroare}
        /// </summary>
        public struct ExitString
        {
            public string Text { get; }
            public string Mesaj { get; }

            public ExitString(string str, string msj)
            {
                Text = str;
                Mesaj = msj;
            }

            public override string ToString()
            {
                return $"{Mesaj} : {Text}";
            }
        }

        public static bool SpecialChars(string str, out string caractere)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string caractereSpeciale = "!@#$%^&*()_=+/\\<>?;:'";

            foreach (char caracterSpecial in caractereSpeciale)
            {
                if (str.IndexOf(caracterSpecial) != -1)
                    stringBuilder.Append(caracterSpecial);
            }
            caractere = stringBuilder.ToString();
            return stringBuilder.Length > 0 ? true : false;
        }

       

    }
}
