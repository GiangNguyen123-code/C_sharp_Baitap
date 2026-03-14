Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Họ tên: Nguyễn Đỗ Hữu Giang");
Console.WriteLine("Mã sv: 2415053122312");
Console.Write("Nhập số phần tử của mảng n = ");
int n;
string input = Console.ReadLine();
int.TryParse(input, out n);

if (n <= 0)
{
    Console.WriteLine("Lỗi: Số phần tử phải là số nguyên dương.");
    return;
}

int[] mang = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Nhập phần tử thứ {i}: ");
    if (!int.TryParse(Console.ReadLine(), out mang[i]))
    {
        mang[i] = 0;
    }
}


int demChan = 0;


if (mang == null)
{
    demChan = 0;
}
else
{
  
    for (int i = 0; i < mang.Length; i++)
    {
        if (mang[i] % 2 == 0) 
        {
            demChan++;
        }
    }
}
Console.WriteLine($"Số lượng phần tử chẵn là: {demChan}");
Console.ReadLine();