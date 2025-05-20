
namespace Fhi.Kompetanse.Patternmatching.Oppgave;

internal class PatternSwitcher
{
    internal string GetAnimalName(Animal animal)
    {
        //NO IF!
        return animal switch 
        {
            Labrador dog => "Labrador",             
            Dog dog => "Dog",

            Cat cat and {Color:"Blue" }  when cat.IsBigCat()=>"BigBlueCat",
            Cat cat and {Color:"Blue" } =>"BlueCat",
          
            Cat cat and {Breed:"RussianBlue" }=>"RussianBlueCat",
            Cat cat when cat.IsBigCat()  => "BigCat",
         
            Cat cat => "Cat",
            _ => throw new NotImplementedException()      
        };  
    }

}
