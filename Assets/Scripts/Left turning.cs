using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class Joint1 : MonoBehaviour
{

    // this code is to make the lids of the box open

    // variables
    public bool turningOn = false;
    public bool isOpen = false;
    public float startAngle = 0;
    public float endAngle = 178;

    public int counter = 0;

    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    void turn() {
        // check if the door is at the start or the end

        float direction = -1;

        if (isOpen == true) { 
            direction = 1; 
        }
        else { 
            direction = -1; 
        }

        Vector3 rot = transform.eulerAngles;

        rot.z += direction;

        transform.eulerAngles = rot;

        counter++;


        if(counter > endAngle || counter < startAngle)
        {
            turningOn = false;
            counter = 0;
            isOpen = !isOpen;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        // turning on a switch to make the box open when you press space
        if (Input.GetKeyDown(KeyCode.Space)) {
            turningOn = true;
        }

        if (turningOn == true) {

            turn();
        
        }

        
    }
}
