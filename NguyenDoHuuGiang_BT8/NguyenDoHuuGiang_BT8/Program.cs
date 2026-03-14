Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Họ tên sv: Nguyễn Đỗ Hữu Giang");
Console.WriteLine("Mã sv: 2415053122312");
Console.Write("Nhập vào một câu bất kỳ: ");
string cau = Console.ReadLine();

if (string.IsNullOrEmpty(cau))
{
    Console.WriteLine("Thông báo: Chuỗi null hoặc rỗng, không thể xử lý.");
    return; 
}

string[] mangTu = cau.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

if (mangTu.Length == 0)
{
    return;
}

string tuDaiNhat = mangTu[0];

for (int i = 1; i < mangTu.Length; i++)
{
   
    if (mangTu[i].Length > tuDaiNhat.Length)
    {
        tuDaiNhat = mangTu[i];
    }
}


Console.WriteLine("------------------------");
Console.WriteLine($"Từ dài nhất trong câu là: '{tuDaiNhat}'");
Console.WriteLine($"Độ dài: {tuDaiNhat.Length} ký tự");

Console.ReadLine();