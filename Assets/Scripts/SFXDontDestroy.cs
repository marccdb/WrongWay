using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXDontDestroy : MonoBehaviour
{

    private void Awake()
    {
        //Singleton for not dstroying game object after scene change
        if(FindObjectsOfType<SFXDontDestroy>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
