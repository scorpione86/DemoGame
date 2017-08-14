using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {
    public static int currentScore = 0;
    public float offsetY = 2;
    public float sizeX = 100;
    public float sizeY = 23;
    public Transform musicPrefab;

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
}
