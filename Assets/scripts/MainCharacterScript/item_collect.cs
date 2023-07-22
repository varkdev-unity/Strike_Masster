using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class item_collect : MonoBehaviour

{
    [SerializeField] private Text appleText;
    int ApplesCollected = 0 ; // Shared variable


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("apple"))
        {
            ApplesCollected++;
            Destroy(collision.gameObject);
            appleText.text = "" + ApplesCollected;
        }
    }
}