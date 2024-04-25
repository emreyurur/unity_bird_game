using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carpisma : MonoBehaviour
{
    Animator anim;
    Rigidbody2D rb;
    GameManager gameManager;
    KusHareket kusHareket;
    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        gameManager = Object.FindObjectOfType<GameManager>();
        kusHareket = Object.FindObjectOfType<KusHareket>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "zararli")
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            Destroy(other.gameObject);
            kusHareket.PislikEkle();
        }
        if (other.gameObject.tag == "saglikli")
        {
            if(transform.localScale.x > 0.1f)
            {
                transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            }
            Destroy(other.gameObject);
            gameManager.Score(1);
        }
        if (other.gameObject.tag =="toprak")
        {
           rb.gravityScale = 1;
           anim.enabled = false;
           gameManager.End();
        }
        if(other.gameObject.tag =="kus")
        {
            other.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            other.gameObject.GetComponent<Animator>().enabled = false;

            rb.gravityScale = 1;
            anim.enabled = false;

            gameManager.End();
        }
    }
}
