using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{

    //Bottom box collider serves as a barrier and also as the point collector upon collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManagement>().AddScore();
        Destroy(collision.collider.gameObject);
    }


}
