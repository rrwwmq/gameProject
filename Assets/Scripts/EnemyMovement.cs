using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public GameObject objectPrefab; // ������ �������, ������� ����� ����������
    public float spawnInterval = 5f; // �������� ������ � ��������
    public float spawnRangeX = 6f; // ������������ ������ ������ �� ��� X
    public float spawnPositionY = 0f; // ������� �� ��� Y
    public float spawnPositionZ = 30f; // ������� �� ��� Z
    public float moveSpeed = 5f; // �������� �������� �������� ������
    public float spawnRotation;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval); // �������� �����
    }

    private void SpawnObject()
    {
        // ���������� ��������� ���������� �� ��� X
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);

        // ���������� ������� ������
        Vector3 spawnPosition = new Vector3(randomX, spawnPositionY, spawnPositionZ);
        Quaternion spawnRotation = Quaternion.Euler(0, 180, 0);


        // ������� ������
        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        // �������� ��������� Rigidbody � ������������� �������� ������
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.back * moveSpeed; // ������� ������ ������ (� ������� ���������� Z)
        }
    }
}