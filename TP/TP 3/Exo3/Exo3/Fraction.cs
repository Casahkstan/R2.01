namespace Exo3
{
    /// <summary>
    /// a fraction
    /// </summary>
    class Fraction
    {
        private int den;
        private int num;

        /// <summary>
        /// Init the fraction
        /// </summary>
        /// <param name="num">numerator (default 0)</param>
        /// <param name="den">denominator (default 1). Must not be egal to 0 !</param>
        public Fraction(int num = 0, int den = 1)
        {
            this.num = num;
            this.den = den;
            Simplify();
        }

        /// <summary>
        /// Init the fraction
        /// </summary>
        /// <param name="f">the fraction to copy</param>
        public Fraction(Fraction f)
        {
            this.num = f.num;
            this.den = f.den;
        }

        public double Value
        {
            get => (double)num / den;
        }

        /// <summary>
        /// Add another fraction
        /// </summary>
        /// <param name="f">another fraction</param>
        public void Add(Fraction f)
        {
            this.num = (this.num * f.den + f.num * this.den);
            this.den = this.den * f.den;
            Simplify();
        }

        /// <summary>
        /// Add two fractions
        /// </summary>
        /// <param name="f1">first fraction</param>
        /// <param name="f2">second fraction</param>
        /// <returns>the sum f1+f2</returns>
        public static Fraction Add(Fraction f1, Fraction f2)
        {
            Fraction f = new Fraction(f1);
            f.Add(f2);
            return f;
        }

        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   num == fraction.num &&
                   den == fraction.den;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", num, den);
        }

        private void Simplify()
        {
            if (num != 0)
            {
                int p = Pgcd(num, den);
                this.num /= p;
                this.den /= p;
            }
        }

        private static int Pgcd(int a, int b)
        {
            int p;
            if (a == 1 || b == 1)
                p = 1;
            else if (a == b)
                p = a;
            else if (a < b)
                p = Pgcd(a, b - a);
            else
                p = Pgcd(b, a - b);
            return p;
        }
    }
}