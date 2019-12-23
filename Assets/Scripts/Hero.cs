using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : Character
{

    protected override void Start()
    {
        base.Start();
        /// <summary>
        /// Необходимо отодвинуть игрока от врага, что-бы не зацикливалось окно битвы
        /// </summary>
        if (Global.HeroCurrentPosition != Vector2.zero && Global.HeroDirection != Global.Direction.NULL)
        {
            if(Global.HeroDirection == Global.Direction.LEFT)
            {
                Global.HeroCurrentPosition.x += 0.15f;
                
            }
            if (Global.HeroDirection == Global.Direction.RIGHT)
            {
                Global.HeroCurrentPosition.x -= 0.15f;
            }
            if (Global.HeroDirection == Global.Direction.UP)
            {
                Global.HeroCurrentPosition.y -= 0.15f;
            }
            if (Global.HeroDirection == Global.Direction.DOWN)
            {
                Global.HeroCurrentPosition.y += 0.15f;
            }

            CurrentPosition = Global.HeroCurrentPosition;
        }
    }
    protected  void Update()
    {
        GetInput();   
    }

    private void GetInput()
    {
        /// <summary>
        /// Чтобы при зажатии кнопки, не увеличивалась скорость игрока на поле
        /// </summary>
        direction = Vector2.zero;

        /// <summary>
        /// При движении игрока запоминаем в каком направлении он двигался
        /// </summary>
        if (Input.GetKey(KeyCode.W))
        {
            direction += Vector2.up;
            Global.HeroDirection = Global.Direction.UP;

        }
        if (Input.GetKey(KeyCode.A))
        {
            direction += Vector2.left;
            Global.HeroDirection = Global.Direction.LEFT;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction += Vector2.down;
            Global.HeroDirection = Global.Direction.DOWN;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction += Vector2.right;
            Global.HeroDirection = Global.Direction.RIGHT;
        }

        /// <summary>
        /// Запомнить глобально текущую позицию игрока для дальнейшего расчета отодвига от врага
        /// </summary>
        Global.HeroCurrentPosition = CurrentPosition;
        
    }
}
