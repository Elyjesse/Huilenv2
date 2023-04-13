using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed;
    public float horizontal;
    public float vertical;
    public Vector3 moveDirection;
    public float timer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDirection.x = horizontal;
        moveDirection.z = vertical;
        timer += Time.deltaTime;



        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);

    }
}
