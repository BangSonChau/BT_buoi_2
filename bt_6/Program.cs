Console.Write("Nhập số điện tiêu thụ: ");

//input
double elec = Convert.ToDouble(Console.ReadLine());

//output
double tinhDien(double elec_thamso)
{
  if (elec_thamso <= 0) return 0;
  //<100
  if (elec_thamso <= 100)
  {
    return elec_thamso * 1500;
  }
  //>200
  if (elec_thamso > 200)
  {
    return (elec_thamso - 200) * 2500 + tinhDien(200);
  }
  //<=100 and >=200
  return (elec_thamso - 100) * 2000 + tinhDien(100);
}

Console.WriteLine(@$"Số tiền là : {tinhDien(elec)}");