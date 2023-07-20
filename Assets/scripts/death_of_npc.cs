using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_of_npc : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator angry_pig;
    void Start()
    {
        angry_pig = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("danger_for_np"))
        {
            Die();
        }
    }
    private void Die()
    {
        angry_pig.SetTrigger("death");
    }
}
