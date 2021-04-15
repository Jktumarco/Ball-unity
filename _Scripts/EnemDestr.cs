using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemDestr : MonoBehaviour
{


    void Update()
    {
        EnemyDestroy();
    }

    public void EnemyDestroy()
    {
        if (move.S.ballPOsition.z > transform.position.z+50 )
        {
            Destroy(this.gameObject);
        }
    }

}
