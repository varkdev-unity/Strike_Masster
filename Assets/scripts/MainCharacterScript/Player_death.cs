using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_death : MonoBehaviour
{
    private Animator main_character;
    public static Action OnDie;

    public static bool playerDie;
    
    // Start is called before the first frame update
    void Start()
    {
        main_character = GetComponent<Animator>();
    }

    private void OnEnable() => OnDie += Die;
    private void OnDisable() => OnDie -= Die;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("danger"))
        {
            if (!playerDie)
            {
                Die();
            }
        }
    }
    private void Die()
    {
        main_character.SetTrigger("Death");
        playerDie = true;
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name) ;
        playerDie = false;
    }
}