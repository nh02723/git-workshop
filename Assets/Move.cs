﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            transform.Translate(Vector3.left * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W)){
            transform.Translate(Vector3.up * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)){
            transform.Translate(Vector3.right * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)){
            transform.Rotate(50 * Time.deltaTime, 0, 0);
            transform.Translate(Vector3.up * Time.deltaTime);
        }
    }
}
