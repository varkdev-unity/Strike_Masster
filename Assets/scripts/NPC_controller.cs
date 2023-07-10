using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC_controller : MonoBehaviour
{
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
            angry_pig.SetTrigger("idle_to_attack");
            isFollowing = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerMovement>())
        {
            angry_pig.SetTrigger("attack_to_idle");
            isFollowing = false;
            rb.velocity = Vector2.zero; // Stop NPC's movement
        }
    }

    void FollowEnemy(GameObject enteredObject)
    {
        if (isFollowing)
        {
            Vector3 direction = enteredObject.transform.position - transform.position;
            rb.AddForce(direction);
        }
    }

}
