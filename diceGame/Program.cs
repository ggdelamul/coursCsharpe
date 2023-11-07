Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total = roll1+roll2+roll3;
Console.WriteLine($"Jet de dés:{roll1} + {roll2} + {roll3} = {total}");
if(roll1 == roll2 || roll2 == roll3 || roll1 ==roll3)
{
    if( roll1 == roll2 && roll1 == roll3 )
    {
        total +=6;
        Console.WriteLine($"total majorée : +6");
    }
    else 
    {
        total +=2;
        Console.WriteLine($"total majorée : +2");
    }   
}

Console.WriteLine($"total majorée : {total}");
if (total>=15)
{
    Console.WriteLine("you win ");
} 
else 
{
    Console.WriteLine(" You lose ");
}
