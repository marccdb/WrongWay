using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{

    //Setting up game parameters
    [SerializeField] public int carPoints = 0; //value of each car the player avoided

    ManageScenes manageScenes;


    //Singleton method so the GameManagement object remains after scene change
    private void Awake()
    {

        manageScenes = FindObjectOfType<ManageScenes>();
        if (FindObjectsOfType<GameManagement>().Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }



    public void AddScore()
    {
        if(manageScenes.gameOver == false)
        carPoints++;
    }


    public void Reset()
    {
        Destroy(gameObject);
    }


}
