using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour
{
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnCollisionEnter2D()
    {
        Destroy(spawner);
    }
}
