using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject tommy;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        tommy.GetComponent<Animator>().SetBool("Jump", false);
        tommy.GetComponent<AWSD>().grounded = true;
    }
}
