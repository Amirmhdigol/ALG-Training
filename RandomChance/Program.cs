//var input = Convert.ToInt32(Console.ReadLine());

var rand = new Random();
int total6s = 0;

for (int j = 0; j < 10; j++)
{
    string res2 = "";
    int SixCount = 0;
    int posibilityOf6;

    for (int i = 0; i < 6; i++)
    {
        var res = rand.Next(1, 7);
        res2 += res.ToString();
        res2 += ",";

        if (res == 6)
            SixCount++;
    }
    Console.WriteLine(res2);
    Console.WriteLine($"Six came : {SixCount}");
    total6s += SixCount;
}
var percentage = (total6s * 100) / 60;
Console.WriteLine($"six came {total6s} in 60 time chance");
Console.WriteLine($"{percentage}% in percentage to happening 6 in 60 time throwing the dice");