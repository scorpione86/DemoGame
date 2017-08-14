using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenu : MonoBehaviour {
    public AudioSource music;

    public void QuitGame()
    {
        Debug.Log("gAME IS EXITING");
        Application.Quit();
    }

    public void PlayGame()
    {
        DontDestroyOnLoad(music);
        EditorSceneManager.LoadScene(1);
    }

    public void setGameVolume (float vol)
    {
        //Debug.Log(vol);
        music.volume = vol*2;
    }

}
