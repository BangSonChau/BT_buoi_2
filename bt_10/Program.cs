Console.WriteLine("1.Economy");
Console.WriteLine("2.Business");
Console.WriteLine("3.First Class");
Console.Write("Chọn loại vé: ");

//input
int choice = Convert.ToInt16(Console.ReadLine());

//output
string description = choice switch
{
  1 => "Ghế thường",
  2 => "Ghế rộng",
  3 => "Ghế sang trọng",
  _ => "Không xác định"
};

Console.WriteLine(@$"
Tiện ích kèm theo
{description}
");


