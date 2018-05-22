using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2D : MonoBehaviour
{

    public float speed = 5.0f;
    public float destroyTime = 2.0f;
    void Start()
    {
        
        Invoke("Die", destroyTime);
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        CancelInvoke("Die");
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
    }
}
