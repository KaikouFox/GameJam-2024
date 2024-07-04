using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float baseSpeed = 5f;

    private float movementX;
    private float movementY;

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        movementX = Input.GetAxisRaw("Horizontal");
        movementY = Input.GetAxisRaw("Vertical");

        transform.position = transform.position + new Vector3(movementX * baseSpeed * Time.deltaTime, movementY * baseSpeed * Time.deltaTime, 0);
    }
}
