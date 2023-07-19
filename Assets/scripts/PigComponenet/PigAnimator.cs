using UnityEngine;

public class PigAnimator : MonoBehaviour
{
    [SerializeField] private PigMovement movement;
    [SerializeField] private Animator pigAnimator;

    private void FixedUpdate()
    {
        if (movement.playerEnterInZone)
            pigAnimator.SetBool("Run", true);
        else
            pigAnimator.SetBool("Run", false);
    }
}
