using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormMove : MonoBehaviour
{
    public float zMove = 0.5f;
    public float yMove = 3f;
    public float jumpHeight = 0.5f;

    void Update()
    {

        //player movement
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, -zMove);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, zMove);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -yMove, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, yMove, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(0, jumpHeight, 0, Space.World);
        }

    }
}


