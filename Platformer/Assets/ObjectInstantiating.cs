using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInstantiating : MonoBehaviour
{
    public GameObject myPrefab;
    public float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(myPrefab, new Vector3(0, 3, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if( 0.3f < timer ){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
            timer = 0.0f;
        }

        /*
         if( 0.2f < timer && timer < Time.deltaTime + 0.2f ){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }


        if( 0.5f < timer && timer < Time.deltaTime + 0.5f ){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }

        
        if( 1.0f < timer && timer < Time.deltaTime + 1.0f ){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }
        if(1.2f < timer && timer < Time.deltaTime + 1.2f){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }
        if(1.8f < timer && timer < Time.deltaTime + 1.8f){
            
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }
        if(timer >= 2.0f){
            timer = 0.0f;
            Instantiate(myPrefab, new Vector3(Random.Range(-1.8f, 1.8f), 6, 0), Quaternion.Euler(0.0f, 0.0f, Random.Range(0.0f, 360.0f)));
        }
        */
    }
}
