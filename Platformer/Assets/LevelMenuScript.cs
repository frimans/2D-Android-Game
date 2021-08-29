using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelMenuScript : MonoBehaviour
{
    public TMPro.TMP_Text HighScoreText;
    public float highscore;
    // Start is called before the first frame update
    // Test comment
    void Start()
    {
        highscore = PlayerPrefs.GetFloat("HighScore", 0);
        HighScoreText.text = highscore.ToString("#.00");
    }

    
}
