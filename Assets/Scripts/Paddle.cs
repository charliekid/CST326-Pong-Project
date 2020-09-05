using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
     public float amplify = 1;
// Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // we are translating every frame
        // this occurs when the player motion down on one of the axis

        //if (Mathf.Abs(transform.position.z) < 5.5) try to figure out how to block the ends from leaving
        //{
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Vertical")) * Time.deltaTime * amplify);
        transform.Translate(new Vector3(0, 0, Input.GetAxis("Right Paddle")) * Time.deltaTime * amplify);





        //}

    }
}