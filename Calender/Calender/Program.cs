namespace Calender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter month");
                int month = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter year");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter day of the week");
                int day = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("s\tm\tt\tw\tt\tf\ts ");
                switch (month)
                {
                    case 1:
                        {
                            int jan = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= jan; j++)
                            {
                                Console.Write($"{j}\t");

                                if ((day + j) % 7 == 0)



                                {
                                    Console.WriteLine("\n");
                                }




                            }
                            break;
                        }
                    case 2:
                        {
                            if ((year % 4 == 0 && year % 100 != 0 || year % 400 == 0))
                            {
                                int feb = 29;
                                for (int i = 1; i <= day; i++)
                                {
                                    Console.Write("\t");
                                }
                                for (int j = 1; j <= feb; j++)
                                {
                                    Console.Write($"{j}\t");
                                    if ((day + j) % 7 == 0)
                                    {
                                        Console.WriteLine("\n");
                                    }



                                }
                            }
                            else
                            {
                                int feb = 28;
                                for (int i = 1; i <= day; i++)
                                {
                                    Console.Write("\t");
                                }
                                for (int j = 1; j <= feb; j++)
                                {
                                    Console.Write($"{j}\t");
                                    if ((day + j) % 7 == 0)
                                    {
                                        Console.WriteLine("\n");
                                    }



                                }
                            }
                            break;
                        }
                    case 3:
                        {
                            int march = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= march; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }



                            break;
                        }
                    case 4:
                        {
                            int april = 30;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= april; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 5:
                        {
                            int may = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= may; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 6:
                        {
                            int june = 30;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= june; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 7:
                        {
                            int july = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= july; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 8:
                        {
                            int august = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= august; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 9:
                        {
                            int sep = 30;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= sep; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 10:
                        {
                            int oct = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("/t");
                            }
                            for (int j = 1; j <= oct; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 11:
                        {
                            int nov = 30;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= nov; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }
                    case 12:
                        {
                            int dec = 31;
                            for (int i = 1; i <= day; i++)
                            {
                                Console.Write("\t");
                            }
                            for (int j = 1; j <= dec; j++)
                            {
                                Console.Write($"{j}\t");
                                if ((day + j) % 7 == 0)
                                {
                                    Console.WriteLine("\n");
                                }



                            }
                            break;
                        }



                }




            }
                
        }
    }
}
