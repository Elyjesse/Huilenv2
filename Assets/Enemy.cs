using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int maxHealth = 100; // The maximum health of the GameObject
    private int currentHealth; // The current health of the GameObject

    private void Start()
    {
        currentHealth = maxHealth; // Initialize the current health to the maximum health at the start of the game
    }

    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount; // Subtract the damage amount from the current health

        if (currentHealth <= 0)
        {
            Die(); // If the current health is zero or below, call the Die method
        }
    }

    public void TakeDamage(int damage)
    {
        maxHealth -= damage; // Subtract the damage value from the enemy's health
        if (maxHealth <= 0)
        {
            Die(); // If the enemy's health is zero or below, call the Die method
        }
    }

    private void Die()
    {
        // Perform any necessary actions when the enemy dies, such as playing a death animation or disabling the enemy GameObject
        Destroy(gameObject);
    }
}
