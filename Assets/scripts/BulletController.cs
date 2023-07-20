using System;
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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("danger"))
        {
            other.gameObject.GetComponent<PigDeath>().OnDie.Invoke();
        }
        Destroy(gameObject, 0.2f);
    }
}

