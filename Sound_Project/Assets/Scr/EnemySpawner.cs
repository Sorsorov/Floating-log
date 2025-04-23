using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints; // Массив точек спавна
    public float spawnRate = 5f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    void SpawnEnemy()
    {
        if (spawnPoints.Length == 0) return; // Проверка на наличие точек

        int randomIndex = Random.Range(0, spawnPoints.Length); // Выбираем случайную точку
        Instantiate(enemyPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
    }
}