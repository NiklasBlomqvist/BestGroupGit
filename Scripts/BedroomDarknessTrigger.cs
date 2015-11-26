using UnityEngine;
using System.Collections;

public class BedroomDarknessTrigger : MonoBehaviour
{
    private float originalAmbientIntensity;

    // Use this for initialization
    void Start()
    {
        originalAmbientIntensity = RenderSettings.ambientIntensity;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider)
    {
        // When the player enters the trigger area --> Lights go out and the door is closed
        RenderSettings.ambientIntensity = 0;
        //GameObject.Find("BedroomDoor").GetComponent<OpenDoor>().closeThisDoor();
        GameObject.Find("BedroomDoor").GetComponent<OpenDoor>().closeThisDoor();
    }
}
