namespace R2._01.TD.TD_4;

public class Exo2
{
    public class Instrument
    {
        private string _name;

        public Instrument(string name)
        {
            _name = name;
        }

        public string Name => _name;
    }

    public class Musician
    {
        private Instrument _instrument;

        public Musician()
        {
            Instrument = new Instrument("");
        }

        public Musician(Instrument instrument)
        {
            Instrument = instrument;
        }

        public Instrument Instrument
        {
            get => _instrument;
            set => _instrument = value;
        }
    }

    public class Orchestra
    {
        private List<Musician> _musicians;

        public Orchestra()
        {
            _musicians = new List<Musician>();
        }

        public List<Musician> Musicians => _musicians;

        public void Add(Musician musician)
        {
            _musicians.Add(musician);
        }

        public int GetSize()
        {
            return Musicians.Count;
        }

        public Instrument GetInstrument(Musician musician)
        {
            return musician.Instrument;
        }
    }
}