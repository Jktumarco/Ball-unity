using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camfall : MonoBehaviour
{
    
    
    

   
    void FixedUpdate()
    {
        Vector3 camPos = this.transform.position;
        camPos.z = move.S.ballPOsition.z-4f;
        this.transform.position = camPos;
    }
}
