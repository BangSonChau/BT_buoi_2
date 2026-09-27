//Bài 1
Console.Write("Nhập nhiệt độ: ");
//
int doC = Convert.ToInt32(Console.ReadLine());
//output
string Notification = doC switch
{
  > 0 => "Trời ấm",
  < 0 => "Trời lạnh, có thể có băng giá!",
  _ => "Trời rất lạnh, đúng 0C"
};

Console.WriteLine(@$"{Notification}");