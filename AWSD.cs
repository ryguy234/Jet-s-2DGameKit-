using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AWSD : MonoBehaviour
{
    public float speed = 20f;
    public Vector2 up = new Vector2(0f,1f);
    public bool grounded;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Grounded")
        {
            grounded = true;
            GetComponent<Animator>().SetBool("Jump", false);
        }
    }


    void Update()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Animator animator = GetComponent<Animator>();
        float h = Input.GetAxisRaw("Horizontal");

        //JUMP
        if ((Input.GetButtonDown("Jump")) & grounded == true)
        {
            rb.AddForce(up);
            grounded = false;
            animator.SetBool("Jump", true);
        }


        //RIGHT
        if ((h > .2) || (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") > 0))
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0); //flip sprite back
            rb.linearVelocity = new Vector2(speed, GetComponent<Rigidbody2D>().linearVelocity.y);
            animator.SetBool("Move", true);
        }
        //LEFT
        if ((h < -.2) || (Input.GetButton("Horizontal") && Input.GetAxisRaw("Horizontal") < 0))
        {
            rb.linearVelocity = new Vector2(-speed, GetComponent<Rigidbody2D>().linearVelocity.y);
            transform.localRotation = Quaternion.Euler(0, 180, 0); //flip sprite
            animator.SetBool("Move", true);
        }
        if ((h > -.2 && h < .2) || (Input.GetButtonUp("Horizontal")))
        {
            animator.SetBool("Move", false);
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }
        //SET IDLE
        if (grounded == false)
        {
            animator.SetBool("Move", false);
        }
    }
}
