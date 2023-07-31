using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class cacti_controller : MonoBehaviour
{
    private Animator cacti_animator;
    private GameObject playerObject;
    // Start is called before the first frame update
    void Start()
    {
        cacti_animator = GetComponent<Animator>();
        playerObject = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == playerObject)
        {
            //nothing
        }
    }
    void start_shooting()
        
    {

    }


}
