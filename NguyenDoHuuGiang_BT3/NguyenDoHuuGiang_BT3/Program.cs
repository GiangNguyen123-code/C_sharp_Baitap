Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.Write("Nhập chuỗi: ");
string input = Console.ReadLine();

if (input == null)
{
    Console.WriteLine("Kết luận: Không đối xứng");
    return;
}
string temp = input.Replace(" ", "").ToLower();
bool laDoiXung = true;

for (int i = 0; i < temp.Length / 2; i++)
{
    if (temp[i] != temp[temp.Length - 1 - i])
    {
        laDoiXung = false;
        break;
    }
}

Console.WriteLine(laDoiXung ? "=> Đây là chuỗi đối xứng" : "=> Không phải chuỗi đối xứng");