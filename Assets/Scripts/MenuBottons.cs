using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuBottons : MonoBehaviour
{
    /// <summary>
    /// Метод перехода в сцену Game
    /// </summary>
    public void InGame()
    {
        SceneManager.LoadScene("Game");
    }
    /// <summary>
    /// Метод перехода в сцену MainMenu
    /// </summary>
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
    /// <summary>
    /// Выход из приложения
    /// </summary>
    public void ExitGame()
    {
        Application.Quit();
    }
}
