using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSGunScript : MonoBehaviour
{
    [SerializeField] private Transform gunTransform;

    [SerializeField] private Transform shootPosition;

    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }

    }

    private void Fire()
    {
        GameObject bulletPrefab = bullet;
        GameObject newBullet = Instantiate(bulletPrefab);
        newBullet.transform.SetPositionAndRotation(shootPosition.position, shootPosition.rotation);
    }
}
