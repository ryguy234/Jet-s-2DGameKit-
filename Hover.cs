using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hover : MonoBehaviour
{

    public float hoverPower = 300;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * hoverPower);
        }
    }
}