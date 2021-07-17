using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiating : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject myPrefab2;
    public GameObject spacer;
    public float prev = 0.0f;
    public float timer = 0.0f;
    public float Game_time = 0.0f;
    public float Empty = 0.0f;
    public int Start_screen;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        Game_time += Time.deltaTime;
        timer += Time.deltaTime;

        if((Start_screen ==1) & (0.3f < timer)){

            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            timer = 0.0f;

        }

        if(Start_screen == 0){
            if((Game_time < 5) & (0.3f < timer)){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            timer = 0.0f;
        }

        else if((2.8f < timer) & (Game_time < 30)){
            if (prev == 0.0f){
                Empty = Random.Range(-1.75f, 1.75f);
                Instantiate(myPrefab2, new Vector3(Empty + 3.2f, 11.39f, 0f),Quaternion.identity);
                Instantiate(myPrefab2, new Vector3(Empty - 3.2f, 11.39f, 0f),Quaternion.identity);
            }
            else if((prev < 0f)){
                Empty = Random.Range(prev + 1.4f, 1.75f);
                GameObject GabSpacer = Instantiate(spacer, new Vector3((prev+Empty)/2f,5.7f,0f), Quaternion.identity) as GameObject;
                GabSpacer.transform.localScale = new Vector3((-prev+Empty)-1.42f, 1.4f, 1f); // change its local scale in x y z format
 
                Instantiate(myPrefab2, new Vector3(Empty + 3.2f, 11.39f, 0f),Quaternion.identity);
                Instantiate(myPrefab2, new Vector3(Empty - 3.2f, 11.39f, 0f),Quaternion.identity);
                
            }
            else{
                Empty = Random.Range(-1.75f, prev  -1.4f);
                GameObject GabSpacer = Instantiate(spacer, new Vector3((prev+Empty)/2f,5.7f,0f), Quaternion.identity) as GameObject;
                GabSpacer.transform.localScale = new Vector3((prev-Empty)-1.42f, 1.39f, 1f); // change its local scale in x y z format
 
                Instantiate(myPrefab2, new Vector3(Empty + 3.2f, 11.4f, 0f),Quaternion.identity);
                Instantiate(myPrefab2, new Vector3(Empty - 3.2f, 11.4f, 0f),Quaternion.identity);

            }
            
            prev = Empty;
            
            timer = 0.0f;
        }
        else if ((0.3f < timer) & (Game_time >33)){
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            timer = 0.0f;

        }

        }
        
        

        
    }
}
