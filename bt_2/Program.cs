Console.Write("Nhập số tiền thu nhập hằng tháng: ");

//input
double value = Convert.ToDouble(Console.ReadLine());
//output
string Notification = value switch
{
  > 10 => "Thuế 20%",
  > 5 => "Thuế 10%",
  _ => "Miễn thuế"
};

Console.WriteLine(@$"{Notification}");