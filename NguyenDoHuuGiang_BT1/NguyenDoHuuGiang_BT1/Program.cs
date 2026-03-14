using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenDoHuuGiang_BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhap ho ten:  ");
            string nhap = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nhap))
            {
                Console.Error.WriteLine("Loi");
                return;
            }
            string[] words = nhap.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }

            string result = string.Join(" ", words);
            Console.WriteLine($"Kết quả: '{result}'");
        }
    }
}
