using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    Animator animZombie;
    float speed = 10.0f;
    Rigidbody playerRB;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        animZombie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //walk 
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) | Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            animZombie.SetBool("Walk", true);
            animZombie.SetBool("Stop", false);
        }

        //stop walking
        if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow)) {
            animZombie.SetBool("Walk", false);
            animZombie.SetBool("Stop", true);
        }
    }

    void FixedUpdate()
    {
        //movement
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerRB.AddForce(new Vector3 (0,0,5),ForceMode.VelocityChange);
            //rotate
            playerRB.rotation = Quaternion.LookRotation(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerRB.AddForce(new Vector3 (-5,0,0),ForceMode.VelocityChange);
            //rotate
            playerRB.rotation = Quaternion.LookRotation(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            playerRB.AddForce(new Vector3 (5,0,0),ForceMode.VelocityChange);
            //rotate
            playerRB.rotation = Quaternion.LookRotation(Vector3.right);
        }
        
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerRB.AddForce(new Vector3 (0,0,-5),ForceMode.VelocityChange);
            //rotate
            playerRB.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }

    
}
