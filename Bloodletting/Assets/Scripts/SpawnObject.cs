using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{

    public GameObject objectPrefab;
    public void Spawn()
    {
        Instantiate(objectPrefab, transform.position, transform.rotation);
    }

}