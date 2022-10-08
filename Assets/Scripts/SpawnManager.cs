using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float stratdelay = 2;
    private float spwanInterval = 1.5f;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", stratdelay, spwanInterval);  // פונקציה שמפעילה את הפונקציה שאנו רוצים עם קביעה ממתי זה מתחיל וכל כמה זמן זה יופעל
    }

    // Update is called once per frame


    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanpos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[animalIndex], spwanpos, animalPrefabs[animalIndex].transform.rotation);
    }
}
