using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour
{
    public Transform firePoint;
    public GameObject fireballPrefab;
    public GameObject rockPrefab;
    public GameObject paperPrefab;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            ShootScissors();
        }
        if(Input.GetButtonDown("Fire2"))
        {
            ShootRock();
        }
        if(Input.GetButtonDown("Fire3"))
        {
            ShootPaper();
        }
        
    }

    void ShootScissors()
    {
        // shooting logic
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
    }

    void ShootRock()
    {
        Instantiate(rockPrefab, firePoint.position, firePoint.rotation);
    }

    void ShootPaper()
    {
        Instantiate(paperPrefab, firePoint.position, firePoint.rotation);
    }
}
