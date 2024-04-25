using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NesneHareket : MonoBehaviour
{
    public float speed;
    void FixedUpdate()
    {
        transform.position += new Vector3(-1 * speed * Time.deltaTime ,0,0);
    }
}
