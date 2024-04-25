using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotateCube : MonoBehaviour
{
    public float speed = 100f;

    void Update()
    {
        float rotationX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        float rotationY = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Rotate(Vector3.up, rotationX);
        transform.Rotate(Vector3.right, rotationY);
    }
}

