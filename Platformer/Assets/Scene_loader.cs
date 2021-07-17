using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    public void LoadScene(){
        // Current secene
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "Start_screen"){
            SceneManager.LoadScene("LevelMenu");

        }
        else{
            SceneManager.LoadScene("SampleScene");

        }

        
    }
    
}
