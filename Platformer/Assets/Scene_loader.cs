using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_loader : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("SampleScene");
    }
    
}
