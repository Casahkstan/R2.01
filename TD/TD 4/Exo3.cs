using System.Data;

namespace R2._01.TD.TD_4;

public class Exo3
{
    public class Smartphone
    {
        private int _dataConsumption;
        private Person? _owner;

        public Smartphone(int dataConsumption)
        {
            DataConsumption = dataConsumption;
            _owner = null;
        }

        public Smartphone(Smartphone phone)
        {
            DataConsumption = phone.DataConsumption;
            _owner = null;
        }

        public Person? Owner
        {
            get => _owner;
            set => _owner = value;
        }

        public int DataConsumption
        {
            get => _dataConsumption;
            set => _dataConsumption = value;
        }

        public void Add(int kilooctet)
        {
            DataConsumption += kilooctet;
        }
    }

    public class Person
    {
        private readonly List<Smartphone> _smartphones;
        private string _name;

        public Person(string name)
        {
            _name = name;
            _smartphones = new List<Smartphone>();
        }

        public void AddSmartphone(Smartphone smartphone)
        {
            if (smartphone.Owner == null) throw new DataException("Smartphone already possessed by someone");

            _smartphones.Add(smartphone);
            smartphone.Owner = this;
        }

        public void RemoveSmartphone(Smartphone smartphone)
        {
            _smartphones.Remove(smartphone);
            smartphone.Owner = null;
        }
    }
}