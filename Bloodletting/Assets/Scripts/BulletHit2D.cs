using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHit2D : MonoBehaviour {
    public double damage = 1;
    public static double  dpsMultiplier = 1;
    public string damageTag = "";
    void OnTriggerEnter2D(Collider2D other)
    {
        damage = damage * dpsMultiplier;
        if (other.CompareTag(damageTag))
        {
            other.SendMessage("TakeDamage", damage);
        }
        Destroy(gameObject);
    }
        // Use this for initialization
        void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
