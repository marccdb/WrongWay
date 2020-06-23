using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    //Caching components
    ManageScenes manageScenes;
    [SerializeField] ParticleSystem explosionPrefab;
    Vector3 explosionOffset = new Vector3(0, -4.20f);
    Shield shield;
    HandleKillCount handleKillCount;

    //Explosion SFX
    [SerializeField] AudioClip explosionSfx;
    [SerializeField] [Range(0, 1)] float explosionVolume = 0.5f;

    private void Start()
    {
        handleKillCount = FindObjectOfType<HandleKillCount>();
        manageScenes = FindObjectOfType<ManageScenes>();
        shield = FindObjectOfType<Shield>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            KillPlayer();
        }
        //else if (collision.collider.tag == "Shield" && shield.isShield == false)
        //{

        //    shield.isShield = true;
        //    StartCoroutine(shield.ShieldActive());
        //    Destroy(collision.collider);
        //}

    }


    //Kill player method, instantiating particle system prefab with some offset, playing explosion audio clip, destroying the game object and initializing the process of changing scenes
    private void KillPlayer()
    {

        handleKillCount.AddToKillCount();
        Instantiate(explosionPrefab, gameObject.transform.position + explosionOffset, gameObject.transform.rotation);
        AudioSource.PlayClipAtPoint(explosionSfx, Camera.main.transform.position, explosionVolume);
        Destroy(gameObject);       
        manageScenes.LoadGameOver();
    }





}
