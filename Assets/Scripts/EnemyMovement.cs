using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyMovement : MonoBehaviour
{
    public GameObject objectPrefab; // Префаб объекта, который будет спавниться
    public float spawnInterval = 5f; // Интервал спавна в секундах
    public float spawnRangeX = 6f; // Максимальный радиус спавна по оси X
    public float spawnPositionY = 0f; // Позиция по оси Y
    public float spawnPositionZ = 30f; // Позиция по оси Z
    public float moveSpeed = 5f; // Скорость движения объектов вперед
    public float spawnRotation;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObject), 0f, spawnInterval); // Начинаем спавн
    }

    private void SpawnObject()
    {
        // Генерируем случайные координаты по оси X
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);

        // Определяем позицию спавна
        Vector3 spawnPosition = new Vector3(randomX, spawnPositionY, spawnPositionZ);
        Quaternion spawnRotation = Quaternion.Euler(0, 180, 0);


        // Создаем объект
        GameObject newObject = Instantiate(objectPrefab, spawnPosition, spawnRotation);

        // Получаем компонент Rigidbody и устанавливаем движение вперед
        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = Vector3.back * moveSpeed; // Двигаем объект вперед (в сторону уменьшения Z)
        }
    }
}