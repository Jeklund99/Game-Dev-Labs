using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PongGoal : MonoBehaviour
{
    [SerializeField] private Transform pongGoal;
    public event Action onScore;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            onScore?.Invoke();
        }
    }
}
