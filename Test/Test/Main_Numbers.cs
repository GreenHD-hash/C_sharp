using System;
namespace Test
{
    public class TestClass
    {
        int myNum = 5;               // Integer (whole number)
        double myDoubleNum = 5.99;  // Floating point number
        char myLetter = 'D';         // Character
        bool myBool = true;          // Boolean
        string myText = "Hello";     // String


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Was willst du?");
            Console.WriteLine("Nummber; Willkommen; Operatoren; Cel_in_F; Heizölrechnung; Waehrung; bild_groeße");
            string text = Console.ReadLine();
            if(text == "Nummber")
            {
                TestClass myTest = new TestClass();
                double sum = myTest.myNum + myTest.myDoubleNum;
                Console.WriteLine(sum);
            }
            else if(text == "Willkommen")
            {
                EmptyClass Willkommen = new EmptyClass();
                
            }
            else if(text == "Operatoren")
            {
                Operatoren myOperatoren = new Operatoren();
            }
            else if(text == "Cel_in_F")
            {
                Cel_in_F myCel_in_F = new Cel_in_F();
            }
            else if(text == "Heizölrechnung")
            {
                Heizölrechnung myHeizölrechnung = new Heizölrechnung();
            }
            else if(text == "Waehrung")
            {
                Waehrung myWaehrung = new Waehrung();
            }
            else if(text == "Waehrung_Live")
            {
                Waehrung_Live myWaehrung_Live = new Waehrung_Live();
            }
            else if(text == "bild_groeße")
            {
                bild_groeße myBild = new bild_groeße();
            }
            else
            {
                Console.WriteLine("Unbekannter Befehl");
            }
        }
    }
}

