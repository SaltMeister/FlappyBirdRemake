using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseController : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject player;
    player_controller playerController;
    void Start()
    {
        player = GameObject.Find("Player");
        playerController = player.GetComponent<player_controller>();
    }
    void Update()
    {

    }
    public void pauseControl()
    {
        if(Time.timeScale != 0)
        {
            playerController.paused = true;
            Time.timeScale = 0;
            
        } 
        else
        {
            Time.timeScale = 1;
            playerController.paused = false;   
        } 
    }
}
