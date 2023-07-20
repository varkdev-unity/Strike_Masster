using System;
using UnityEngine;

public class PigAnimator : MonoBehaviour
{
    [SerializeField] private PigMovement movement;
    [SerializeField] private Animator pigAnimator;

    [SerializeField] private PigDeath deathComponent;

    private void OnEnable() => deathComponent.OnDie += ShowDieAnimation;
    private void OnDisable() => deathComponent.OnDie -= ShowDieAnimation;

    private void FixedUpdate()
    {
        if (movement.playerEnterInZone)
            pigAnimator.SetBool("Run", true);
        else
            pigAnimator.SetBool("Run", false);
    }
    
    private void ShowDieAnimation() => pigAnimator.SetTrigger("Death");
}
