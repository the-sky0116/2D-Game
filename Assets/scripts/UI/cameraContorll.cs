﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraContorll : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(target!=null)
        {
            if(transform.position!=target.position)
            {
                Vector3 targetPos = target.position;
                transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
            }
        }
                
    }
}
