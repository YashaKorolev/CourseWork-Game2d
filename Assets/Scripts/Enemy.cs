using UnityEngine;
public class Enemy
{
    /// <summary>
    /// Параметры врага
    /// </summary>
    public string Name { get; set; }
  
    public double Power { get; set; }
  
    public double Agility { get; set; }

    public double Level { get; set; }


    /// <summary>
    /// Набор разных врагов
    /// </summary>
    public Enemy(int param)
    {

        switch (param)
        {
            case 0:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 1:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 2:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 3:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 4:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 5:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
            case 6:
                Name = "Monster";

                Power = 2.0;
                Agility = 5.0;
                Level = 2.0;
                BattleHealth = Health;
                break;
            case 7:
                Name = "Monster";

                Power = 2.0;
                Agility = 5.0;
                Level = 2.0;
                BattleHealth = Health;
                break;
            case 8:
                Name = "Monster";

                Power = 2.0;
                Agility = 5.0;
                Level = 2.0;
                BattleHealth = Health;
                break;
            case 9:
                Name = "Monster";

                Power = 2.0;
                Agility = 5.0;
                Level = 2.0;
                BattleHealth = Health;
                break;
            case 10:
                Name = "Monster";

                Power = 2.0;
                Agility = 5.0;
                Level = 2.0;
                BattleHealth = Health;
                break;
            case 11:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;

            case 12:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;
            case 13:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;
            case 14:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;
            case 15:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;
            case 16:
                Name = "Monster";

                Power = 3.0;
                Agility = 3.0;
                Level = 3.0;
                BattleHealth = Health;
                break;
            case 17:
                Name = "Monster";

                Power = 10.0;
                Agility = 10.0;
                Level = 10.0;
                BattleHealth = Health;
                break;
            case 18:
                Name = "Monster";

                Power = 10.0;
                Agility = 10.0;
                Level = 10.0;
                BattleHealth = Health;
                break;
            case 19:
                Name = "Monster";

                Power = 10.0;
                Agility = 10.0;
                Level = 10.0;
                BattleHealth = Health;
                break;
            case 20:
                Name = "Monster";

                Power = 20.0;
                Agility = 20.0;
                Level = 20.0;
                BattleHealth = Health;
                break;
            case 21:
                Name = "Monster";

                Power = 20.0;
                Agility = 20.0;
                Level = 20.0;
                BattleHealth = Health;
                break;
            case 22:
                Name = "Monster";

                Power = 20.0;
                Agility = 20.0;
                Level = 20.0;
                BattleHealth = Health;
                break;
            case 23:
                Name = "Monster";

                Power = 30.0;
                Agility = 30.0;
                Level = 30.0;
                BattleHealth = Health;
                break;
            case 24:
                Name = "Monster";

                Power = 30.0;
                Agility = 30.0;
                Level = 30.0;
                BattleHealth = Health;
                break;
            case 25:
                Name = "Monster";

                Power = 30.0;
                Agility = 30.0;
                Level = 30.0;
                BattleHealth = Health;
                break;


            default:
                Name = "Monster";

                Power = 1.0;
                Agility = 1.0;
                Level = 1.0;
                BattleHealth = Health;
                break;
        }

        
    }


    public double Health
    {
        get
        {
            return Level * 50.0;
        }
    }

    public double BattleHealth
    {
        get; set;
    }

    public bool active()
    {
        return Name != "";
    }

    public double attack()
    {
        return Power * 50.0;
    }

    public double hitt_chance()
    {
        return 20.0 + 0.1 * Agility;
    }

}
