using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DisplayScore : MonoBehaviour
{

    float score = 0f;

    float highScore = 0;
    string highScoreKey = "";
    string nameEntered="";
    public InputField userEntry;
    string nameKey="";
    bool IncreaseTime;


    public Text name1;
    public Text name2;
    public Text name3;

    void Start(){ 
        score = PlayerPrefs.GetFloat("highScore0",float.MaxValue);
     }


    void OnDisable()
    {

        //TO RESET PLAYERPREFS AND HIGHSCHORES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //PlayerPrefs.DeleteAll();
        int i;
        //nameEntered = userEntry.text;
        for (i = 1 ; i<=4; i++)
        {
            highScoreKey = "HighScore"+(i).ToString();
            highScore = PlayerPrefs.GetFloat(highScoreKey,float.MaxValue);
            nameKey = "Name"+(i).ToString();

            if(score < highScore)
            {
                PlayerPrefs.SetFloat(highScoreKey,score);
                PlayerPrefs.Save();
                       
                break;
                
            }
            
            
        }
        PlayerPrefs.SetString(nameKey,userEntry.text);
        PlayerPrefs.Save();
        if (i ==1){
            name1.text = (PlayerPrefs.GetString("Name1","Player1"));
        }

        if  (i ==2){
            name1.text = (PlayerPrefs.GetString("Name2","Player2"));
        }
        if (i ==3){
            name1.text = (PlayerPrefs.GetString("Name3","Player3"));
        }
        // name1.text = (PlayerPrefs.GetString("Name1","Player1"));
        // name2.text = (PlayerPrefs.GetString("Name2","Player2"));
        // name3.text = (PlayerPrefs.GetString("Name3","Player3"));
             
    }
}