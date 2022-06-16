using System;

namespace NroComplejoPOO2022.Entidades
{
    public class NumeroComplejo
    {
        private int ParteEntera;
        private int ParteImaginaria;

        public NumeroComplejo(int parteEntera, int parteImaginaria)
        {
            ParteEntera = parteEntera;
            ParteImaginaria = parteImaginaria;
        }

        public NumeroComplejo(int parteEntera) : this(parteEntera, 0)
        {

        }

        public override string ToString()
        {
            if (ParteEntera == 0)
            {
                return $"{ParteImaginaria}i";
            }
            if (ParteImaginaria < 0)
            {
                return $"{ParteEntera}{ParteImaginaria}i";
            }
            return $"{ParteEntera}+{ParteImaginaria}i";
        }

        public override bool Equals(object obj)
        {
            if (obj==null || !(obj is NumeroComplejo))
            {
                return false;
            }

            return this.ParteEntera == ((NumeroComplejo) obj).ParteEntera &&
                   this.ParteImaginaria == ((NumeroComplejo) obj).ParteImaginaria;
        }

        public static bool operator ==(NumeroComplejo c1, NumeroComplejo c2)
        {
            return c1.Equals(c2);
        }

        public static bool operator !=(NumeroComplejo c1, NumeroComplejo c2)
        {
            return !(c1 == c2);
        }

        public static NumeroComplejo operator +(NumeroComplejo c1, NumeroComplejo c2)
        {
            return new NumeroComplejo(c1.ParteEntera+c2.ParteEntera, c1.ParteImaginaria+c2.ParteImaginaria);
        }

        public static NumeroComplejo operator -(NumeroComplejo c1, NumeroComplejo c2)
        {
            var pEntera = c1.ParteEntera - c2.ParteEntera;
            var pImaginaria = c1.ParteImaginaria - c2.ParteImaginaria;
            return new NumeroComplejo(pEntera,pImaginaria);
        }

        public static NumeroComplejo operator *(NumeroComplejo c1, NumeroComplejo c2)
        {
            var pEntera = c1.ParteEntera * c2.ParteEntera - (c1.ParteImaginaria * c2.ParteImaginaria);
            var pImaginaria = c1.ParteEntera * c2.ParteImaginaria + (c1.ParteImaginaria * c2.ParteEntera);
            return new NumeroComplejo(pEntera, pImaginaria);
        }

        public static NumeroComplejo operator +(NumeroComplejo c1, int n)
        {
            return new NumeroComplejo(c1.ParteEntera+n,c1.ParteImaginaria);
        }

        public static implicit operator NumeroComplejo(string s)
        {
            var signo = s.Contains('+') ? '+' : '-';
            var array = s.Split(signo);

            var parteEntera = int.Parse(array[0]);
            var parteImaginaria =int.Parse(array[1].ToString().Replace('i', ' ').Trim());
            return signo=='-' ? new NumeroComplejo(parteEntera,-parteImaginaria) : new NumeroComplejo(parteEntera,parteImaginaria);
        }

    }
}
