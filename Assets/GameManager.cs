using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

 
    float score = 0f;
    bool IncreaseTime;
    public Text time;


    
    void Start(){ 
        score = 0.0f;
        IncreaseTime = true;
     }
    public void GameWon()
    {
        IncreaseTime = false;
        //open leaderbaord scene
        //SceneManager.LoadScene("Leaderboard");


    }
    void FixedUpdate()
    {
        if(IncreaseTime == true)
        {
            score += Time.deltaTime;
            time.text = "Score: " + (score).ToString(); 
        }
        if(IncreaseTime == false)
        {
            Debug.Log("Here");
            PlayerPrefs.SetFloat("highScore0",score);
            PlayerPrefs.Save();
            SceneManager.LoadScene("Leaderboard");

        }
    }
    


}

        