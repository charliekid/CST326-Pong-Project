using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float amplify = 1;

  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AddForce();
        }
        
       
    }

    private void AddForce()
    {
        // goes straight down the x axis
        rb.AddForce(new Vector3(1, 0, 0 * amplify));
    }


 }
