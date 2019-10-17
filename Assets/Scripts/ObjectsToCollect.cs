using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsToCollect : MonoBehaviour
{
    public static int[] keys = new int[3];

    
    public GameObject PickedUpKey;

    void start()
    {
        keys[0] = 0;
        keys[1] = 0;
        keys[2] = 0;
    }
    void OnCollisionEnter(){

        if(PickedUpKey.gameObject.name == "RedKey"){
            keys[0] = 1;
            ////Debug.Log(keys[0]);
            PickedUpKey.gameObject.SetActive(false);
            //Destroy(gameObject);
        }

        if(PickedUpKey.gameObject.name == "PinkKey"){
            keys[1] = 1;
            //Debug.Log(keys[1]);
            PickedUpKey.gameObject.SetActive(false);
            //Destroy(gameObject);
        }

         if(PickedUpKey.gameObject.name == "YellowKey"){
            keys[2] = 1;
            //Debug.Log(keys[2]);
            PickedUpKey.gameObject.SetActive(false);
            //Destroy(gameObject);
        }
        
    }
}
