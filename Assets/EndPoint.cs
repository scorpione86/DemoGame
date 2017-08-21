using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndPoint : MonoBehaviour {

    public GameMaster gameMaster;
    public void OnTriggerEnter(Collider colInfo)
    {
        if (colInfo.tag == "Player")
        {
            gameMaster.LoadNextLevel();
        }

    }
}
