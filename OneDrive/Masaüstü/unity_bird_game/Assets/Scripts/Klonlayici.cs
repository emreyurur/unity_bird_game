using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Klonlayici : MonoBehaviour
{
    public GameObject[] nesneler;

    private void Start()
    {
        InvokeRepeating("Klonla", 1f, 2f);
    }
    private void Klonla()
    {
        int i = Random.Range(0, nesneler.Length);
        GameObject newClone= Instantiate(nesneler[i]);
        if (newClone.tag == "saglikli" || newClone.tag == "zararli")
        {
            int j = Random.Range(-3, 4);
            newClone.transform.position = new Vector3(newClone.transform.position.x, newClone.transform.position.y + j, newClone.transform.position.z);
        }
        else if (newClone.tag == "kus")
        {
            int j = Random.Range(-2, 3);
            newClone.transform.position = new Vector3(newClone.transform.position.x, newClone.transform.position.y + j, newClone.transform.position.z);
        }
        Destroy(newClone, 10f);
    }
    
}
