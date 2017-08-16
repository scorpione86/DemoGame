using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour {

    public GameMaster gameMaster;

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("restarting");
        gameMaster.RestartLevel();
    }
}
