using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Timers;

public class BallHealth : MonoBehaviour {

    public float maxFallDistance = -10;
    public AudioClip gameOverSound;
    private bool isRestarting = false;


	void Update ()
    {
        if (transform.position.y <= maxFallDistance)
        {
            if (isRestarting == false)
            { 
                StartCoroutine(RestartLevel());
            }

        }
	}

    IEnumerator RestartLevel()
    {
        isRestarting = true;
        GetComponent<AudioSource>().clip = gameOverSound;
        GetComponent<AudioSource>().pitch = 1;
        GetComponent<AudioSource>().Play();

        Timer gameoverTimer = new Timer();
        gameoverTimer.Interval = GetComponent<AudioSource>().clip.length * 1000;

        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        transform.position = CheckPoint.reachedPoint;
        //SceneManager.LoadScene(0);
        isRestarting = false;

    }
}
