using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class DisplayPoints : MonoBehaviour
{

    //Caching components and getting references
    GameManagement showPoints;
    TextMeshProUGUI pointsToDisplay;
    
    
    void Start()
    {
        showPoints = FindObjectOfType<GameManagement>();
        pointsToDisplay = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        pointsToDisplay.text = showPoints.carPoints.ToString(); //display the total number of points on the screen, converting int to string.

    }



}
