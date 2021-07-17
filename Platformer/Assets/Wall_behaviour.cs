using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_behaviour : MonoBehaviour
{
    public Vector3 pos;
    public GameObject body;
    public Rigidbody2D wall;
    

    // Update is called once per frame
    void Update()
    {
        pos = body.transform.position;
        if(pos.y <= -10){
            
            Destroy(body);
             
        }
    }

    void FixedUpdate(){
        
        wall.velocity = new Vector2(0, -4);

    }
}
