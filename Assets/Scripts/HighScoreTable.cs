using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HighScoreTable : MonoBehaviour
{   

    public Text score1;
    public Text name1;
    public Text score2;
    public Text name2;
    public Text score3;
    public Text name3;

    void start()
    {
        score1.text =  (PlayerPrefs.GetFloat("HighScore1",0)).ToString();
        score2.text =  (PlayerPrefs.GetFloat("HighScore2",0)).ToString();
        score3.text =  (PlayerPrefs.GetFloat("HighScore3",0)).ToString();
        name1.text = (PlayerPrefs.GetString("Name1","Player1"));
        name2.text = (PlayerPrefs.GetString("Name2","Player2"));
        name3.text = (PlayerPrefs.GetString("Name3","Player3"));
    }
    public void back()
    {
        SceneManager.LoadScene("Menu");

    }
    public void enter()
    {
        //SceneManager.LoadScene("Leaderboard");
        // name1.text = (PlayerPrefs.GetString("Name1","Player1"));
        // name2.text = (PlayerPrefs.GetString("Name2","Player2"));
        // name3.text = (PlayerPrefs.GetString("Name3","Player3"));
    }


    void Update()
    {
        score1.text =  (PlayerPrefs.GetFloat("HighScore1",0)).ToString();
        score2.text =  (PlayerPrefs.GetFloat("HighScore2",0)).ToString();
        score3.text =  (PlayerPrefs.GetFloat("HighScore3",0)).ToString();
        name1.text = (PlayerPrefs.GetString("Name1","Player1"));
        name2.text = (PlayerPrefs.GetString("Name2","Player2"));
        name3.text = (PlayerPrefs.GetString("Name3","Player3"));
    }
}
