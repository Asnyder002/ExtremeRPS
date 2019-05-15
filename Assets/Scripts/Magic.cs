using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }

    void Shoot()
    {
        // shooting logic
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
    }
}
