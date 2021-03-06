﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public HealthBar healthBar;

    private void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void Update() {
        
    }

    public void TakeDamage(int damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if(currentHealth <= 0){
            Destroy(gameObject);
        }
    }
}
