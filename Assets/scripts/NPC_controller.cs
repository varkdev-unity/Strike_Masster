using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class NPC_controller : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Transform selfTransform;
    private Vector2 target;
    
    private Animator angry_pig;
    private Rigidbody2D rb;
    private bool isFollowing = false;

    void Start()
    {
        angry_pig = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            FollowEnemy(collision.gameObject);
            angry_pig.SetBool("Run", true);

            target = new Vector2(collision.transform.position.x, selfTransform.position.y);
            isFollowing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            angry_pig.SetBool("Run", false);
            target = new Vector2(selfTransform.position.x, selfTransform.position.y);
            isFollowing = false;
            rb.velocity = Vector2.zero; // Stop NPC's movement
        }
    }

    void FollowEnemy(GameObject enteredObject)
    {
        if (isFollowing && Player_death.PlayerDie)
        {
            selfTransform.position = Vector2.MoveTowards(selfTransform.position, target, speed * Time.deltaTime);
        }
    }
}
