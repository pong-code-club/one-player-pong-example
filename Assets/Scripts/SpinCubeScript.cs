using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Inside Start Function"); 
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Inside Update Function");
        //GetComponent<Transform>().position = GetComponent<Transform>().position + new Vector3(1, 0, 0) * Time.deltaTime;
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
            //Debug.Log("Clicked Right Arrow");
            //GetComponent<Transform>().position += new Vector3(1, 0, 0) * Time.deltaTime;
        //}

        //clicking right arrow
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("Clicked Right Arrow");
            GetComponent<Transform>().position += new Vector3(5, 0, 0) * Time.deltaTime;
        }

        //clicking left arrow
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("Clicked Left Arrow");
            GetComponent<Transform>().position += new Vector3(-5, 0, 0) * Time.deltaTime;
        }

        //clicking up arrow
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Debug.Log("Clicked Up Arrow");
            GetComponent<Transform>().position += new Vector3(0, 5, 0) * Time.deltaTime;
        }

        //clicking down arrow
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Debug.Log("Clicked Down Arrow");
            GetComponent<Transform>().position += new Vector3(0, -5, 0) * Time.deltaTime;
        }
    }
}
