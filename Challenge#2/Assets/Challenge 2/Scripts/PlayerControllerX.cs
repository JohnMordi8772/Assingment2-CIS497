/** John Mordi* 
 * Assignment #3 Challenge #2* 
 * Player functions specifically dog spawning*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float previousTime = -10;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && previousTime<= Time.fixedTime-1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            previousTime = Time.fixedTime;
        }
    }
}
