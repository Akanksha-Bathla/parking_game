using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField]float steerSpeed = 200f;
    [SerializeField]float moveSpeed = 15f;
    [SerializeField]float slowSpeed = 10f;
    [SerializeField]float boostSpeed = 25f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other) {
        moveSpeed = slowSpeed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            moveSpeed = boostSpeed;
        }  
    }

    
}
