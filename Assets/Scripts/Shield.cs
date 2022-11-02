using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public bool isShield;
    //float time = 10;

    private void Start()
    {



    }

    private void Update()
    {


    }


    public IEnumerator ShieldActive()
    {
        transform.GetChild(1).gameObject.SetActive(true);

        yield return new WaitForSeconds(4);
        isShield = false;
        transform.GetChild(1).gameObject.SetActive(false);
    }

}


