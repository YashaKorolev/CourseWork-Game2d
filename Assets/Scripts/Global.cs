using UnityEngine;
public static class Global
{
    /// <summary>
    ///  Перечисление для определения местоположения игрока по отношению к врагу
    /// </summary>
    public enum Direction { UP, DOWN, LEFT, RIGHT, NULL };
    /// <summary>
    /// Текущая позиция игрока
    /// </summary>
    public static Vector2 HeroCurrentPosition = Vector2.zero;
    /// <summary>
    /// Текущее значение, с какой стороны подошли к врагу
    /// </summary>
    public static Direction HeroDirection = Direction.NULL; 
    /// <summary>
    /// Текущий игрок
    /// </summary>
    public static Gamer Gamer;
    /// <summary>
    /// Текущий враг
    /// </summary>
    public static Enemy Enemy;
    /// <summary>
    /// Флаг начала игры
    /// </summary>
    public static bool isGameBegin = false;
}