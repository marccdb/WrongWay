using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Vector3 screenPoint;
    Vector3 offset;
    

    [Header("Parameters")]
    [SerializeField] private float xBoundaries = 2.0f;
    [SerializeField] private float speed = 10f;
    Vector3 clampedMovement;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        float horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * speed * Time.deltaTime);
        clampedMovement.x = Mathf.Clamp(transform.position.x, -xBoundaries, xBoundaries);
        transform.position = clampedMovement;
    }

    //Option to use mouse to control the player
    void OnMouseDown()
    {
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }




}


