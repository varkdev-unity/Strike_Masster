using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform nextPortal;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.transform.position = nextPortal.position;
        }
    }
}
