using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Inbattle : MonoBehaviour
{
    /// <summary>
    /// При соприкосновении героя с врагом, переход из сцены Game в сцену Battle
    /// </summary>
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene("Battle");
    }
}
