string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
int [] inventory = { 200,450,700,175,250};
int sum =0;
int bin =0;
foreach(int item in inventory)
{
    bin++;
   sum += item ;
   Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
   
}
Console.WriteLine($"somme total {sum}");