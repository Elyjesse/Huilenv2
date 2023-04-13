using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 moveDirection;
    public float moveSpeed;
    private float horizontal;
    private float vertical;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        moveDirection.x = horizontal;
        moveDirection.z = vertical;

        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        //translate = local position van rotatie geen translate betekent dat die de wereld coordinatie gebruikt en niet gooed draait

        if (moveDirection == Vector3.zero)
        {
            //idle
            animator.SetFloat("Speed", 0);
        }
        if (moveDirection != Vector3.zero)
        {
            animator.SetFloat("Speed", 0.1f);
        }




    }

}
