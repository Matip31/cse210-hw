//Hello! For Exceeding Requirements, I did it so it would only hide the words that are not hidden when using the scripture.HideRandomWords().
//It checks if the word is hidden before trying, and if it's not hidden then it won't hide anything and will try again with a different word. 
using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference=new Reference("Proverbs",3,5,6);
        string scriptureText="Trust in the Lord with all thine heart and lean not unto thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture=new Scripture(reference,scriptureText);
        string input="first";
        do
        {
            Console.Clear();
            if (input != "quit" && input!="first")
            {
                scripture.HideRandomWords(3);
            }
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            input=Console.ReadLine();
        }while(input!="quit" && scripture.IsCompletelyHidden()==false);
    }
}