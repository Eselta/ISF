using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ISeeFutsal
{
    public class Spiller
    {
        public String Navn;
        public String Nummer;
        public String Alder;
        public Fod Fod;
        public Vurdering Fysisk;
        public Vurdering Psykisk;
        public Vurdering Teknisk;
        public Vurdering Taktisk;

        Spiller(String navn, String nummer, String alder, Fod fod, Vurdering fys, Vurdering psyk, Vurdering tek, Vurdering tak)
        {
            Navn = navn;
            Nummer = nummer;
            Alder = alder;
            Fod = fod;
            Fysisk = fys;
            Psykisk = psyk;
            Teknisk = tek;
            Taktisk = tak;
        }

    }

    public enum Fod
    {
        Højre,
        Venstre,
        Ambi
    }

    public enum Vurdering
    {
        Dårlig = 1,
        Under = 2,
        Middel = 3,
        Over = 4,
        God = 5
    }

}