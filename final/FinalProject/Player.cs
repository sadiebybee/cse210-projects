public class Player
{
    private string _name;
    private int _maxHealth = 100;
    private int _currentHealth;

    public Player(string name)
    {
        _name = name;
        _currentHealth = _maxHealth;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetCurrentHealth()
    {
        return _currentHealth;
    }

    public int GetMaxHealth()
    {
        return _maxHealth;
    }

    public void TakeDamage(int amount)
    {
        _currentHealth = _currentHealth - amount;
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }

    public string GetHealthDisplay()
    {
        return _currentHealth + "/" + _maxHealth;
    }
}
