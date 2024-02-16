namespace R2._01.TD.TD_2;

public class Exo_1
{
    public class Currency
    {
        private int _cents;

        public Currency(int value)
        {
            Cents = value * 100;
        }

        public Currency(double value)
        {
            Cents = (int)value * 100;
        }

        public Currency(Currency value)
        {
            Cents = value.Cents;
        }

        public int Cents
        {
            get => _cents;
            set => _cents = value;
        }

        public void Add(Currency value)
        {
            Cents += Cents + value.Cents;
        }

        public static Currency Add(Currency c1, Currency c2)
        {
            c1.Cents += c2.Cents;
            return c1;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not Currency) return false;
            Currency c = obj as Currency;
            return Cents == c.Cents;
        }

        public bool IsLessThan(Currency c)
        {
            return Cents < c.Cents;
        }

        public override string ToString()
        {
            return Cents.ToString();
        }
    }
}