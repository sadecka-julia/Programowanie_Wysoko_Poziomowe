abstract class Defender : Inhabitant
{
    public abstract string ReadyToFight();
    
    public override string ToString()
    {
        return "Defender";
    }
}