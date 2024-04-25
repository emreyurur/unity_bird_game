using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pislik : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    GameManager gameManager;
    private void Start()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector3(1 * speed, 0, 0));
        Destroy(gameObject, 5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "kus")
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            other.gameObject.GetComponent<Animator>().enabled = false;
            other.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameManager.Score(5);
        }
    }
}
