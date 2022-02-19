using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform paddle;
    [SerializeField] private KeyCode moveUp;
    [SerializeField] private KeyCode moveDown;
    [SerializeField] private float maxPaddleY = 927f;
    [SerializeField] private float minPaddleY = -548f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(moveUp) && paddle.position.y < maxPaddleY)
        {
            paddle.position = new Vector2(paddle.position.x, paddle.position.y + moveSpeed);
        }
        if (Input.GetKey(moveDown) && paddle.position.y > minPaddleY)
        {
            paddle.position = new Vector2(paddle.position.x, paddle.position.y - moveSpeed);
        }
    }
}
