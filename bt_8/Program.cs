Console.Write("Nhập số km: ");

//input
double km = Convert.ToDouble(Console.ReadLine());

//output
double tinhTien(double km) => km switch
{
  <= 0 => 0,
  <= 1 => km * 10000,
  <= 5 => 10000 + (km - 1) * 8000,
  _ => 42000 + (km - 5) * 6000
};

Console.WriteLine(@$"Số tiền là : {tinhTien(km)}");