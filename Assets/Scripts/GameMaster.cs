﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Timers;

public class GameMaster : MonoBehaviour {
    public static int currentScore = 0;
    public float offsetY = 2;
    public float sizeX = 100;
    public float sizeY = 23;
    public Transform musicPrefab;
    public AudioClip gameOverSound;
    public Transform player;
    public static bool isRestarting = false;

    private void Start()
    {
        currentScore = 0;
        if (!GameObject.FindGameObjectWithTag("Music"))
        {
            var mManager = Instantiate(musicPrefab, transform.position, Quaternion.identity);
            mManager.name = musicPrefab.name;
            DontDestroyOnLoad(mManager);
        }
    }
    // Update is called once per frame
    void OnGUI () {
        GUI.Box(new Rect(Screen.width /2 - sizeX/2 , offsetY, sizeX, sizeY), "Score: " + currentScore);
	}

    public void RestartLevel()
    {
        isRestarting = true;
        GetComponent<AudioSource>().clip = gameOverSound;
        GetComponent<AudioSource>().pitch = 1;
        GetComponent<AudioSource>().Play();

        Timer gameoverTimer = new Timer();
        gameoverTimer.Interval = GetComponent<AudioSource>().clip.length * 1000;

        //yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        StartCoroutine(playAudio());
        player.position = CheckPoint.reachedPoint;
        //SceneManager.LoadScene(0);
        isRestarting = false;

    }

    public IEnumerator playAudio()
    {
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
    }
}
