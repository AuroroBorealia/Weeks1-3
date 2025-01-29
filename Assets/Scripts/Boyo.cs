using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Boyo : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    bool isHere = false;
    float direction = 1;
    public Transform rest;
    public Transform jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        

        if(Input.GetKeyDown(KeyCode.Space))
        {

            isHere = true;
        }

        if(isHere == true)
        {
            t += Time.deltaTime * direction;
            transform.position = Vector2.Lerp(rest.position, jump.position, curve.Evaluate(t));
            if(t > 1)
            {
                isHere = false;
                direction = -1;
            }
            if(t < 0)
            {
                isHere = false;
                direction = 1;
            }
        }
      


    }
}
