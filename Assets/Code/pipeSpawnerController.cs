using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawnerController : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject spawner;
    GameObject player;
    player_controller playerController;
    public GameObject pipe;
    public float pipeInterval;
    private float timer = 0.0f;
    private float randomPosY;
    private Vector3 pos;
    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<player_controller>();
        //pos = gameObject.transform.position;
        Debug.Log(gameObject.transform.position.x);
        
        //spawns a pipe
        Instantiate(pipe);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + Random.Range(-1.0f, -0.2f), 0);
        //when pass timer, spawn pipe at random y position
        if(timer > pipeInterval)
        {
            Instantiate(pipe, pos, transform.rotation);
            timer = 0.0f;
        }
        
        if(playerController.collision == true)
            Destroy(gameObject);
    }
}
