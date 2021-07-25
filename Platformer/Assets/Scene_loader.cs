using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    public Button button;
    public void LoadScene(){
        // Current secene
        Scene scene = SceneManager.GetActiveScene();

        if(scene.name == "Start_screen"){
            SceneManager.LoadScene("LevelMenu");

        }

        else if(scene.name == "LevelMenu"){
            if(button.name == "Back_button"){SceneManager.LoadScene("Start_screen");}
            else{SceneManager.LoadScene("SampleScene");}
            
        }

        
    }
    
}
