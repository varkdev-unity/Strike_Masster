using System;
using System.Security.Cryptography;
using UnityEngine;

public class PigDeath : MonoBehaviour
{
    public Action OnDie;

    private void OnEnable() => OnDie += Kill;
    private void OnDisable()=> OnDie -= Kill;

    private void Kill()
    {
        Destroy(gameObject, 1);
    }
}
