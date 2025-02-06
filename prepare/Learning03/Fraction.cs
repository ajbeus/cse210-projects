using System;

class Fraction
{
    private int _topNumber;
    private int _bottomNumber;
    private string partialNumber;

    public Fraction(string totalFraction)
    {
        partialNumber = totalFraction;
    }

    public int GetTopNumber()
    {
        return _topNumber;
    }

    public void SetTopNumber(int topNumber)
    {
        _topNumber = topNumber;
    }

    public int GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetBottomNumber(int bottomNumber)
    {
        _bottomNumber = bottomNumber;
    }

    
}