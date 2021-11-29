using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    float xSpeed = 0.0f;
    float ySpeed = 0.0f;
    float zSpeed = 0.0f;
    public bool rotateMe = false; //set to private if building on android for testing
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotateMe)
            ySpeed = 40;
        else
            ySpeed = 0;

        transform.Rotate(xSpeed * Time.deltaTime, ySpeed * Time.deltaTime, zSpeed * Time.deltaTime );
    }

    public void changeBool()
    {
        rotateMe = !rotateMe;
    }
}
