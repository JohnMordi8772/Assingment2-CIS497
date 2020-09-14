/** John Mordi* 
 * Assignment #3 Challenge #2* 
 * Detects and destroys a game object on a collision and adjusts score when object is destroyed*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        StatManager.score++;
    }
}
