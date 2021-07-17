using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points_andgameover : MonoBehaviour
{
    //public Rigidbody2D Player;
    //public int Points;
    //public bool Gameover = false;
    void Start()
    {
        Debug.Log("Hit something! Ouch!");
    }
    

    void OnCollisionEnter2D()
    {
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        Debug.Log("Hit something! Ouch!");
        SceneManager.LoadScene("LevelMenu");


    }
}
