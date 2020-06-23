using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleKillCount : MonoBehaviour
{

    public int killCount;

    private void Awake()
    {

        if (FindObjectsOfType<HandleKillCount>().Length > 1)
        {
            gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddToKillCount()
    {
        killCount++;
    }

}
