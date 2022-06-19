//Manages the side moves of the snowball

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballMove : MonoBehaviour
{
    public float zRange = 35;
    //public float horizontalInput;
    public float speed = 4.0f;


    // Update is called once per frame
    void Update()
    {
        //Horizontal control
        if (Input.GetKey("right"))
        {
        GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
        }
        if (Input.GetKey("left"))
        {
        GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
        }
        //Side limits
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y,-zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
