using System;
using UnityEngine;

public enum BulletType { PlayerBullet, PlantBullet }
[RequireComponent(typeof(Rigidbody2D))]
public class BulletController : MonoBehaviour
{
    [SerializeField] private string enemyTag;
    [SerializeField] private BulletType type;

    public float speed = 6f; // Скорость движения пули
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (type == BulletType.PlayerBullet)
        {
            if (PlayerMovement.direction == 1)
                rb.velocity = transform.right * speed;
            else if (PlayerMovement.direction == -1)
                rb.velocity = -transform.right * speed;
        }
        else
            rb.velocity = transform.right * speed;   
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag(enemyTag))
        {
            if (type == BulletType.PlayerBullet)
                other.gameObject.GetComponent<PigDeath>().OnDie.Invoke();
            else if (type == BulletType.PlantBullet)
                Player_death.OnDie?.Invoke();
        }
        Destroy(gameObject, 0.2f);
    }
}

