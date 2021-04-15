using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    static public button S;
    GameObject button_;
     
    void Awake()
    {
        if (S == null)
        {
            S = this;
        }
        
    }
    
    
    public void Start_button()
    {
        SceneManager.LoadScene(0);
        Time.timeScale =1f;
        //move.S.buttonClick = true;
        //move.S.Moving();

    }
    




}
