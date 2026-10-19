using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PocketSpawnPrefab : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnpoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnPrefab()
    {
        Instantiate(prefab, spawnpoint.position, Quaternion.identity);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "L_Pointer_end")
        {
            SpawnPrefab();
        }
    }
}
