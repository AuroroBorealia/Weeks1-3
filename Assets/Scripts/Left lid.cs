using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class LeftLidTurn : MonoBehaviour
{
    // this code is to make the lids of the box open

    // variables
    bool turningOn = false;
    bool isOpen = false;
    float startAngle = 0;
    float endAngle = 178;

    public int counter = 0;

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

        //actually making the turn happen
        Vector3 rot = transform.eulerAngles;

        rot.z += direction;

        transform.eulerAngles = rot;

        counter++;

        // using the counter to make the lid turn and stop at certain points
        if (counter > endAngle || counter < startAngle)
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            turningOn = !turningOn;
        }

        // activate the void turn
        if (turningOn == true)
        {

            turn();

        }
    }
}
