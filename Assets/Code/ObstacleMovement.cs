using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rb2d;
    GameObject obstacle;
    void Start()
    {
    	//setting variabes to their game components for later use
        rb2d = GetComponent<Rigidbody2D>();
        obstacle = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(-1.0f, 0.0f);
        //check if pipe position is outside of camera
        if(rb2d.position.x  < -1.0f)
        {
        	//Debug.Log("Out Of Camera Left");
        	//destroy pipes
        	Destroy(gameObject);
        }
    }
}
