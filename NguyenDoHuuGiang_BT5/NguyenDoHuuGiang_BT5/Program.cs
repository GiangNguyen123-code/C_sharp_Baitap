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
        Console.WriteLine("Giá trị không hợp lệ, mặc định là 0.");
        mang[i] = 0;
    }
}

if (mang != null && mang.Length > 0)
{
    int max = mang[0];

    for (int i = 1; i < mang.Length; i++)
    {
        if (mang[i] > max)
        {
            max = mang[i];
        }
    }
    Console.WriteLine("------------------------");
    Console.WriteLine($"Giá trị lớn nhất trong mảng là: {max}");
}
else{ return;}
Console.ReadLine();