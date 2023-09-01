namespace Bash_o_Monster;

public class Murlock
{
public int FishSlap = 8500;
public int Damage = 5000;
public float Weight = 45;
public int bite = 6000;  

public Murlock()
{
    maxHp = new Random().Next(90, 110); 
    
    ResetHp(); 
}
public int maxHp = 110;
public int hp; 
public void ResetHp()
{
 hp = maxHp; 
}
  
}
