// See https://aka.ms/new-console-template for more information
using Bash_o_Monster;

Console.WriteLine("good morning, fucking World!");

Frostmourne Ice = new Frostmourne();
Murlock Fishboy = new Murlock();

Ice.Damage = 9000; 
Fishboy = 5000; 

Ice = new Frostmourne(); 
Ice.ResetHp();  

Fishboy = new Murlock();
Fishboy.ResetHp(); 

Console.WriteLine(Ice.Damage); 
Console.WriteLine(Fishboy.Damage); 

Console.ReadLine(); 


/*
Frostmourne
FrostDamage: int
PhysicalDamage: int
Weight: int
Slice and Dice: int

*/
/*
Murlock
FishSlap: int
Damage: int
Weight: int
Bite: int
*/
