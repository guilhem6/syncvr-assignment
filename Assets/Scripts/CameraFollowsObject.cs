//Defines the position of the camera during the game

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsObject : MonoBehaviour
{
    //Distance camera - center of the snowball
    public float yOffset = 3;
    public float xOffset = -3;

    //Snowball
    public new GameObject gameObject;

    // Update is called once per frame
    void Update()
    {
        transform.position = gameObject.transform.position + new Vector3(xOffset, yOffset, 0);
    }
}
