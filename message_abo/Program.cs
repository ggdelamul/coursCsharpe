Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
Console.WriteLine($"Jour restant {daysUntilExpiration}");

if(daysUntilExpiration<=10 && daysUntilExpiration>5)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(daysUntilExpiration <=5 && daysUntilExpiration > 1)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires within a {daysUntilExpiration} day!Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration ==1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day!Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <=0)
{
    Console.WriteLine("Your subscription has expired.");
}
