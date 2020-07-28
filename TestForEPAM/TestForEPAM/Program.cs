using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForEPAM
{
    class Program
    {
        public static int[] ArrIntCreate(int size, int maxValue)     //инициализация массива Int длинны size случайными числами от 0 до maxValue 
        {
            int[] tempArr = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++) 
            {
                tempArr[i] = rand.Next(maxValue + 1);
            }
            return tempArr;
        }



        public static void ArrShow(int[] arr)      //вывод значений массива
        {
            for (int i=0; i < arr.Length; i++) 
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }



        public static void MySort(int[] arr)    //сортировка массива вставками 
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }



        public static bool IsThereAnyAnswer(int[] arr, int x)    //проверяем есть ли в масиве хотя бы один элемент >  заданного значения X
        {
            bool answer = false;

            for (int i= 0; i< arr.Length && answer==false; i++) 
            {
                if (arr[i] > x)
                {
                    answer = true;
                }            
            }

            return answer;
        }



        public static int bsearch(int[] arr, int x)    //поиск номера первого элемента значение которого > заданного X
        {
            int namberOfFirstElementAboveX =-1;

            if (IsThereAnyAnswer(arr, x))
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > x) 
                    {
                        namberOfFirstElementAboveX = i+1;
                        break;
                    } 
                }
            }

            return namberOfFirstElementAboveX;
        }



        public static void ShowNamberOfFirstElementAboveX(int[] arr, int x)   // вывод значения элемента значение которого > заданного X
        {
            int number = bsearch(arr, x);

            if (number >= 0)
            {
                //ArrShow(arr);
                Console.WriteLine("x=" + x);
                Console.WriteLine("Number of first element above x is i=" + number);
            }
            else
            {
                Console.WriteLine("Number of first element above x is not found in array! Try to set another X value.");
            }       
        }




        static void Main(string[] args)
        {
            int[] arr = ArrIntCreate(10, 100);     //инициализация массива Int длинны size случайными числами от 0 до maxValue 

            Console.Write("Unsorted array: ");
            ArrShow(arr);                          //вывод значений массива

            Console.Write("Sorted array: ");
            //Array.Sort(arr);                       //сортировка массива
            MySort(arr);                           //сортировка массива вставками 
            ArrShow(arr);                          //вывод отсортированного по неубыванию массива

            //int[] testArray = new int[]{ 1, 2, -7, 4, 5, 7, 10, 20, 50, 67, 88, 99, 100 };
            //ShowNamberOfFirstElementAboveX(testArray, -10);

            ShowNamberOfFirstElementAboveX(arr, 22);

            Console.ReadLine();
        }
    }
}
