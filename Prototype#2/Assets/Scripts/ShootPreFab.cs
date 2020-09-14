/** John Mordi* 
 * Assignment #3 Prototype #2* 
 * Shoots entity forward when the player presses space*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPreFab : MonoBehaviour
{
    public GameObject preFabToShoot;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(preFabToShoot, transform.position, transform.rotation);
        }
    }
}
