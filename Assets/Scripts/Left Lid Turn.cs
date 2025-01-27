using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLidTurn : MonoBehaviour
{
    // this code is to make the lids of the box open

    // variables
    bool turningOn = false;
    bool isOpen = false;
    float startAngle = 0;
    float endAngle = -178;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void turn()
    {
        // check if the door is at the start or the end

        float direction = 1;

        if (isOpen == true)
        {
            direction = -1;
        }
        else
        {
            direction = 1;
        }

        Vector3 rot = transform.eulerAngles;

        rot.z += direction;

        transform.eulerAngles = rot;
    }

    // Update is called once per frame
    void Update()
    {
        // turning on a switch to make the box open when you press space
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turningOn = !turningOn;
        }

        if (turningOn == true)
        {

            turn();

        }
    }
}
