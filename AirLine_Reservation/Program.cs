using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            AirlineReservation gd = new AirlineReservation();
            gd.Class();
        }
    }
    public class AirlineReservation
    {
        int[] arrayf = new int[200];
        Random rnd = new Random();
        HashSet<int> li = new HashSet<int>();
        HashSet<int> li2 = new HashSet<int>();
        string n;
        string s;
        string first;
        string last;
        public void Class()
        {
            Console.WriteLine("Welcome! Thank you for choosing AaronAirLine");
            Console.WriteLine("What class you want? F,B or E");
            for (int c = 0; c < 3; c++)
            {
                s = Console.ReadLine();
                if (s == "F")
                {
                    Console.WriteLine("Do you want pick a seat from 1 to 50?");
                    Console.WriteLine("1.Yes 2.No");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("What's your first name?");
                            first = Console.ReadLine();
                            Console.WriteLine("What's your last name");
                            last = Console.ReadLine();
                            Console.WriteLine("What's the number of the seat you want");
                            arrayf[i] = Convert.ToInt32(Console.ReadLine());
                            if (arrayf[i] >= 1 && arrayf[i] <= 50)
                            {
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: First");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 50)
                                    {
                                        Console.WriteLine("Sorry,the seat in First class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, the Seat Number:{0} is reserved. Please choose another seat", arrayf[i]);
                                }

                            }
                            else
                            {
                                Console.WriteLine("Sorry, the seat number you choose is not in First class section");
                            }
                        }
                    }
                    else if (n == "2")
                    {
                        int passanger;
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("How many passangers you have");
                            Int32.TryParse(Console.ReadLine(), out passanger);
                            for (int hh = 0; hh < passanger; hh++)
                            {
                                Console.WriteLine("What's your first name?");
                                first = Console.ReadLine();
                                Console.WriteLine("What's your last name");
                                last = Console.ReadLine();
                                arrayf[i] = rnd.Next(1, 50);
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: First");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 50)
                                    {
                                        Console.WriteLine("Sorry,the seat in First class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }

                if (s == "B")
                {
                    Console.WriteLine("Do you want pick a seat from 51 to 100?");
                    Console.WriteLine("1.Yes 2.No");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("What's your first name?");
                            first = Console.ReadLine();
                            Console.WriteLine("What's your last name");
                            last = Console.ReadLine();
                            Console.WriteLine("What's the number of the seat you want");
                            arrayf[i] = Convert.ToInt32(Console.ReadLine());
                            if (arrayf[i] >= 51 && arrayf[i] <= 100)
                            {
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: Business");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 50)
                                    {
                                        Console.WriteLine("Sorry,the seat in Business class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, the Seat Number:{0} is reserved. Please choose another seat", arrayf[i]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, the seat number you choose is not in Business class section");
                            }
                        }
                    }
                    else if (n == "2")
                    {
                        int passanger;
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("How many passangers you have");
                            Int32.TryParse(Console.ReadLine(), out passanger);
                            for (int hh = 0; hh < passanger; hh++)
                            {
                                Console.WriteLine("What's your first name?");
                                first = Console.ReadLine();
                                Console.WriteLine("What's your last name");
                                last = Console.ReadLine();
                                arrayf[i] = rnd.Next(51, 100);
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: Business");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 50)
                                    {
                                        Console.WriteLine("Sorry,the seat in Business class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
                if (s == "E")
                {
                    Console.WriteLine("Do you want pick a seat from 101 to 200?");
                    Console.WriteLine("1.Yes 2.No");
                    n = Console.ReadLine();
                    if (n == "1")
                    {
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("What's your first name?");
                            first = Console.ReadLine();
                            Console.WriteLine("What's your last name");
                            last = Console.ReadLine();
                            Console.WriteLine("What's the number of the seat you want");
                            arrayf[i] = Convert.ToInt32(Console.ReadLine());
                            if (arrayf[i] >= 101 && arrayf[i] <= 200)
                            {
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: Economic");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 100)
                                    {
                                        Console.WriteLine("Sorry,the seat in Economic class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, the Seat Number:{0} is reserved. Please choose another seat", arrayf[i]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, the seat number you choose is not in Business class section");
                            }
                        }
                    }
                    else if (n == "2")
                    {
                        int passanger;
                        for (int i = 0; i <= arrayf.Length; i++)
                        {
                            Console.WriteLine("How many passangers you have");
                            Int32.TryParse(Console.ReadLine(), out passanger);
                            for (int hh = 0; hh < passanger; hh++)
                            {
                                Console.WriteLine("What's your first name?");
                                first = Console.ReadLine();
                                Console.WriteLine("What's your last name");
                                last = Console.ReadLine();
                                arrayf[i] = rnd.Next(101, 200);
                                li.Add(arrayf[i]);
                                if (li.IsSubsetOf(li2) == false)
                                {
                                    Console.WriteLine("**************************************************");
                                    Console.WriteLine("******************/Boarding Pass/*****************");
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("  NAME:{0} {1}", first, last);
                                    Console.WriteLine("  CLASS: Economic");
                                    Console.WriteLine("  SEAT: {0}", arrayf[i]);
                                    Console.WriteLine("*             *");
                                    Console.WriteLine("               ");
                                    Console.WriteLine("***************************************************");
                                    li2.Add(arrayf[i]);
                                    if (li2.Count >= 100)
                                    {
                                        Console.WriteLine("Sorry,the seat in Economic class in full.Is that acceptable for you be placed in other section?");
                                        Console.WriteLine("1.yes 2.no");
                                        n = Console.ReadLine();
                                        if (n == "1")
                                        {
                                            Console.WriteLine("What other class you want");
                                            s = Console.ReadLine();
                                            break;
                                        }
                                        else if (n == "2")
                                        {
                                            Console.WriteLine("We're booked");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    continue;
                                }
                            }
                        }
                    }
                }
                else
                    Console.WriteLine("Sorry, it's not an option. Please Type in F,S or E to choose whether you want First class, Business class or Economic class");
                Console.WriteLine("If you type in a correct class letter but this still happen. It means our seats are full today. Please choose another Airline.");
                Console.WriteLine("Thank you for choosing AaronAirline.Enjoy your flight :)");
                break;
            }
        }
    }
}




