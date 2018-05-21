using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AudioManager : MonoBehaviour {


    public void Mute()
        
    {
       
      
    if (AudioListener.pause == true)
        {
            AudioListener.pause = false;
            
        }
     else if (AudioListener.pause == false)
        {
            AudioListener.pause = true;
            
        }
    }
	// Use this for initialization
	void Start () {
        AudioListener.pause = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
