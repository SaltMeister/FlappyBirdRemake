using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
	private Rigidbody2D rb2d;
    private Animator anim;
    public GameObject pipes;
    public bool collision;
    // Start is called before the first frame update
    void Start()
    {
    	rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !collision)
        {
        	anim.SetBool("isClicked", true);
        	rb2d.velocity = new Vector2(0.0f, 0.0f);
        	Debug.Log(rb2d.velocity);
            rb2d.AddForce(transform.up * 1f, ForceMode2D.Impulse );

        }
        else
        {
        	if(rb2d.velocity.y < 0)
        		anim.SetBool("isClicked", false);
        }

    }

    void OnCollisionEnter2D()
    {
        rb2d.gravityScale = 1.0f;
        collision = true;
        GetComponent<Collider2D>().enabled = false;
        rb2d.AddForce(transform.up * 1f, ForceMode2D.Impulse );
    }
}
