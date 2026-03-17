using System;
using System.Diagnostics.Metrics;
namespace LythuyetCS
{
    class Bai16
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n\n");
            Console.WriteLine("Họ và tên: Nguyễn Đỗ Hữu Giang - MSV: 2415053122312");
            Console.WriteLine("Bài 16: Đếm số lần xuất hiện");
            Dictionary<char, int> Dem = new Dictionary<char, int>();
            Console.Write("Nhập chuỗi cần đếm ký tự: ");
            String input = Console.ReadLine();
            
            foreach(char c in input)
            {
                if (Dem.ContainsKey(c))
                {
                    Dem[c]++;
                }
                else
                {
                    Dem[c] = 1;
                }
            }
            Console.WriteLine("\nKết quả đếm: ");
            foreach (var item in Dem)
            {
                Console.Write($"{item.Key}: {item.Value} ");
            }

            Console.ReadLine();
        }
    }
}