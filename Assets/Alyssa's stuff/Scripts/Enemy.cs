using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject slime;

    public void Start()
    {
        health = 30;
        slime.SetActive(true);
    }
    public void Update()
    {
        if (health <= 0)
        {
            slime.SetActive(false);
        }
    }

}
