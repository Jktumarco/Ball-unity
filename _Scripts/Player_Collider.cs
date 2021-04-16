using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Collider : MonoBehaviour
{

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Vector3 buttonPos= button.S.transform.position;
            buttonPos.y = 75f;
            button.S.transform.position = buttonPos;
            Time.timeScale = 0f;
            
        }
    }
}
