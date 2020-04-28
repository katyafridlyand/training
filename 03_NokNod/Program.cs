using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Type number A: ");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Type number B: ");
            int B = Convert.ToInt32(Console.ReadLine());

            int numberA = A;
            int numberB = B;

            int NOK = 1;
            /*int NOD = 0;

            int aNod = 0;
            int bNod = 0;

            // NOD

            for (int i = 1; i<=A; i++)
            {
              aNod =  A % i;
              bNod =  B % i;

               if (aNod == 0 && bNod == 0)
                {
                    NOD = i;
                }
              //  Console.WriteLine($"number a1 {A} and number b1 {B} - i: {i} and NOD: {NOD}");
            }*/

            //NOK
            if (A >= 2 || B >= 2)
            {
                    string AResultLineForNok="";
                    string BResultLineForNok="";

                
                for (int y = 2; (numberA > numberB && y <= numberA) || (numberA < numberB && y <= numberB); y++)
                {   
                    int aNok = A % y;
                    int bNok = B % y;

                    while (aNok == 0)
                    {
                        AResultLineForNok += y;
                        A = A / y;
                        aNok = A % y;
                    }
                    while (bNok==0)
                    { 
                        BResultLineForNok += y;
                        B = B / y;
                        bNok = B % y;
                    }
                }

                Console.WriteLine($"Anok: {AResultLineForNok} and BNok:{BResultLineForNok}");

                if (AResultLineForNok.Length > BResultLineForNok.Length)
                {
                    bool[] massivNOK = new bool[BResultLineForNok.Length];

                    foreach (var numberInA in AResultLineForNok)
                    {
                        int intNumberForA = Convert.ToInt32(new string(numberInA, 1));

                       foreach (var numberInB in BResultLineForNok)
                       {
                            int intNumberForB = Convert.ToInt32(new string(numberInB, 1));
                            int indexNok = 0;

                            if (intNumberForA==intNumberForB && massivNOK[indexNok]!=true)
                            {
                                NOK = NOK * intNumberForB;
                                massivNOK[indexNok] = true;
                                break;
                            }
                            else
                            {
                                NOK = NOK * intNumberForA;
                                break;
                            }
                          //  indexNok++;
                       }
                    }
                }
                else
                {
                    bool[] massivNOK = new bool[AResultLineForNok.Length];

                    foreach (var numberInB in BResultLineForNok)
                    {
                        int intNumberForB = Convert.ToInt32(new string(numberInB, 1));

                       // for (int k = 0; k < AResultLineForNok.Length; k++)
                        foreach (var numberInA in AResultLineForNok)
                        {
                            int intNumberForA = Convert.ToInt32(new string(numberInA, 1));
                            int indexNok = 0;

                            if (intNumberForB == intNumberForA && massivNOK[indexNok] != true)
                            {
                                NOK = NOK * intNumberForA;
                                massivNOK[indexNok] = true;
                                break;
                            }
                            if (intNumberForB!=intNumberForA && massivNOK[indexNok] != true)
                            {
                                NOK = NOK * intNumberForB;
                                break;
                            }
                            indexNok++;
                        }
                    }
                }
            }
            Console.WriteLine($"NOK: {NOK}");
            Console.ReadKey();
            //Console.WriteLine($"For number A {A} and number B {B} - NOK: {NOK} and NOD: {NOD}");
        }
    }
}