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
        if(isOpen == false && !GetComponent<Animation>().IsPlaying("door_animation"))
        {
            // Sets time to start animation, what speed and then plays it
            GetComponent<Animation>()["door_animation"].time = 0.0f;
            GetComponent<Animation>()["door_animation"].speed = 1.0f;
            GetComponent<Animation>().Play();
            GetComponent<AudioSource>().Play();
            isOpen = true;
        }
        else if (isOpen == true && !GetComponent<Animation>().IsPlaying("door_animation"))
        {
            GetComponent<Animation>()["door_animation"].time = GetComponent<Animation>()["door_animation"].length;
            GetComponent<Animation>()["door_animation"].speed = -1.0f;
            GetComponent<Animation>().Play();
            isOpen = false;
        }
    }


}