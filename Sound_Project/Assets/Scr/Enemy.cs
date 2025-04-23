using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f; // Скорость движения
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // Находим игрока
    }

    void Update()
    {
        if (player != null)
        {
            // Двигаем моба по прямой к игроку
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet")) // Если моба задела пуля
        {
            Destroy(other.gameObject); // Удаляем пулю
            Destroy(gameObject); // Удаляем моба
        }
    }
}