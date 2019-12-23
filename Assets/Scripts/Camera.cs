using UnityEngine;

public class Camera : MonoBehaviour
{
    public Hero player; 
    void Update()
    {
        /// <summary>
        /// Закрепление камеры с игроком
        /// </summary>
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10f);

    }
}
