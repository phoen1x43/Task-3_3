using System;

namespace Task3_3;

public interface IParentArray : IPrinter
{
    public void RndFill();
    public void FillByUser();
    public double CalculateAverage();

    public void Print();
}