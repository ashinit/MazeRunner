using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score1;
    public Text name1;
    public Text score2;
    public Text name2;
    public Text score3;
    public Text name3;
    public InputField userEntry;

    //public float score;
    //public float highScore2;
    //public float highScore3;
    //public float highScore1;
    //public string FirstName;

    string highScoreKey = "HighScore";
    //public string name;
    //public bool empty1 = true;
    //public bool empty2 = true;
    //public bool empty3 = true;
    //int count = 1;
    //List<float> topScores = new List<float>(3);

    

    // Start is called before the first frame update
    void Start()
    {
        score1.text = PlayerPrefs.GetFloat("EndTime", 0).ToString();
        name1.text = (PlayerPrefs.GetString("Name", "Player")); 
        //Debug.Log(highScore1);  
    }

    void Update()
    {
        // score = PlayerPrefs.GetFloat("EndTime", float.MaxValue);

        
        // Debug.Log(score);
        // //Debug.Log(highScore1);
        // if(score<highScore1){
        //     Debug.Log("Here");
        //     //score = score*-1;
        //     highScore1 = PlayerPrefs.GetFloat("EndTime", 0);
        //    // count =2;
        // }
        
        //score1.text = PlayerPrefs.GetFloat("EndTime", 0).ToString();
        //name1.text = (PlayerPrefs.GetString("Name", "Player")); 
        //score2.text = highScore1.ToString();
        //name2.text = (PlayerPrefs.GetString("Name", "Player")); 
        //score3.text = highScore1.ToString();
        //name3.text = (PlayerPrefs.GetString("Name", "Player")); 

         
    }
}



// if ((score < highScore1))
//                 {
                    
//                     if ((score < highScore2))
//                     {
                        
//                         if ((score < highScore1))
//                         {
//                             name1.text = (PlayerPrefs.GetString("Name", "Player")); 
//                             highScore1 = 
//                             Debug.Log("here");
                  
//                          }
//                          name2.text = (PlayerPrefs.GetString("Name", "Player")); 
//                         highScore2 = (PlayerPrefs.GetFloat("EndTime", 0));
//                     }
//                     name3.text = (PlayerPrefs.GetString("Name", "Player")); 
//                     highScore3 = (PlayerPrefs.GetFloat("EndTime", 50000));
//                 }
