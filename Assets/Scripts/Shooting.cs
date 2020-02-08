﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public Transform firepoint;
    public GameObject Bulletprefab;
    public float bulletforce = 20f;
    
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
        
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(Bulletprefab, firepoint.position, firepoint.rotation);
        Rigidbody2D body = bullet.GetComponent<Rigidbody2D>();
        body.AddForce(firepoint.up * bulletforce, ForceMode2D.Impulse);
    }
}
