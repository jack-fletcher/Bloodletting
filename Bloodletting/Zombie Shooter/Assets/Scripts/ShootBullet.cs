using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{

    public static float maxClipSize = 10;
    public static float clipSize = 10;
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public float fireTime = 0.5f;
    private bool isFiring = false;
    void SetFiring()
        
   
    {
        isFiring = false;
    }
    public void Fire()

    {
        
        if (clipSize > 0)
        {
            isFiring = true;
            clipSize = clipSize - 1;
            
            Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);
            if (GetComponent<AudioSource>() != null)
            {
                GetComponent<AudioSource>().Play();
            }
            Invoke("SetFiring", fireTime);
        }
    }
    // Use this for initialization
    void Start()
    {

    }
    void Reload()
    {
        clipSize = maxClipSize;
    }
    // Update is called once per frame
    void Update() { 
    if (Input.GetKeyDown(KeyCode.R)) {
          
            
                clipSize = maxClipSize;
               
            
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (!isFiring)
            {
                Fire();
            }
        }
    }

}

