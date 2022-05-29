using ModelLibraries;
using System;
using System.Data;
using System.Text;

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
