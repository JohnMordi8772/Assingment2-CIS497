﻿/** John Mordi* 
 * Assignment #3 Prototype #2* 
 * Destroys entities that move out of bounds*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z >= topBound)
        {
            Destroy(gameObject);
        }
        if(transform.position.z <= bottomBound)
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
