using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownCharacterController2D : MonoBehaviour {
    public float speed = 5.0f;
    Rigidbody2D rigidbody2D;
    // Use this for initialization
    void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        rigidbody2D.velocity = new Vector2(x, y) * speed;
        rigidbody2D.angularVelocity = 0.0f;

    }
}
