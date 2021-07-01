using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public Rigidbody2D body;
    public Slider control;
    double x;
    float X;
    float Y = -3f;
    float Z = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = control.value;
        X = (float)x;
        body.position = new Vector3(X, Y, Z);
    }
}
