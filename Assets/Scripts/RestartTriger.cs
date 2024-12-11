using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // ���������, ��� ������, ������� ������ � �������, ����� ��� "MovingObject"
        if (other.CompareTag("Enemy"))
        {
            // ������������� ������� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
