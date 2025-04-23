using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public AudioClip shootSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1")) // À Ã
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Vector3 vector3 = firePoint.position;
        vector3.z = vector3.z + 1;
        audioSource.PlayOneShot(shootSound);
        Instantiate(bulletPrefab, vector3, firePoint.rotation);
    }
}