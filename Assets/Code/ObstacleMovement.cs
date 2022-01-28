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
        rb2d = GetComponent<Rigidbody2D>();
        obstacle = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        rb2d.velocity = new Vector2(-1.0f, 0.0f);

        if(rb2d.position.x  < -1.0f)
        {
        	Debug.Log("Out Of Camera Left");
        	Destroy(gameObject);
        }
    }
}
