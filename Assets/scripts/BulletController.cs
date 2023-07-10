using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 6f; // Скорость движения пули

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed; // Применяем скорость вправо
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "angry_pig")
        {
            // Обнаружено столкновение с объектом "angry_pig"
            Destroy(gameObject); // Уничтожаем пулю
        }
    }

    private void Update()
    {
        // Дополнительные действия или логика пули (если нужно)
    }
}

