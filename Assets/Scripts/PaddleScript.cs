using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    // ===== Variable declaration to hold reference to Transform class component named "MyPaddleTransform"
    //public Transform MyPaddleTransform;

    // ===== Start is called before the first frame update
    void Start()
    {

    }

    // ===== Update is called once per frame
    void Update()
    {
        // ===== Check to see the user is holding down the LeftArrow key
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            // ===== Move the paddle's position by -10 units in the x direction every second
            //MyPaddleTransform.position += new Vector3(-10, 0, 0) * Time.deltaTime;
        }

        // ===== Check to see the user is holding down the RightArrow key
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // ===== Move the paddle's position by +10 units in the x direction every second
            //MyPaddleTransform.position += new Vector3(10, 0, 0) * Time.deltaTime;
        }
    }
}
