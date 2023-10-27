double x1, x2, y1, y2, dlin;
Random rand = new Random();
Console.WriteLine("Сгенерировать случайные точки? 1-Да; 2-Нет");
string ans = Console.ReadLine();
if (ans == "1")
{
    x1 = rand.NextDouble()*100;
    y1 = rand.NextDouble()*100;
    x2= rand.NextDouble()*100;
    y2= rand.NextDouble()*100;
    Console.WriteLine("Координаты первой точки: " + "\n x1= " + Convert.ToString(x1) + "\n y1= "+ Convert.ToString(y1));
    Console.WriteLine("Координаты второй точки: " + "\n x2= " + Convert.ToString(x2) + "\n y2= " + Convert.ToString(y2));
    dlin = Math.Sqrt(((x1-y1)*(x1-y1)) + ((x2-y2)*(x2-y2)));
    Console.WriteLine("Длинна отрезка: " + Convert.ToString(dlin));
}
Console.ReadKey();

