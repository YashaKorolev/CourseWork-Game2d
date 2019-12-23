using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// класс обработки сцены
/// </summary>
public class BattleToday : MonoBehaviour
{
    /// <summary>
    /// Ссылки на текстовые поля для отображения информации об игроке и враге
    /// </summary>
    public Text text_gamer_buttle_health;
    public Text text_gamer_battle_mana;
    public Text text_gamer_level;
    public Text text_gamer_points;
    public Text text_gamer_hitt_chance;
    public Text text_gamer_attack;
    public Text text_gamer_magick_attack;
    public Text text_gamer_healing;
    public Text text_enemy_battle_health;
    public Text text_enemy_level;
    public Text text_enemy_power;
    public Text text_enemy_hitt_chance;
    public Text text_enemy_attack;
    public Text text_enemy_agility;

    public System.Random random = new System.Random();

    /// <summary>
    /// Обновление данных об игроке и враге на интерфейсе
    /// </summary>
    void update_ui()
    {
        text_gamer_buttle_health.text = "  Health:" + Global.Gamer.BattleHealth.ToString();
        text_gamer_battle_mana.text = "  Mana:" + Global.Gamer.BattleMana.ToString();
        text_gamer_level.text = "  Level:" + Global.Gamer.Level.ToString();
        text_gamer_points.text = "  Points:" + Global.Gamer.CurrentPoint.ToString();
        text_gamer_hitt_chance.text = "  Hitt Chance:" + Global.Gamer.HittChance().ToString();
        text_gamer_attack.text = "  Attack:" + Global.Gamer.Attack().ToString();
        text_gamer_magick_attack.text = "  MagickAttack:" + Global.Gamer.Level * 100.0;
        text_gamer_healing.text="  Healing:" + Global.Gamer.Level * 100.0;
        text_enemy_battle_health.text = "  Health:" + Global.Enemy.BattleHealth.ToString();
        text_enemy_level.text = "  Level:" + Global.Enemy.Level.ToString();
        text_enemy_power.text = "  Power:" + Global.Enemy.Power.ToString();
        text_enemy_hitt_chance.text = "  Hitt Chance:" + Global.Enemy.hitt_chance().ToString();
        text_enemy_attack.text = "  Attack:" + Global.Enemy.attack().ToString();
        text_enemy_agility.text = "  Agility" + Global.Enemy.Agility.ToString();

    }

    void Start()
    {

        /// <summary>
        /// Проверка идет ли игра
        /// </summary>
        if (!Global.isGameBegin)
        {
            /// <summary>
            /// В начале игры создаем новых врага и игрока
            /// </summary>
            Global.Gamer = new Gamer();
            Global.isGameBegin = true;
        }
        else
        {
            /// <summary>
            /// Игра уже идет, тогда у игрока обновляются параметры, заложенные в метод update()
            /// </summary>
            Global.Gamer.update();
        }

        /// <summary>
        /// Выбор случайным образом врага из имеющихся
        /// </summary>
        System.Random r = new System.Random();
        Global.Enemy = new Enemy(r.Next(0, 25));

        update_ui();
    }

    /// <summary>
    /// Логика кнопки Attack
    /// </summary>
    public void AttackClick()
    {
        int r1 = random.Next(0, 100);
        int r2 = random.Next(0, 100);

        var res = Battle.GamerAttack(r1, r2);
        if (res == Battle.Deth.ENEMY)
        {
            SceneManager.LoadScene("Game");
        }

        if (res == Battle.Deth.GAMER)
        {
            SceneManager.LoadScene("Death");
        }

        update_ui();
    }
    /// <summary>
    /// Логика кнопки MagickAttack
    /// </summary>
    public void MagickAttackClick()
    {
        int r = random.Next(0, 100);
        if (Battle.GamerMagickAttack(r) == Battle.Deth.ENEMY)
        {
            SceneManager.LoadScene("Game");
        }
        if(Battle.GamerMagickAttack(r) == Battle.Deth.GAMER)
        {
            SceneManager.LoadScene("Death");
        }
        if (Battle.GamerHealing(r) == Battle.Deth.GAMER && Battle.GamerHealing(r) == Battle.Deth.ENEMY)
        {
            SceneManager.LoadScene("Death");
        }

        update_ui();
    }
    /// <summary>
    /// Логика кнопки Healing
    /// </summary>
    public void Healing()
    {
        int r = random.Next(0, 100);
        if (Battle.GamerHealing(r) == Battle.Deth.ENEMY)
        {
            SceneManager.LoadScene("Game");
        }
        if (Battle.GamerHealing(r) == Battle.Deth.GAMER)
        {
            SceneManager.LoadScene("Death");
        }
        if(Battle.GamerHealing(r) == Battle.Deth.GAMER&& Battle.GamerHealing(r) == Battle.Deth.ENEMY)
        {
            SceneManager.LoadScene("Death");
        }
        update_ui();
    }
    /// <summary>
    /// Логика кнопки escape(выход из сцены Battle в сцену Game
    /// </summary>
    public void escape()
    {
        SceneManager.LoadScene("Game");
    }
}
