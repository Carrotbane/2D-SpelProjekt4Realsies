using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ()
        {
            
        }
        
        if (Input.GetButton("Vertical"))
        {
            transform.position += new Vector3(
                0, 
                Input.GetAxis("Vertical") / Math.Abs(Input.GetAxis("Vertical")) * Time.deltaTime,
                0);
        }
        if (Input.GetButton("Horizontal"))
        {
            transform.position += new Vector3(
                Input.GetAxis("Horizontal") / Math.Abs(Input.GetAxis("Horizontal")) * Time.deltaTime, 
                0,
                0);
        }
    }
}
