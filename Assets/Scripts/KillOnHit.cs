using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnHit : MonoBehaviour {

    public GameMaster gameMaster;

    private void OnTriggerEnter(Collider colInfo)
    {
        //Debug.Log("restarting");
        if (GameMaster.isRestarting == false)
        {
            if (colInfo.tag == "Player")
            {
                Destructable destructible = colInfo.GetComponent<Destructable>();
                destructible.Destruct();
            }
            StartCoroutine(gameMaster.RestartLevel());
        }
        
    }
}
