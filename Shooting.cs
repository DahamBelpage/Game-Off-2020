﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;

    private void Update() {
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            Shoot();
        }
    }

    void Shoot(){
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
