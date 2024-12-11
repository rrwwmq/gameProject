using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, который входит в триггер, имеет тег "MovingObject"
        if (other.CompareTag("Enemy"))
        {
            // Перезапускаем текущую сцену
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
