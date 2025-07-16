public abstract class Room
{
    private string _name;

    protected void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void Enter(Player player);
}
