using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    private Text namberDistance;
    void Start()
    {
        namberDistance = GetComponent<Text>();
    }

    
    void Update()
    {
        namberDistance.text = move.S.distance.ToString();
    }
}
