using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject fallingBlockPrefab;
    public float secondsBetweenSpawns = 1;
    float nextSpawnTime;

    public Vector2 spawnSizeMax;

    Vector2 screenHalfSizeWorldUnits;


    // Start is called before the first frame update
    void Start()
    {
        screenHalfSizeWorldUnits = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextSpawnTime){
            nextSpawnTime = Time.time + secondsBetweenSpawns;

            float spawnPosition = Random.Range(spawnSizeMax.x, spawnSizeMax.y);
            spawnPosition = new Vector2(Random.Range(-screenHalfSizeWorldUnits.x, screenHalfSizeWorldUnits.x), screenHalfSizeWorldUnits.y + .5f);
            GameObject newBlock = (GameObject) Instantiate(fallingBlockPrefab, spawnPosition, Quaternion.identity);
            newBlock.transform.localScale = Vector2.one * spawnSize;
        }

    }
}
