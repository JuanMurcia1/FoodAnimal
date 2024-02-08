using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float timeRespawn= 2.0f;
    private float intervalRespawn=1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("respawnRandomAnimals",timeRespawn,intervalRespawn);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.S)){
            respawnRandomAnimals();
        }

        
    }

    void respawnRandomAnimals(){

        int animalIndex =Random.Range(0, animalPrefabs.Length);
        int animalPositionx= Random.Range(-10,10);
        Vector3 respawnPosition= new Vector3(animalPositionx,0,20);

        Instantiate(animalPrefabs[animalIndex], respawnPosition ,animalPrefabs[animalIndex].transform.rotation);

    }
}
