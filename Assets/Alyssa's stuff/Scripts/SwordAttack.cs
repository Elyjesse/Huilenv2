using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
    public Enemy enemy;
    public float attackRange = 6.0f; // The range of the attack



    void Update()
    {
            RaycastHit hitInfo;

            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, attackRange))
            {
                if (hitInfo.transform.tag == "Enemy")
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log("Enemy hit!");

                    enemy.health -= 10;
                    }
                } 
            }
    }
}
