
namespace Fhi.Kompetanse.Patternmatching.Oppgave;

abstract class Animal
{
}


internal class Dog : Animal
{
    public string? Breed { get;  set; }
}

internal class Labrador : Dog
{
    public Labrador()
    {
         Breed="Labrador";
    }
}

internal class Cat : Animal
{
    public string Color { get; internal set; }
    public string Breed { get; internal set; }
    public int Weight { get; set; } = 4;

    public bool IsBigCat()
    {
        return Weight > 4;
    }
}

internal class Crocodile : Animal
{
}
