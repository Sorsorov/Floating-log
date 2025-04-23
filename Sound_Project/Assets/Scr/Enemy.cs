using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 3f; // �������� ��������
    private Transform player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform; // ������� ������
    }

    void Update()
    {
        if (player != null)
        {
            // ������� ���� �� ������ � ������
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet")) // ���� ���� ������ ����
        {
            Destroy(other.gameObject); // ������� ����
            Destroy(gameObject); // ������� ����
        }
    }
}