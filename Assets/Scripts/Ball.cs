using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform ball;
    private Vector2 startDirection;
    [SerializeField] private Rigidbody2D ballBody;
    [SerializeField] private Vector3 startPosition;

    public static WaitForSeconds waitTime = new WaitForSeconds(1f);

    void Awake()
    {
        startDirection = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
        ballBody.velocity = startDirection.normalized * moveSpeed;
    }

    public void Restart()
    {
        ballBody.position = startPosition;
        ballBody.velocity = Vector2.zero;
        StartCoroutine(waitThenRestart());
    }

    private IEnumerator waitThenRestart()
    {
        yield return waitTime;

        startDirection = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
        ballBody.velocity = startDirection.normalized * moveSpeed;
    }
    
    public void Freeze()
    {
        ballBody.velocity = Vector2.zero;
        ballBody.simulated = false;
    }

}
