using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallHealth : MonoBehaviour {

    public float maxFallDistance = -10;
    public GameMaster gameMaster; 

	void Update ()
    {
        if (transform.position.y <= maxFallDistance)
        {
            if (GameMaster.isRestarting == false)
            {
                gameMaster.RestartLevel();
            }
        }
	}

}
