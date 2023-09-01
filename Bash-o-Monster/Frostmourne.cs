namespace Bash_o_Monster;

public class Frostmourne
{
public int FrostDamage = 11000;
public int Damage = 9000;
public float Weight = 50;
public int SliceandDice = 5000;


public Frostmourne()
{
    maxHp = new Random().Next(11020, 9999); 
    
    ResetHp(); 
}

public int maxHp = 11025;
public int hp; 
public void ResetHp()
{
 hp = maxHp; 
}


}
