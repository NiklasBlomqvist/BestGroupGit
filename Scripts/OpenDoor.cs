using UnityEngine;
using System.Collections;

public class OpenDoor : MonoBehaviour {
    bool isOpen = false;

	// Use this for initialization

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void openDoor()
    {
        if(isOpen == false && !GetComponent<Animation>().IsPlaying("OpenDoor"))
        {
            // Sets time to start animation, what speed and then plays it
            GetComponent<Animation>()["OpenDoor"].time = 0.0f;
            GetComponent<Animation>()["OpenDoor"].speed = 1.0f;
            GetComponent<Animation>().Play();
            //GetComponent<AudioSource>().Play();
            isOpen = true;
        }
        else if (isOpen == true && !GetComponent<Animation>().IsPlaying("OpenDoor"))
        {
            GetComponent<Animation>()["OpenDoor"].time = GetComponent<Animation>()["OpenDoor"].length;
            GetComponent<Animation>()["OpenDoor"].speed = -1.0f;
            GetComponent<Animation>().Play();
            isOpen = false;
        }
    }


}