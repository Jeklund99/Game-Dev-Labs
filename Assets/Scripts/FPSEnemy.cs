using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSEnemy : MonoBehaviour
{
    [SerializeField] private Transform enemy;
    [SerializeField] private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPos = FPSPlayer.instance.transform.position;
        enemy.LookAt(playerPos);
        Vector3 currentRotation = enemy.rotation.eulerAngles;
        enemy.eulerAngles = currentRotation;

        Vector3 directionToPlayer = (playerPos - enemy.position).normalized;
        enemy.position += (directionToPlayer * moveSpeed * Time.deltaTime).SetY(0);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            FPSPlayer.instance.HandleEnemyDefeat();
        }
    }
}
