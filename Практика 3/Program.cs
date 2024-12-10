using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Практика_3
{
    internal class Program
    {

        static void Task1()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            bool isAscending = true;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] <= input[i - 1])
                {
                    isAscending = false;
                    break;
                }
            }
            if (isAscending)
            {
                Console.WriteLine("Цифры числа расположены по возрастанию.");
            }
            else
            {
                Console.WriteLine("Цифры числа не расположены по возрастанию.");
            }
        }

        static void Task2()
        {
            object[] arr = { 1, ' ', 2, 3, ' ', 5 };
            
            object[] filteredArr = arr.Where(x => x.ToString() != " ").ToArray();
            
            Console.WriteLine(string.Join(", ", filteredArr));
        }

        static void Task3()
        {
            for (int i = 10; i <= 1000; i++)
            {
               
                string numberString = i.ToString();
                
                if (numberString.Length >= 2)
                {
                   
                    int secondToLastDigit = int.Parse(numberString[numberString.Length - 2].ToString());
                  
                    if (secondToLastDigit % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }

        static void Task4()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            arr = arr.Where((value, index) => (index + 1) % 5 != 0).ToArray();
            
            Console.WriteLine(string.Join(", ", arr));

        }

        static void Task5()
        {
            string[] arr = { "work", "I", "good", "IBM" };

            arr = arr.Where(value => value.Length<=3).ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Task6()
        {
            for (int i = 10; i <= 1000; i++)
            {

                string numberString = i.ToString();
               
                int number = int.Parse(numberString[0].ToString());
                if (number % 2 == 0)
                {
                    Console.WriteLine(i);

                }
            }

        }

        static void Task7()
        {
            string text = "What a beautiful day. It's absolutely amazing!";
            string[] arr = { };
            int w = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    if (text[i+1]=='a'||text[i+1]=='A')
                    {
                        w++;
                        Array.Resize(ref arr, w);
                        string q = "";
                        for(int j = i+1; j < text.Length; j++)
                        {
                            q += text[j];
                            if (text[j]==' ')
                            {
                                break;
                            }
                        }
                        arr[arr.Length-1] = q;
                        
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        static void Task8()
        {
            int x = 175629854;
            string nstr = x.ToString();
            for (int i = 0; i < nstr.Length; i++)
            {
                int strn = int.Parse(nstr[i].ToString());
                if (strn%2 == 0)
                {
                    Console.Write(strn);
                }

            }
            Console.WriteLine();
        }

        static void Task9()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            arr = arr.Where(x => x % 5 == 0).ToArray();
            Console.WriteLine(string.Join(", ", arr));

        }

        static void Task10()
        {
            int[] arr = { 1, 20, 3, 4, 500, 6, 7, 0, 9, 10, 11, 12, 13 };
            arr = arr.Where(x=>x%10 == 0|| x==0).ToArray();
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Task11()
        {
            int[] arr = { 1, 20, 3, 4, 500, 6, 7, 0, 9, 10, 11, 12, 13 };
            bool is3 = false;
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i].ToString();
                for (int j = 0; j < s.Length; j++)
                {
                    int n = int.Parse(s[j].ToString());
                    if (n % 3 == 0)
                    {
                        Console.WriteLine("Здесь есть число, содержащее цифру 3");
                        is3 = true;
                        break;
                    }
                    if (is3==true)
                    {
                        break;
                    }
                }
                if (is3 == true)
                {
                    break;
                }
            }
            if (is3 == false)
            {
                Console.WriteLine("Здесь нет числа, содержащего цифру 3");
            }
        }

        static void Task12()
        {
            int[] arr = { 1, 20, 3, 4, 5000, 6, 7, 302000, 9, 10, 11, 12, 13 };
            arr = arr.Where(x=>x<1000&&x>-1000).ToArray();
            Console.WriteLine(String.Join(", ", arr));
        }

        static void Task13()
        {
            string text = "What a beautiful day. It's absolutely amazing!";
            
            string[] words = text.Split(new char[] { ' ', '.', '!' }, StringSplitOptions.RemoveEmptyEntries);
           
            Array.Sort(words);
            
            string sortedText = string.Join(" ", words);
           
            Console.WriteLine(sortedText);
        }

        static void Task14()
        {
            int num = 32;
            int[] arr = { };
            int q = 0;  
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    q++;
                    Array.Resize(ref arr, q);
                    arr[arr.Length - 1] = i;
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }

        static void Task15()
        {
            int num1 = 120;
            int num2 = 80;
            int[] arr = { };
            int q = 0;
            int x = 1;
            if (num1 > num2)
            {
                x = num1;
            }
            else if (num1 < num2)
            {

                x = num2;
            }
            else
            {
                x = num1;
            }
            for (int i = 1; i < x; i++)
            {
                if ((num1 % i) == 0 && (num2%i)==0)
                {
                    q++;
                    Array.Resize(ref arr, q);
                    arr[arr.Length - 1] = i;
                }
            }
            Console.WriteLine(String.Join(", ", arr));
        }

        static void Task16()
        {
            int num = 4;
            int q = 0;
            for (int i = 1; i < num; i++)
            {
                if(i!=1 && i!=num && (num%i) == 0)
                {
                    q++;
                }
            }
            if (q == 1)
            {
                Console.WriteLine("У этого числа только один делитель кроме него самого и 1");
            }
            else if(q==0)
            {
                Console.WriteLine("Это простое число");
            }
            else
            {
                Console.WriteLine("2 и более делителя");
            }

        }

        static void Task17()
        {
            string numbersString = "13, 56, 43, 1";
            string[] numbers = numbersString.Split(',');
           
            int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
         
            int maxNumber = intNumbers.Max();
          
            Console.WriteLine("Maximum number: " + maxNumber);

        }

        static void Task18()
        {
            int[] arr = { 1, 56, 7, 8};
            int[] newArr = new int[arr.Length * 2];
            int newIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0 && arr[i] <= 9)
                {
                    newArr[newIndex] = arr[i];
                    newIndex++;
                    newArr[newIndex] = arr[i];
                    newIndex++;
                }
                else
                {
                    newArr[newIndex] = arr[i];
                    newIndex++;
                }
            }
            Array.Resize(ref newArr, newArr.Length-1);
            Console.WriteLine(string.Join(", ", newArr));
        }

        static void Task19()
        {
            string a = "Accept";
            string g = "qwrtypsdfghjklzxcvbnm";
            string res = "";
            for (int i = 0; i< a.Length; i++)
            {
                for (int j = 0; j < g.Length; j++)
                {
                    if (a[i] == g[j])
                    {
                        res += a[i];
                    }
                }
            }
            Console.WriteLine(res);
        }

        static void Task20()
        {
            string text = "what a beautiful day";
            string[] words = text.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, words[i].Length - 1) + char.ToUpper(words[i][words[i].Length - 1]);
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }

        static void Task21()
        {
            int[] arr = { 1, 311, 3, 43};
           
            int q = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                string s = arr[i].ToString();
                for (int j = 0; j < s.Length; j++)
                {
                    int n = int.Parse(s[j].ToString());
                    if (n % 3 == 0)
                    {
                       
                        q++;
                        break;
                    }
                   
                }
                if (q == arr.Length)
                {
                    Console.WriteLine("Все числа массива содержат цифру 3");
                }
                else
                {
                    Console.WriteLine("Не все числа массива содержат цифру 3");
                }
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Menu:\n" +
                    "Выберите задачу, решение которой хотите посмотреть:");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    {
                        Task1();
                        break;
                    }
                case 2:
                    {
                        Task2();
                        break;
                    }
                case 3:
                    {
                        Task3();
                        break;
                    }
                case 4:
                    {
                        Task4();
                        break;
                    }
                case 5:
                    {
                        Task5();
                        break;
                    }
                case 6:
                    {
                        Task6();
                        break;
                    }
                case 7:
                    {
                        Task7();
                        break;
                    }
                case 8:
                    {
                        Task8();
                        break;
                    }
                case 9:
                    {
                        Task9();
                        break;
                    }
                case 10:
                    {
                        Task10();
                        break;
                    }
                case 11:
                    {
                        Task11();
                        break;
                    }
                case 12:
                    {
                        Task12();
                        break;
                    }
                case 13:
                    {
                        Task13();
                        break;
                    }
                case 14:
                    {
                        Task14();
                        break;
                    }
                case 15:
                    {
                        Task15();
                        break;
                    }
                case 16:
                    {
                        Task16();
                        break;
                    }
                case 17:
                    {
                        Task17();
                        break;
                    }
                case 18:
                    {
                        Task18();
                        break;
                    }
                case 19:
                    {
                        Task19();
                        break;
                    }
                case 20:
                    {
                        Task20();
                        break;
                    }
                case 21:
                    {
                        Task21();
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
