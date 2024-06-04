using System;
using System.Collections.Generic;

namespace ListTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao input gom cac dong so nguyen, nhap * de ket thuc:");
            int index = 1;
            string danhSachInput = "";
            do
            {
                Console.Write("Dong thu {0} la: ", index);
                string inputline = Console.ReadLine();
                if (inputline == "*") break;
                else
                {
                    danhSachInput += (inputline + " ");
                    index += 1;
                }
            }
            while (true);
            Console.Clear();

            // Chuyển đổi danh sách nhập vào thành danh sách số nguyên
            List<int> numList = new List<int>();
            string[] inputNumbers = danhSachInput.Trim().Split(' ');
            foreach (string number in inputNumbers)
            {
                int num;
                if (int.TryParse(number, out num))
                {
                    numList.Add(num);
                }
                else
                {
                    Console.WriteLine("Không thể chuyển đổi {0} thành số nguyên.", number);
                }
            }

            // Sắp xếp danh sách số nguyên
            numList.Sort();

            Console.Write("Danh sach sau khi sap xep: ");
            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
