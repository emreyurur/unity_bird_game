using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KusHareket : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    public float speed;
    public GameObject pislik;
    private int pislikSayisi = 5;
    public Text pislikText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        if(GameManager.end != true)
        {
            rb.velocity = new Vector3(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
            transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, 0, 7.33f), 0);            
        }
    }
    private void Update()
    {
        if (GameManager.end != true)
        {
            if (Input.GetKeyDown(KeyCode.Space) && pislikSayisi > 0)
            {
                anim.SetTrigger("pisleme");
                Invoke("PislikOlustur", 0.3f);
            }
        }
    }
    private void PislikOlustur()
    {
        --pislikSayisi;
        pislikText.text = pislikSayisi.ToString();
        GameObject yeniPislik = Instantiate(pislik);
        yeniPislik.transform.position = transform.position;
    }
    public void PislikEkle()
    {
        ++pislikSayisi;
        pislikText.text = pislikSayisi.ToString();
    }
}
