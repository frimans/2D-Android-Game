using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class FailMenucontrol : MonoBehaviour
{
   

    // Update is called once per frame
    void Update()
    {

        
    }

    public void returnLevel(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("LevelMenu");
    }

    public void restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");

    }
}
