using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Points_andgameover : MonoBehaviour
{
    //public Rigidbody2D Player;
    //public int Points;
    //public bool Gameover = false;
    public float timer = 0.0f;
    public int hits = 0;
    public GameObject END_EFFECT;
    public GameObject LOSE_LIFE;
    public Vector3 pos;
    public GameObject body;
    public AudioSource Boom;
    public AudioSource Music;
    public GameObject FailMenu;

    void Start()
    {
        FailMenu.SetActive(false);
    }

    
    

    void OnCollisionEnter2D()
    {
        hits = hits +1;
        //Check for a match with the specified name on any GameObject that collides with your GameObject
        pos = body.transform.position;
        
        if(hits == 1){
            Debug.Log("Hit something! Ouch!");
            Instantiate(LOSE_LIFE, pos, Quaternion.identity);
        }
        else{
            Instantiate(END_EFFECT, pos, Quaternion.identity);
            Boom.Play();
            Music.Stop();
            Invoke("Show_pause_menu", 1);
        }

        //Time.timeScale = 0;
        
        ///SceneManager.LoadScene("LevelMenu");


    }

    public void Show_pause_menu()
    {
        Time.timeScale = 0f;
        FailMenu.SetActive(true);
        
    }

    

    

    
}
