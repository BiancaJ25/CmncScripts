using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    //private PlayerController playerControllerScript;
    [SerializeField] PlayerController playerController;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstable", startDelay, repeatRate);
    }

    void SpawnObstable ()
    {
        if (!playerController.IsGameOver()) {
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    } 
}
