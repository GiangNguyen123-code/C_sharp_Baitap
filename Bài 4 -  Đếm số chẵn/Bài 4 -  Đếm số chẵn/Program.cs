using System;
namespace LythuyetCS
{
    class Bai4
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\t");
            Console.WriteLine("Họ và tên: Nguyễn Đỗ Hữu Giang - MSV: 2415053122312");
            Console.WriteLine("Bài 4:  Đếm số chẵn");
            List<int> list = new List<int>();
            int dem = 0;
            Console.Write("Nhập số phần tử muốn có trong list: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                int a = int.Parse(Console.ReadLine());
                list.Add(a);
            }
            Console.WriteLine("Phần tử trong mảng vừa nhập là: ");
            foreach (int a in list)
            {
                Console.Write("{0} ", a);
                if (a % 2 == 0)
                {
                    dem++;
                }
            }
            Console.WriteLine("\t");
            
            Console.Write("Phần tử chẵn trong mảng (không tính trùng lặp): ");
            foreach(int b in list.Distinct())
            {
                if(b % 2 == 0)
                {
                    Console.Write("{0} ", b);
                }
                
            }
        
            Console.WriteLine("\t");
            Console.Write("Số phần từ chẵn trong mảng: {0}", dem);
            Console.ReadLine();
        }
    }
}