using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public float attackRange = 2.0f; // The range of the attack

    private bool isAttacking = false; // Indicates if the player is currently attacking
    private float attackTimer = 0.0f; // Timer to track the duration of the attack

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            attackTimer = 0.0f;
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, attackRange))
            {
                if (hitInfo.collider.gameObject.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy hit!");

                    // Do damage to the enemy
                   hitInfo.collider.gameObject.GetComponent<Enemy>().TakeDamage(10);
                }
            }
        }

        // Update the attack timer and check if the attack has ended
        if (isAttacking)
        {
            attackTimer += Time.deltaTime;

          
        }
    }
}
