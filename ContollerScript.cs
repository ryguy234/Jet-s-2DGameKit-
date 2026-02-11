using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContollerScript : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("joystick button 16"))
        {
            print("Booya");
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            print("Move Right");
        }
    }
}
