using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatie : MonoBehaviour
{
    public float mouseX;
    public float mouseY;
    public Vector3 mousePos;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        mousePos.x = -mouseY;
        mousePos.y = mouseX;

        transform.Rotate(mousePos);
    }
}
