using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Aplicatii_ProblemeLab1
{

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //            Ex1 – local
    //        //Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
    //        //paralelipiped dreptunghic, va afisa volumul lui
    //        //• Google: volumul paralelipipedului dreptunghic


    //        Console.WriteLine("Introduceti cele trei dimensiuni ale paralipipedului dreptunghic ! ");



    //        Console.WriteLine("Introduceti prima dimensiune ! ");
    //        int theFrisDimension = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Introduce-ti urmatoarea dimensiune ! ");
    //        int theSecondDimension = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Introduce-ti ultima dimensiune a acesteia ! ");
    //        int theLastDimension = int.Parse(Console.ReadLine());

    //        Console.WriteLine("Rezultatul final al volumului unui paralepiped dreptunghic este : " + CalculateVolum(theFrisDimension, theSecondDimension, theLastDimension));

    //    }


    //    static int CalculateVolum(int theFirrstDimension, int theSecondDimension, int theLastDimension)

    //    {

    //        int resultingRectangularParallelepipedVolume = theFirrstDimension * theSecondDimension * theLastDimension;
    //        return resultingRectangularParallelepipedVolume;
    //    }
    //}



} // ex 1    


//*******************************************************************************************************************************************************************************************************************



// ex2


//        Ex2 – local
//    Scrieti un program care va calcula media aritmetica a trei numere citite de la
//    tastatura



//  class Program
//{
//    static void Main(string[] args)
//    {
//        TextMessageToTheUser();

//        int theFristValue, theSecondValue, theThirdValue;


//        Console.WriteLine("Introduceti o valoare citita de la tastatura ! ");
//        theFristValue = int.Parse(Console.ReadLine());

//        Console.WriteLine("Introduceti urmatoarea valoare !");
//        theSecondValue = int.Parse(Console.ReadLine());

//        Console.WriteLine("Introduceti cea dea treaia valoare citita de la tastatura !");
//        theThirdValue = int.Parse(Console.ReadLine());


//        if (theFristValue <= 0 || theSecondValue <= 0 || theThirdValue <= 0 )
//        {
//            Console.WriteLine("Valorile introduse de dumneavoastra nu pot fi 0 sau negative, incercati sa introduceti doar valori de tip intregi ! ");
//        }

//        else
//        {
//            Console.WriteLine("Rezultatul mediei aritmetice este egala cu :  " + CalculateTheArithmeticMean(theFristValue, theSecondValue, theThirdValue, arithmeticThree));
//        }
//    }


//    static void TextMessageToTheUser()
//    {
//        Console.WriteLine("VA RUGAM SA INTRODUCETI VALORILE DORITE ! ");
//    }

//    public const double arithmeticThree = 3;

//    static double CalculateTheArithmeticMean(double theFristValue, double theSecondValue, double theThirdValue, double arithmeticThree)
//    {


//        return (double)((theFristValue + theSecondValue + theThirdValue) / (double)arithmeticThree);

//    }
//}





// *******************************************************************************************************************************************************************************************************************************************
// ex3


//}


// ex3

//Ex3 – local
//Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
//tastaura
// (google: how to get the last digit of a number)

//class Program
//{
//    static void Main(string[] args)
//    {
//        DisplayTextMessage();

//        int firstNumber;

//        Console.WriteLine("Introduceti u numar intreg de la tastatura in consola !");
//        firstNumber = int.Parse(Console.ReadLine());

//        if (firstNumber <= 0)
//        {
//            Console.WriteLine("Numarul introdus de dumneavoastra nu poate fi negativ !");
//        }
//        else
//        {
//            Console.WriteLine("Ultima cifra a numarului introdus in consola este : " + CalculateTheLastDigitOfTheNumber(firstNumber));
//        }
//    }

//    static void DisplayTextMessage()
//    {
//        Console.WriteLine("Introduceti un numar dorit !");
//    }

//    static int CalculateTheLastDigitOfTheNumber(int firstNumber)
//    {
//        while(firstNumber >= 10)
//        {
//            firstNumber = firstNumber % 10;
//        }
//           return firstNumber;
//    }
//}

//*********************************************************************************************************************************************************************************************************************
// ex4

//Ex 4
//Scrieti un program care va afisa semnul unui numar citit de la tastatura
//• Daca numarul este pozitiv, va afisa “+”
//• Daca numarul este negativ, va afisa “-”
//• Daca numarul este 0, va afisa “0”


//class Program
//{
//    static void Main(string[] args)
//    {
//        TextMessegeUser();

//        Console.WriteLine("Buna, gandestete la un numar la care doreti sa il introduci la consola ! ");
//        int  number = int.Parse(Console.ReadLine());

//        Console.Write("Numarul introdus de dumneavoastra in consola are semnul : ");

//        DisplayNumberSignComparison(number);
//    }

//    static void TextMessegeUser()
//    {
//        Console.WriteLine("INTRODUCE-TI UN NUMAR DORIT IN CONSOLA ! ");
//    }

//    static void  DisplayNumberSignComparison(int number)
//    {
//        if(number > 0)
//        {
//            Console.WriteLine(" + ==>> este pozitiv ");
//        }
//        else if(number < 0)
//        {
//            Console.WriteLine(" - ==>> este negativ ");
//        }
//        else
//        {
//            Console.WriteLine(" 0 ==>> este 0");
//        }
//    }
//}
// ex 5
//******************************************************************************************************************************************************************************************

//Ex 5
//Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
//• Exemplu: citim ,9,0 Afisam: 0 9 