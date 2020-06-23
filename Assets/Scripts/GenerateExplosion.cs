using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateExplosion : MonoBehaviour
{

    [SerializeField] GameObject explosionPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == ("Player"))
        {
            Instantiate(explosionPrefab, gameObject.transform.position, gameObject.transform.rotation);
        }
    }


}
