using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class player_controller : MonoBehaviour
{
	private Rigidbody2D rb2d;
    private Animator anim;
    public GameObject button;
    public GameObject pipes;
    public Text score;
    public bool collision;
    public bool paused;
    private int scoreCounter;
    // Start is called before the first frame update
    void Start()
    {
        scoreCounter = 0;
        paused = false;
    	rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collision = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Fire1") && !collision) && !paused)
        {
        	anim.SetBool("isClicked", true);
        	rb2d.velocity = new Vector2(0.0f, 0.0f);
        	//Debug.Log(button.transform.position);
            //Debug.Log(Input.mousePosition);
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
        //removes player collision
        GetComponent<Collider2D>().enabled = false;
        rb2d.AddForce(transform.up * 1f, ForceMode2D.Impulse );
    }

    public void updateScore()
    {
        scoreCounter++;
        Debug.Log("Score is: " + scoreCounter );
        score.text = "Score: " + scoreCounter;
    }
}
