using System;
using System.Net.Sockets;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < n; rotation++)
            {
                int temp = arr[0];

                for (int step = 0; step < arr.Length - 1; step++)
                {
                    arr[step] = arr[step + 1];
                }

                arr[arr.Length - 1] = temp;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}