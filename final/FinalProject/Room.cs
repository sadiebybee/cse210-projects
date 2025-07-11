public abstract class Room
{
    public string Name { get; set; }
    public abstract void Enter(Player player);
}
