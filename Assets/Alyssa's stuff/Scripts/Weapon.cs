using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Camera Camera;
    public float rayDistance;
    public float distance;
    public GameObject target;

    CursorLockMode cursorlock;
    // Start is called before the first frame update
    void Start()
    {
        cursorlock = CursorLockMode.Locked; 
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
