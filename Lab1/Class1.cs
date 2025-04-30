using System;
class RightTriangle
{
    // pola klasy przechowujace dlugosci przyprostokatnych
    private double a;
    private double b;


    // wlasciwosci klasy odpowiadajace powyzszym polom
    public double A
    {
        get { return a; } // prosty getter - tylko zwraca wartosc
        set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
        {
            if (value > 0) a = value; // prosze zwrocic uwage na slowo kluczowe value
        }
    }
    public double B
    {
        get { return b; } // prosty getter - tylko zwraca wartosc
        set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
        {
            if (value > 0) b = value;
        }
    }
    public double Circumference
    {
        get { return a + b + ComputeC(); }
    }
    public string Color
    {
            get;
            set;
    }
    private double ComputeC()
    {
        return Math.Sqrt(Math.Pow(A, 2) + Math.Pow(B, 2));

    }
    public double ComputeSine()
    {
        return A / ComputeC();    
    }
    // metoda klasy obliczajaca tangens kata w trojkacie A/B
    // zwyczajowa kolejnosc podawania elementow klasy: pola, własciwosci, metody
    public double ComputeTangent()
    {
        return A / B;
    }
}