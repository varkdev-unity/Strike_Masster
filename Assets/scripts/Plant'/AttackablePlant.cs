using System;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AttackablePlant : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] private int rayDistance;

    [SerializeField] private GameObject bullet;
    private Animator plantAnimator;

    private void Start()
    {
        plantAnimator = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        var hit = Physics2D.Raycast(shootPoint.position, Vector2.right, rayDistance);
        if (hit.collider != null)
        {
            if (hit.collider.CompareTag("Player") && !Player_death.playerDie)
                plantAnimator.SetBool("shoot", true);

            else
                plantAnimator.SetBool("shoot", false);
        }
    }

    public void Shoot() => Instantiate(bullet, shootPoint.position, Quaternion.identity);
}
