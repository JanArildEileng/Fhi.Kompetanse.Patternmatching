
namespace Fhi.Kompetanse.Patternmatching.Oppgave;

public class GetAnimalNameTests
{
    PatternSwitcher patternSwitcher = new PatternSwitcher();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    //Type Pattern
    public void Test1()
    {
        Dog dog = new Dog();
        Assert.That(patternSwitcher.GetAnimalName(dog), Is.EqualTo("Dog"));        

    }
   
    [Test]
    //Type Pattern
    public void Test2()
    {
        Dog dog = new Labrador();
        Assert.That(patternSwitcher.GetAnimalName(dog), Is.EqualTo("Labrador"));        

    }


    [Test]
    //Type Pattern
    public void Test3()
    {
        Cat cat = new Cat();
        Assert.That(patternSwitcher.GetAnimalName(cat), Is.EqualTo("Cat"));
    }

    [Test]
    ////Type Pattern+Property Pattern
    public void Test4()
    {
        Cat cat = new Cat();
        cat.Color = "Blue";
        Assert.That(patternSwitcher.GetAnimalName(cat), Is.EqualTo("BlueCat"));        
    }


    [Test]
    ////Type Pattern+Property Pattern+var pattern (when)    
    public void Test5()
    {
        Cat cat = new Cat();
        cat.Color = "Blue";
        cat.Weight = 6;
        Assert.That(patternSwitcher.GetAnimalName(cat), Is.EqualTo("BigBlueCat"));        
    }
    



    [Test]
    ////Type Pattern+Property Pattern
    public void Test6()
    {
        Cat cat = new Cat();
        cat.Breed = "RussianBlue";
        Assert.That(patternSwitcher.GetAnimalName(cat), Is.EqualTo("RussianBlueCat"));        
    }

     [Test]
    ////Type Pattern+var pattern (when)
    public void Test7()
    {
        Cat cat = new Cat();
        cat.Weight = 6;
        Assert.That(patternSwitcher.GetAnimalName(cat), Is.EqualTo("BigCat"));        
    }





     [Test]
    ////NotImplementedException
    public void Test8()
    {
        Crocodile crocodile=new Crocodile();
        Assert.Throws<NotImplementedException>(() => patternSwitcher.GetAnimalName(crocodile));
    }

     [Test]
    ////NotImplementedException
    public void Test9()
    {
        Assert.Throws<NotImplementedException>(() => patternSwitcher.GetAnimalName(null));
    }
}
