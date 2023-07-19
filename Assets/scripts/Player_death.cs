using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_death : MonoBehaviour
{
    private Animator main_character;
    public static bool PlayerDie;
    
    // Start is called before the first frame update
    void Start()
    {
        main_character = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("danger"))
        {
            Die();
        }
    }
    private void Die()
    {
        main_character.SetTrigger("Death");
        
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;
    }
}