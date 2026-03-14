using System;
namespace LaptrinhCS
{
    class bai1
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Nguyễn Đỗ Hữu Giang - MSV: 2415053122312");
            Console.WriteLine("Bài 1: Tạo danh sách số nguyên");
            List<int> List = new List<int>(5);
            Random r = new Random();
            Console.Write("5 số được tạo bất kỳ: ");
            for(int i = 0; i < 5; i++)
            {
                List.Add(r.Next(100));
            }
            foreach (int i in List)
            {
                Console.Write(i + "  ");
            }
            Console.ReadLine();
        }
    }
}