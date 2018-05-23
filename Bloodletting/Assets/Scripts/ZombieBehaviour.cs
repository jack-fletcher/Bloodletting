using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieBehaviour : MonoBehaviour {
    public int killPoints = 1;
    public int health = 10;
    public int dotDamage = 1;
    public double damageDelay = 1.0;
    public double lastDamage = -10.0;
    public int damage = 2;
    public GameObject explosionPrefab;
    public float adjustExplosionAngle = 0.0f;

    private Transform player;

    // Use this for initialization
    void Start () {
        if (GameObject.FindWithTag("Player"))
        {
            player = GameObject.FindWithTag("Player").transform;
            GetComponent<MoveTowardsObject>().target = player;
            GetComponent<SmoothLookAtTarget2D>().target = player;
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            other.gameObject.SendMessage("TakeDamage", damage);
        }
    }
    void OnCollisionStay2D(Collision2D other)
    {
       
        if (other.gameObject.CompareTag("Player"))
        {
            
            if (Time.time > damageDelay+lastDamage){

                other.gameObject.SendMessage("TakeDamage", dotDamage);
                lastDamage = Time.time;
            }
        }

    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
    // Update is called once per frame
    void Update () {
		
	}

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Quaternion newRot = Quaternion.Euler(transform.eulerAngles.x,
                                                 transform.eulerAngles.y,
                                                 transform.eulerAngles.z + adjustExplosionAngle);
            Instantiate(explosionPrefab, transform.position, newRot);
            GameUI.killPoints += killPoints;
            GetComponent<AddScore>().DoSendScore();
           
            Destroy(gameObject);
            
        }
    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        GetComponent<Rigidbody2D>().angularVelocity = 0.0f;
    }
}
