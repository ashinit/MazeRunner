using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoors : MonoBehaviour
{
    public GameObject DoorColour;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(){
        //check if the correct key is picked up
        if (DoorColour.gameObject.name == "RedDoor" && ObjectsToCollect.keys[0] == 1)
        {
            
            DoorColour.gameObject.SetActive(false);
           
        }
        if (DoorColour.gameObject.name == "YellowDoor" && ObjectsToCollect.keys[2] == 1)
        {
           
            DoorColour.gameObject.SetActive(false);
            
        }
        if (DoorColour.gameObject.name == "PinkDoor" && ObjectsToCollect.keys[1] == 1)
        {
            
            DoorColour.gameObject.SetActive(false);
          
        }
    }
}
