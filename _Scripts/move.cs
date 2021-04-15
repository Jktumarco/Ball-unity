using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    static public move S;
    Rigidbody rg;
    public float speed = 2;
    public float speedX = 2;
    public float delSpeed = 10;
    public bool buttonClick = false;
    public float distance;
    public float platformScale = 30f;
    public float numPlatform = 1f;
    Vector3 _startObjPos;
    public Vector3 ballPOsition;

    
    void Start()
    {
        if (S == null) { S = this; }
        rg = GetComponent<Rigidbody>();
        GameObject startObj = GameObject.Find("Start");
        _startObjPos = startObj.transform.position;
        ballPOsition = this.transform.position;

    }


    void FixedUpdate()
    {
        ballPOsition = this.transform.position;
        Moving(); 
        distance = Mathf.Round (-(_startObjPos.z - transform.position.z)-1.49f);

        

    }
    public void Moving()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float mousX = Input.GetAxis("Mouse X");
        float vertical = +speed / delSpeed;


       //Vector3 pos = new Vector3(h * speed, 0f, vertical * speed);
       Vector3 pos = new Vector3(mousX * speedX, 0f, vertical * speed);
        rg.AddForce(pos);
    }

    


}
