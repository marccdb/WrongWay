using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarsSpawner : MonoBehaviour
{

    public GameObject[] carsPrefab;

    int carIndex;
    float randomPosX;

    //Caching components
    ManageScenes manageScenes;

    [Header("Parameters")]
    [SerializeField] float maxRange = 2.2f; //min and max range for the X axis; 

    //Set the min and max spawn time for the falling objects.
    [SerializeField] float minSpawnTime = 0.5f;
    [SerializeField] float maxSpawnTime = 1;

    void Start()
    {
        manageScenes = FindObjectOfType<ManageScenes>();
        StartCoroutine(WaitToSpawn());
    }

    //coroutine to start the spawning of the objects. There's a random delay between every object.
    IEnumerator WaitToSpawn()
    {
        while (manageScenes.gameOver == false) //when game is over, the spawner stops.
        {
            SpawnCars();
            float randomSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(randomSpawnTime);
        }

    }

    //method to spawn the objects. Random objects at random X axis position.
    private void SpawnCars()
    {
        carIndex = Random.Range(0, carsPrefab.Length);
        randomPosX = Random.Range(-maxRange, maxRange);
        Instantiate(carsPrefab[carIndex], new Vector3(randomPosX, 6.5f, 0), Quaternion.Euler(-180,0,0));
    }



}