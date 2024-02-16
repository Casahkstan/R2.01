namespace R2._01.TD.TD_2;

public class Exo_2
{
    public static int Pgcd(int a, int b)
    {
        if (a % b == 0) return b;
        return Pgcd(b, a % b);
    }

    public static int Ppcm(int a, int b)
    {
        return (a * b) / Pgcd(a, b);
    }

    public class Fraction
    {
        private int _den;
        private int _num;

        public Fraction()
        {
            Num = 0;
            Den = 1;
        }

        public Fraction(int num)
        {
            Num = num;
            Den = 1;
        }

        public Fraction(int num, int den)
        {
            Num = num;
            Den = den;
        }

        public Fraction(Fraction frac)
        {
            Num = frac.Num;
            Den = frac.Den;
        }

        public int Num
        {
            get => _num;
            set => _num = value;
        }

        public int Den
        {
            get => _den;
            set => _den = value;
        }

        public void Add(Fraction frac)
        {
            int ppcm = Ppcm(Den, frac.Den);
            Num = Num * (ppcm / Den) + frac.Num * (ppcm / frac.Den);
            Den = ppcm;
        }

        public static Fraction Add(Fraction frac1, Fraction frac2)
        {
            int ppcm = Ppcm(frac1.Den, frac2.Den);
            return new Fraction(frac1.Num * (ppcm / frac1.Den) + frac2.Num * (ppcm / frac2.Den), ppcm);
        }

        public void Mutliply(Fraction frac)
        {
            Num *= frac.Num;
            Den *= frac.Den;
        }

        public static Fraction Multiply(Fraction frac1, Fraction frac2)
        {
            return new Fraction(frac1.Num * frac2.Num, frac1.Den * frac2.Den);
        }

        public override string ToString()
        {
            return $"{Num}/{Den}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Fraction) return false;

            Fraction f = (obj as Fraction)!;
            return Num == f.Num && Den == f.Den;
        }

        public bool IsLessThan(Fraction f)
        {
            return Num == f.Num && Den == f.Den;
        }
    }
}