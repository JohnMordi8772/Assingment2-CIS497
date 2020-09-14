/** John Mordi* 
 * Assignment #3 Prototype #2* 
 * Manages the spawning of animals at random positions*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] preFabsToSpawn;

    private float rightBound = 14;
    private float leftBound = -14;
    private float spawnPosZ = 20;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        //step 5
        //Make the spawning happen continuously without input
        //InvokeRepeating("spawnRandomPreFab", 2, 1.5f);

        StartCoroutine(SpawnRandomPreFabWithCoroutine());
    }

    //step 6
    //Spawns continuously without input but with an end
    IEnumerator SpawnRandomPreFabWithCoroutine()
    {
        yield return new WaitForSeconds(3f);

        while(!gameOver)
        {
            spawnRandomPreFab();

            yield return new WaitForSeconds(1.5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
        //step 1
        //calls first prefab in the array to spawn
        if(Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(preFabsToSpawn[0], new Vector3(0, 0, 20), preFabsToSpawn[0].transform.rotation);
        }
        

        //step 2
        //call random prefab to spawn
        if (Input.GetKeyDown(KeyCode.S))
        {
            int preFabIndex = Random.Range(0, preFabsToSpawn.Length);

            Instantiate(preFabsToSpawn[preFabIndex], new Vector3(0, 0, 20), preFabsToSpawn[preFabIndex].transform.rotation);
        }
        

        //step 3
        //spawn the random prefabs in different positions
        if (Input.GetKeyDown(KeyCode.S))
        {
            int preFabIndex = Random.Range(0, preFabsToSpawn.Length);

            Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

            Instantiate(preFabsToSpawn[preFabIndex], spawnPos, preFabsToSpawn[preFabIndex].transform.rotation);
        }

        //step 4
        //transfer functions to a method
        if (Input.GetKeyDown(KeyCode.S))
        {
            spawnRandomPreFab();
        }*/
    }


    void spawnRandomPreFab()
    {
        int preFabIndex = Random.Range(0, preFabsToSpawn.Length);

        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        Instantiate(preFabsToSpawn[preFabIndex], spawnPos, preFabsToSpawn[preFabIndex].transform.rotation);
    }
}
