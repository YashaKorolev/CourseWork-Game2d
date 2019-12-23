
public class Gamer
{
   /// <summary>
   /// Параметры героя
   /// </summary>
    public double Level { get; set; }
    public double CurrentPoint { get; set; }
    public double MaxPoint { get; set; }
    public double Health
    {
        get
        {
            return 100.0 + Level * 50.0;
        }
    }

    public double BattleHealth
    {
        get;set;
    }

    public double Mana
    {
        get
        {
            return 1+Level * 100.0;
        }        
    }

    public double BattleMana
    {
        get;set;
    }

    public void SetPoints(double points)
    {
        if (CurrentPoint > MaxPoint)
        {
            CurrentPoint = CurrentPoint - MaxPoint;
            MaxPoint += 500.0;
            Level++;
        }
    }
    public double Attack()
    {
        return 1.0+Level * 50.0;
    }
    public double HittChance()
    {
        return 20.0 + 0.5 * Level;
    }
    /// <summary>
    /// Метод обновления тех параметров, которые треб обновлять в случае, если игра уже идет
    /// </summary>
    public void update()
    {
        BattleMana = Mana;
        BattleHealth = Health;
    }
    /// <summary>
    /// инициализация параметров игрока
    /// </summary>
    public Gamer()
    {
            Level = 1.0;
            CurrentPoint = 0.0;
            MaxPoint = 1000.0;

            BattleMana = Mana;
            BattleHealth = Health;
    }
}