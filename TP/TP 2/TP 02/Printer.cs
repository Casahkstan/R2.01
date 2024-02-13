namespace TP_02;

public class Printer
{
    private float _cost;
    private int _nbSheets;

    public Printer()
    {
        _nbSheets = 0;
        _cost = 0;
    }

    public bool IsEmpty()
    {
        return _nbSheets == 0;
    }

    public bool HasEnoughSheets(int nbCopy)
    {
        return _nbSheets >= nbCopy;
    }

    public float GetMoney()
    {
        return _cost;
    }

    public void TakeMoney()
    {
        _cost = 0;
    }

    public void LoadSheet(int sheets)
    {
        _nbSheets += sheets;
    }

    public void Print(int sheets)
    {
        int maxSheets = sheets >= _nbSheets ? _nbSheets : sheets;
        _nbSheets -= maxSheets;

        int nbSheets25C = maxSheets >= 10 ? 10 : maxSheets;
        maxSheets -= nbSheets25C;

        int nbSheets20C = maxSheets >= 20 ? 20 : maxSheets;
        maxSheets -= nbSheets20C;

        int nbSheets10C = maxSheets;

        _cost += (float)(.25 * nbSheets25C + .2 * nbSheets20C + .1 * nbSheets10C);
    }
}