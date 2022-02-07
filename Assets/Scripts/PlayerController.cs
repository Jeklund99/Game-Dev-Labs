using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidBody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            mainSpriteRenderer.flipX = true;
            mainRigidBody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            mainSpriteRenderer.flipX = false;
            mainRigidBody.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            mainRigidBody.AddForce(new Vector2(0, 200));
        }
       
    }
}
