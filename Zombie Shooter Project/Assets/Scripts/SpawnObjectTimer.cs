using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectTimer : MonoBehaviour
{
    public float spawnTime = 5.0f;
    void Start()
    {
        Invoke("DoSpawn", spawnTime);
    }
    void DoSpawn()
    {
        SendMessage("Spawn");
        Invoke("DoSpawn", spawnTime);
    }
}
