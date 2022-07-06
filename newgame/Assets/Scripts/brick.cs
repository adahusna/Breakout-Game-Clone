using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class brick : MonoBehaviour
{
    public int hits = 1;
    public int score = 10;


    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        hits--;
        if(hits <= 0)
        {
            Destroy(gameObject);
        }
    }
}
