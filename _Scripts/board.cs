using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board : MonoBehaviour
{
    float boardL = -4.4f;
    float boardR;
    public float compinsation = 2


    void LateUpdate()
    {
        Vector3 pos = transform.position;
        if (pos.x > -boardL)
        {
            pos.x = -boardL ;
            
        }
        if (pos.x < boardL)
        {
            pos.x = boardL;

        }


        transform.position = pos;
    }
}
