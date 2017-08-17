using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour {

    public GameMaster gameMaster;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("restarting");
        if (GameMaster.isRestarting == false)
        {
            StartCoroutine(gameMaster.RestartLevel());
        }
        
    }
}
