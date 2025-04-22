namespace Lab05Lib;
public class Animal
{
    public string Name;
    public string Species;
    public string Color;
    public int Age;
    public double Weight;
    public bool IsWild;
    public bool CanFly;

    public double AnimalYears
    {
        get
        {
            return GetAnimalYears();
        }
    }

    public double GetAnimalYears()
    {
        return Age * 7.0;
    }
}
