using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 


public class player_control : MonoBehaviour
{
    public Rigidbody2D body;
    public FloatingJoystick stic;
    float horizontal;
    float vertical;
    float runSpeed = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = stic.Horizontal;
        vertical = stic.Vertical;
        
        
    }

    void FixedUpdate(){
        
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);

    }
}
