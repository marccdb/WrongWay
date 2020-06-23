using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{

    [SerializeField] float backgroundScrollSpeed = 0.6f;
    Material material;
    Vector2 offSet;

    ManageScenes manageScenes;
    
    void Start()
    {
        material = GetComponent<Renderer>().material;
        manageScenes = FindObjectOfType<ManageScenes>();
        offSet = new Vector2(0, backgroundScrollSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        if(manageScenes.gameOver == false)
        {
            ScrollBackground();
        }
        
    }

    private void ScrollBackground()
    {
        material.mainTextureOffset += offSet * Time.deltaTime;
    }
}
