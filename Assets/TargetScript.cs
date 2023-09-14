using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;

public class GreenButtonScript : MonoBehaviour 
{ 
    public float moveSpeed; 
    private bool movingRight = true;
    public Vector3 initialScale = new Vector3(0.6f, 0.6f, 1);

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = initialScale;
        moveSpeed = UnityEngine.Random.Range(5, 11);
    }

    // Update is called once per frame
    void Update()
    {
        float moveDirection = movingRight ? 1f : -1f;
        Vector3 newPosition = transform.position + Vector3.right * moveDirection * moveSpeed * Time.deltaTime;

        // Move the sprite
        transform.position = newPosition;

        // Check if the sprite has reached the screen boundaries
        if (transform.position.x >= 10f)
        {
            movingRight = false;
        }
        else if (transform.position.x <= -10f)
        {
            movingRight = true;
        }
        
        if (Input.GetMouseButtonDown(0))
        {
           Debug.Log("Hello");
        }
    } 
}