using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JUMP : MonoBehaviour
{
    // Start is called before the first frame update
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    float speed = 1f;

    bool isJumping = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.y = curve.Evaluate(t);

        Vector3 spin = transform.eulerAngles;
        spin.z += speed;
        transform.eulerAngles = spin;

        if(Input.GetKey(KeyCode.Space))
        {
            isJumping = true;

        }

        if (isJumping == true)
        {
            if (t > 1)
            {
                t = 0;
                isJumping = false;
            }

            t += Time.deltaTime;
            transform.position = pos;

           
        }

       


    }

}

