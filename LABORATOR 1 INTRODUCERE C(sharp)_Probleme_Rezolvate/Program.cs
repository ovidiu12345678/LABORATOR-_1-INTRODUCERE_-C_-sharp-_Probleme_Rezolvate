using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace Aplicatii_ProblemeLab1
{

    class Program
    {
        static void Main(string[] args)
       {
           //            Ex1 – local
    //        //Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
    //        //paralelipiped dreptunghic, va afisa volumul lui
    //        //• Google: volumul paralelipipedului dreptunghic


            Console.WriteLine("Introduceti cele trei dimensiuni ale paralipipedului dreptunghic ! ");



            Console.WriteLine("Introduceti prima dimensiune ! ");
            int theFrisDimension = int.Parse(Console.ReadLine());

           Console.WriteLine("Introduce-ti urmatoarea dimensiune ! ");
           int theSecondDimension = int.Parse(Console.ReadLine());

           Console.WriteLine("Introduce-ti ultima dimensiune a acesteia ! ");
    //     int theLastDimension = int.Parse(Console.ReadLine());

           Console.WriteLine("Rezultatul final al volumului unui paralepiped dreptunghic este : " + CalculateVolum(theFrisDimension, theSecondDimension, theLastDimension));

       }


        static int CalculateVolum(int theFirrstDimension, int theSecondDimension, int theLastDimension)

       {

            int resultingRectangularParallelepipedVolume = theFirrstDimension * theSecondDimension * theLastDimension;
            return resultingRectangularParallelepipedVolume;
       }
    }



} // ex 1    


//*******************************************************************************************************************************************************************************************************************



// ex2


//        Ex2 – local
//    Scrieti un program care va calcula media aritmetica a trei numere citite de la
//    tastatura



  class Program
{
   static void Main(string[] args)
   {
        TextMessageToTheUser();

       int theFristValue, theSecondValue, theThirdValue;


       Console.WriteLine("Introduceti o valoare citita de la tastatura ! ");
       theFristValue = int.Parse(Console.ReadLine());
       
       Console.WriteLine("Introduceti urmatoarea valoare !");
       theSecondValue = int.Parse(Console.ReadLine());

       Console.WriteLine("Introduceti cea dea treaia valoare citita de la tastatura !");
       theThirdValue = int.Parse(Console.ReadLine());


        if (theFristValue <= 0 || theSecondValue <= 0 || theThirdValue <= 0 )
        {
            Console.WriteLine("Valorile introduse de dumneavoastra nu pot fi 0 sau negative, incercati sa introduceti doar valori de tip intregi ! ");
        }

        else
        {
           Console.WriteLine("Rezultatul mediei aritmetice este egala cu :  " + CalculateTheArithmeticMean(theFristValue, theSecondValue, theThirdValue, arithmeticThree));
        }
    }


    static void TextMessageToTheUser()
    {
        Console.WriteLine("VA RUGAM SA INTRODUCETI VALORILE DORITE ! ");
   }

    public const double arithmeticThree = 3;
      
    static double CalculateTheArithmeticMean(double theFristValue, double theSecondValue, double theThirdValue, double arithmeticThree)
    {


        return (double)((theFristValue + theSecondValue + theThirdValue) / (double)arithmeticThree);

    }
}





// *******************************************************************************************************************************************************************************************************************************************
// ex3


//}


// ex3

//Ex3 – local
//Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
//tastaura
// (google: how to get the last digit of a number)

class Program
{
    static void Main(string[] args)
    {
        DisplayTextMessage();

        int firstNumber;

        Console.WriteLine("Introduceti u numar intreg de la tastatura in consola !");
        firstNumber = int.Parse(Console.ReadLine());

        if (firstNumber <= 0)
        {
           Console.WriteLine("Numarul introdus de dumneavoastra nu poate fi negativ !");
        }
        else
        {
            Console.WriteLine("Ultima cifra a numarului introdus in consola este : " + CalculateTheLastDigitOfTheNumber(firstNumber));
        }
    }

    static void DisplayTextMessage()
    {
        Console.WriteLine("Introduceti un numar dorit !");
    }

    static int CalculateTheLastDigitOfTheNumber(int firstNumber)
    {
        while(firstNumber >= 10)
        {
            firstNumber = firstNumber % 10;
        }
           return firstNumber;
    }
}

//*********************************************************************************************************************************************************************************************************************
// ex4

//Ex 4
//Scrieti un program care va afisa semnul unui numar citit de la tastatura
//• Daca numarul este pozitiv, va afisa “+”
//• Daca numarul este negativ, va afisa “-”
//• Daca numarul este 0, va afisa “0”


class Program
{
    static void Main(string[] args)
    {
        TextMessegeUser();

        Console.WriteLine("Buna, gandestete la un numar la care doreti sa il introduci la consola ! ");
        int  number = int.Parse(Console.ReadLine());

        Console.Write("Numarul introdus de dumneavoastra in consola are semnul : ");

        DisplayNumberSignComparison(number);
    }

    static void TextMessegeUser()
    {
        Console.WriteLine("INTRODUCE-TI UN NUMAR DORIT IN CONSOLA ! ");
    }

    static void  DisplayNumberSignComparison(int number)
    {
        if(number > 0)
        {
            Console.WriteLine(" + ==>> este pozitiv ");
        }
        else if(number < 0)
        {
            Console.WriteLine(" - ==>> este negativ ");
        }
        else
        {
            Console.WriteLine(" 0 ==>> este 0");
        }
    }
}
// ex 5
//******************************************************************************************************************************************************************************************


    //ex 5
    //* *****************************************************************************************************************************************************************************************

    //    //Ex 5
    //    //Se citesc doua numere de la tastatura, x, y. Scrieti un program care va afisa cele doua valori in ordine crescatoare.
    //    //• Exemplu: citim ,9,0 Afisam: 0 9 

       class Program
        {
            static void Main(string[] args)
            {
                int firstDight, secondDight;

               UserMessageText();

                Console.WriteLine("Introduce-ti prima cifra dorita !");
                firstDight = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti ultima cifra dorita !");
                secondDight = int.Parse(Console.ReadLine());

                Console.WriteLine("Numerele alese de dumneavoastra sunt ordonate crescator astfel : {firstDight, secondDight}= ");

                BreederOrders(firstDight, secondDight);
            }

            static void UserMessageText()
            {
                Console.WriteLine("Buna, va rugam sa introduceti cifrele dorite pentru a ordona crescator !");
            }

           static void BreederOrders(int firstDight, int secodDight)
            {
                int order = firstDight;

                if(order > secodDight)
                {
                    Console.WriteLine(secodDight);
                    Console.WriteLine(order);
                }
                else
                {
                    Console.WriteLine(order);
                    Console.WriteLine(secodDight);
                }
            }
        }

    //**************************************************************************************************************************************************************

    //    Ex7
    //  Scrieti un program care va verifica daca un numar citit de la tastatura este par sau
    //  impar
    // In cazul in care numarul este par, programul va afisa “par” iar in caz contrar, “impar”.
    // Google :even and odd number

}

class Program
{
    static void Main(string[] args)
    {
        // Se citesc trei numere de la tastatura, x,y,z. Scrieti un program care va afisa cele trei valori in ordine descrescatoare.

        Console.WriteLine("Introduceti primul numar");
        int firstValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar");
        int secondValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al treilea numar");
        int lastValue = int.Parse(Console.ReadLine());

        Console.WriteLine("Numerele ordonate");
        if (firstValue > secondValue)
        {
            if (lastValue > firstValue)
            {
                
                Console.WriteLine(lastValue);
                Console.WriteLine(firstValue);
                Console.WriteLine(secondValue);
            }
            else if (secondValue > lastValue)
            {
                
                Console.WriteLine(firstValue);
                Console.WriteLine(secondValue);
                Console.WriteLine(lastValue);
            }
            else
            {
                
                Console.WriteLine(firstValue);
                Console.WriteLine(lastValue);
                Console.WriteLine(secondValue);
            }
        }
        else
        {
            if (lastValue > secondValue)
            {
                
                Console.WriteLine(lastValue);
                Console.WriteLine(secondValue);
                Console.WriteLine(firstValue);
            }
            else if (firstValue > lastValue)
            {
                
                Console.WriteLine(secondValue);
                Console.WriteLine(firstValue);
                Console.WriteLine(lastValue);
            }
            else
            {
                
                Console.WriteLine(secondValue);
                Console.WriteLine(lastValue);
                Console.WriteLine(firstValue);
            }
        }
    }
    static void ex7()
    {
        // Scrieti un program care va verifica daca un numar citit de la tastatura este par sau impar

        Console.WriteLine("Introduceti numarul ");
        int numar = int.Parse(Console.ReadLine());

        if (numar % 2 == 0)
        {
            Console.WriteLine("par");

        }
        else
        {
            Console.WriteLine("impar");
        }
    }
    static void Ex8()
    {
        // Se citesc doua numere de la tastatura, x si y. Scrieti un program care va verifica daca x este divizibil cu y.

        Console.WriteLine("Introduceti primul numar");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Introduceti al doilea numar");
        int secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber % secondNumber == 0)
        {
            Console.WriteLine("Divizibile");
        }
        else
        {
            Console.WriteLine("indivizibile");

        }
    }
    static void Ex9()
    {
        // aici vom pune rezolvarea pentru exercitiu 9
    }
    static void Ex10()
    {
        //  Scrieti un program care sa va afisa suma cifrelor ununi numar intreg citit de la tastatura.
        Console.WriteLine("Introduceti primul numar");
        int number = int.Parse(Console.ReadLine());

        int sumaCifrelor = number / 10 + number % 10;

        Console.WriteLine("suma cifrelor este " + sumaCifrelor);
    }
}
