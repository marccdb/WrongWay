using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class VideoAdManager : MonoBehaviour
{

    private void Awake()
    {
        if(FindObjectsOfType<VideoAdManager>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }


    }
    //PlayStore ID
    string playStoreGameId = "3433393";

    //set to false when launching on PlayStore
    public bool testMode;

    //Video references
    private string videoAd = "video";
    private string rewardedVideoAd = "rewardedVideo";


    void Start()
    {
        Advertisement.Initialize(playStoreGameId, testMode);
    }


    public void ShowVideoAd()
    {
        if (!Advertisement.IsReady(videoAd))
        {
            return;
        }
        else
        {
            Advertisement.Show();
        }
    }
}
