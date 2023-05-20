using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject busPrefab;
    public GameObject carPrefab;
    public GameObject tankPrefab;

    private Vector3 busSpawnPos = new Vector3(90, 0.1f, 110);
    private Vector3 carSpawnPos = new Vector3(-90, 0.1f, 100);
    private Vector3 tankSpawnPos = new Vector3(90, 0.1f, 223);
    private float startDelay = 2f;
    private float repeatDelay = 2f; 
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBus", startDelay, repeatDelay);
        InvokeRepeating("SpawnCar", startDelay, repeatDelay);
        InvokeRepeating("SpawnTank", startDelay * 1.5f, repeatDelay * 1.5f);
    }
    void SpawnBus()
    {
        Instantiate(busPrefab, busSpawnPos, busPrefab.transform.rotation);
    }
    void SpawnCar()
    {
        Instantiate(carPrefab, carSpawnPos, carPrefab.transform.rotation);
    }
     void SpawnTank()
    {
        Instantiate(tankPrefab, tankSpawnPos, tankPrefab.transform.rotation);
    }
}
