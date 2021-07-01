using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondBehaviour : MonoBehaviour
{
    public Vector3 pos;
    public GameObject body;
    public GameObject END_EFFECT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = body.transform.position;
        if(pos.y <= -5){
            Instantiate(END_EFFECT, pos, Quaternion.identity);
            Destroy(body);
             
        }
    }
}
