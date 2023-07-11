using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;
    public float throwCooldown = 5f;

    private float lastThrowTime;

    private void Start()
    {
        lastThrowTime = -throwCooldown; // Устанавливаем время последнего выстрела на значение, гарантирующее первый выстрел
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && Time.time - lastThrowTime >= throwCooldown)
        {
            ThrowBullet();
            lastThrowTime = Time.time;
        }
    }

    private void ThrowBullet()
    {
        // Создаем экземпляр пули
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        // Делаем пулю видимой на сцене
        bullet.SetActive(true);
    }
}
