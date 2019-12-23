using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// статический класс битвы
/// </summary>
public static class Battle
{
    /// <summary>
    /// перечисление для соответствующих констант 
    /// </summary>

    public enum Deth { GAMER, ENEMY, NOBODY };

    /// <summary>
    /// Логика кнопки Attack
    /// </summary>
    public static Deth GamerAttack(int n, int n2)
    {
        if (n <= Global.Gamer.HittChance())
        {

            Global.Enemy.BattleHealth -= Global.Gamer.Attack();
            
            if (DeathEnemy() == Deth.ENEMY)
            {
                return Deth.ENEMY;
            }
        }
        if (n2 <= Global.Enemy.hitt_chance())
        {
            Global.Gamer.BattleHealth -= Global.Enemy.attack();
            if (DeathGamer() == Deth.GAMER)
            {
                return Deth.GAMER;
            }
        }

        return Deth.NOBODY;
    }
    /// <summary>
    /// Логика кнопки MagickAttack
    /// </summary>
    public static Deth GamerMagickAttack(int n2)
    {
        

            Global.Gamer.BattleMana -= 50.0;
            if (Global.Gamer.BattleMana - 50.0 < 0)
            {
            Global.Gamer.BattleMana = 0;
            } else
            {
                Global.Enemy.BattleHealth -= Global.Gamer.Level * 100.0;
                if (DeathEnemy() == Deth.ENEMY)
                {
                    return Deth.ENEMY;
                }

                if (n2 <= Global.Enemy.hitt_chance())
                {
                    Global.Gamer.BattleHealth -= Global.Enemy.attack();
                    if (DeathGamer() == Deth.GAMER)
                    {
                        return Deth.GAMER;
                    }
                }

            }
        
        return Deth.NOBODY;
    }
    /// <summary>
    /// Логика кнопки Healing
    /// </summary>
    public static Deth GamerHealing(int n2)
    {

            Global.Gamer.BattleMana -= 50.0;
            if (Global.Gamer.BattleMana - 50.0 < 0)
            {
                Global.Gamer.BattleMana = 0;
            }
            else
            {
                Global.Gamer.BattleHealth += Global.Gamer.Level * 100.0;

                if (n2 <= Global.Enemy.hitt_chance())
                {
                    Global.Gamer.BattleHealth -= Global.Enemy.attack();
                    if (DeathGamer() == Deth.GAMER)
                    {
                        return Deth.GAMER;
                    }

                }
            }
          
        
        return Deth.NOBODY;
    }
    /// <summary>
    /// Логика, если умер враг
    /// </summary>
    private static Deth DeathEnemy()
    {

        if (Global.Enemy.BattleHealth <= 0)
        {
            double old_gamer_level = Global.Gamer.Level;
            Global.Gamer.CurrentPoint = Global.Gamer.CurrentPoint + (Global.Enemy.Level * 10.0);
            Global.Gamer.SetPoints(Global.Gamer.CurrentPoint);
            return Deth.ENEMY;
        }
        return Deth.NOBODY;
    }

    /// <summary>
    /// Логика если умер герой
    /// </summary>
    private static Deth DeathGamer()
    {

        if (Global.Gamer.BattleHealth <= 0)
        {
            return Deth.GAMER;
        }
        return Deth.NOBODY;
    }


}
