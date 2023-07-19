using System;
using UnityEngine;

public class PigMovement : MonoBehaviour
{
    [Header("Pig Velocity Data")]
    [SerializeField] private float speed;
    [SerializeField] private Transform selfTransform;
    
    [Header("Pig Radius Control Field")]
    [SerializeField] private float checkRadius;
    [SerializeField] private Transform radiusInitialPos;
    
    [SerializeField] private LayerMask playerLayerMask;
    public bool playerEnterInZone;

    private void FixedUpdate()
    {
        var hit = Physics2D.OverlapCircle(radiusInitialPos.position, checkRadius, playerLayerMask);
        if (hit != null && PlayerMovement.PlayerIsGrounded)
        {
            var target = new Vector2(hit.transform.position.x, selfTransform.position.y);
            
            selfTransform.position = Vector2.MoveTowards(selfTransform.position, target, speed * Time.deltaTime);
            playerEnterInZone = true;
        }
        else
        {
            playerEnterInZone = false;
        }
    }
}
