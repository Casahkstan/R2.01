namespace TP_4;

class Test
{
    private static int compteur = 0;

    private int val = 0;

    public Test()
    {
        ++compteur;
    }

    public Test(Test t)
    {
        Val = t.Val;
        ++compteur;
    }

    public int Val
    {
        get => val;
        set => val = value;
    }

    ~Test()
    {
        --compteur;
    }

    public static int Combien()
    {
        return compteur;
    }

    protected bool Equals(Test other)
    {
        return val == other.val;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Test)obj);
    }

    public override int GetHashCode()
    {
        return val;
    }
}