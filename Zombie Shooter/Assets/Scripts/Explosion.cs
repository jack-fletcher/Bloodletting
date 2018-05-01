using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public float destroyTime = 0.7f;
    void Start()
    {
        Invoke("Die", destroyTime);
    }
    void Die()
    {
        Destroy(gameObject);
    }
}