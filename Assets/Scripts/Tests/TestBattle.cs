using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    /// <summary>
    /// Класс тестов
    /// </summary>
    public class TestBattle
    {
        /// <summary>
        /// Тест на кнопку Attack:Игрок убьет врага
        /// </summary>
        [Test]
        public void ifGamerKilledEnemy()
        {
            Global.Gamer = new Gamer();
            Global.Enemy = new Enemy(0);
            var res = Battle.GamerAttack(10, 30) == Battle.Deth.ENEMY;
            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Тест на кнопку Attack:Враг убьет игрока
        /// </summary>
        [Test]
        public void ifEnemyKilledGamer()
        {
            Global.Gamer = new Gamer();
            Global.Enemy = new Enemy(25);
            var res = Battle.GamerAttack(30, 10) == Battle.Deth.GAMER;
            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Тест на кнопку Attack:Никто никого не убьет
        /// </summary>
        [Test]
        public void ifKilledNobody()
        {
            Global.Gamer = new Gamer();
            Global.Enemy = new Enemy(0);
            var res = Battle.GamerAttack(30, 30) == Battle.Deth.NOBODY;
            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Тест на кнопку MagickAttack
        /// </summary>
        [Test]
        public void ifGamerUseMagickAttack()
        {
            Global.Gamer = new Gamer();
            Global.Enemy = new Enemy(0);
            var res = Battle.GamerMagickAttack(30) == Battle.Deth.ENEMY;
            Assert.AreEqual(res, true);
        }
        /// <summary>
        /// Тест на кнопку Healing
        /// </summary>
        [Test]
        public void ifGamerUseHealing()
        {
            Global.Gamer = new Gamer();
            Global.Enemy = new Enemy(0);
            var res = Battle.GamerHealing(10) == Battle.Deth.NOBODY;
            Assert.AreEqual(res, true);
        }
    }
}


