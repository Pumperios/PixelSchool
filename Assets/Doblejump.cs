using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doblejump : MonoBehaviour {

    private bool DobleJump; 
    public bool grounded;
    private Animator anim;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        anim.SetFloat("Speed", Mathf.Abs(rb2d.velocity.x));
        anim.SetBool("Grouded", grounded);
        
    }
    void OnCollisionEnter2D(Collision2D col)
    {

    }
}
