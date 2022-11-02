using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    //control game over status, mostly for the car spawner system
    public bool gameOver;

    //Cache objects
    //VideoAdManager videoad;
    HandleKillCount handleKillCount;

    private void Start()
    {
        handleKillCount = FindObjectOfType<HandleKillCount>();
        //videoad = FindObjectOfType<VideoAdManager>();
    }


    public void LoadMainGame()
    {
        gameOver = false;
        FindObjectOfType<GameManagement>().Reset();
        SceneManager.LoadScene(1);      
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGameOver()
    {
        gameOver = true;
        StartCoroutine(WaitForDie());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator WaitForDie()
    {
        yield return new WaitForSeconds(1.5f);
        if (handleKillCount.killCount >= 3)
        {
            //videoad.ShowVideoAd();
            handleKillCount.killCount = 0;
        }
        SceneManager.LoadScene(2);
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadStartScreen()
    {
        SceneManager.LoadScene(0);
    }
}
