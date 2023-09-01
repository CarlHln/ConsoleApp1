namespace BashMonster; 
public class Demon 
{
    public string name;
    public float hp = 100;
    public float mass = 80; 
    public float maxHp = 100;

    public Demon()
    {
        ResetHp();
    }

    public void ResetHp()
    {
        hp=maxHp;
    }
}