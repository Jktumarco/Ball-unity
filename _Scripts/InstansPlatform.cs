using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstansPlatform : MonoBehaviour
{
    public GameObject platformPrefab;
    public List<GameObject> listPlatform;
    float posZ;
    void Start()
    {
        GameObject firstPlatform = GameObject.Find("Platform");
        listPlatform.Add(firstPlatform);
    }

    
    void Update()
    {
        
        

        if (move.S.distance > move.S.platformScale * move.S.numPlatform)
        {
            GameObject _platformEnd = GameObject.Find("platform_end");
            Vector3 _platformEndPos = _platformEnd.transform.position;
            GameObject go = Instantiate(platformPrefab, new Vector3(_platformEndPos.x, _platformEndPos.y, 14 + 20f * move.S.numPlatform), Quaternion.identity);
            move.S.numPlatform++;
            
        }

        

    }
}
