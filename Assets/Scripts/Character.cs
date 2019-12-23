using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    /// <summary>
    /// Задание скорости игрока
    /// </summary>
    private float speed = 1;
    /// <summary>
    /// Переменная для направления движения
    /// </summary>
    protected Vector2 direction;


    /// <summary>
    /// Для контроля за местоположением игрока
    /// </summary>
    private Rigidbody2D HeroRiginBody;
    protected virtual void Start()
    {
        HeroRiginBody = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Местоположение игрока
    /// </summary>
    public Vector2 CurrentPosition
    {
        get {
            return HeroRiginBody.position;
        }
        set
        {
            HeroRiginBody.position = value;
        }
    }

    private void FixedUpdate()
    {
        Move();
    }
    /// <summary>
    /// Задание направления движения
    /// </summary>
    public void Move()
    {

        HeroRiginBody.velocity = direction.normalized * speed;
    }
}
