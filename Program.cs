using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Data;
using System.Collections.Generic;
using System.Linq.Expressions;
namespace CodeWars
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] array = new int[] {};
            Console.WriteLine(Parser.LastDigit(array));
        }


    }


        public class Parser
        {
        public static int LastDigit(int[] array)
        {
            int LastDigit = 0;
            BigInteger[] arr = new BigInteger[array.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = array[i];
            }
            if (arr.Length == 0)
            {
                LastDigit = 1;
            }
            else
            {
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    if (arr[i] == 0 & arr[i - 1] != 0)
                    {
                        arr[i - 1] = 1;

                    }
                    if (arr[i] == 1)
                    {
                        arr[i - 1] = arr[i - 1];

                    }
                    if (arr[i] == 0 & arr[i - 1] == 0)
                    {
                        arr[i - 1] = 1;
                    }
                    else
                    {
                        //if (array[i - 1] % 10 == 4)
                        //{
                        //    if (array[i]/2==0)
                        //    {
                        //        array[i - 1] = 4;
                        //    }
                        //    if (array[i] / 2 == 1)
                        //    {
                        //        array[i - 1] = 6;
                        //    }
                        //}

                        if (arr[i] % 4 == 0 & arr[i - 1] % 2 == 1)
                        {
                            arr[i - 1] = 1;
                        }
                        if (arr[i] % 4 == 0 & arr[i - 1] % 2 == 0 & arr[i - 1] % 10 != 0)
                        {
                            arr[i - 1] = 6;
                        }

                        if (arr[i] % 4 == 1)
                        {
                            arr[i - 1] = arr[i - 1] % 10;
                        }
                        if (arr[i] % 4 == 2)
                        {
                            arr[i - 1] = BigInteger.Pow(arr[i - 1], 2) % 10;
                        }
                        if (arr[i] % 4 == 3)
                        {
                            arr[i - 1] = BigInteger.Pow(arr[i - 1] % 10, 3);
                        }

                        //if (array[i-1]%10==5)
                        //{
                        //    array[i - 1] = 5;
                        //}
                        //if (array[i - 1] % 10 == 6)
                        //{
                        //    array[i - 1] = 6;
                        //}
                        //if (array[i - 1] % 10 == 9)
                        //{
                        //    if (array[i] / 2 == 0)
                        //    {
                        //        array[i - 1] = 9;
                        //    }
                        //    if (array[i] / 2 == 1)
                        //    {
                        //        array[i - 1] = 1;
                        //    }
                        //}


                    }
                    LastDigit = (Int32)arr[0];
                }
            }
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
           
            return LastDigit;
        }
        
    }

    
}



