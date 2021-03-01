using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carpisma : MonoBehaviour
{

     public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.CompareTag("Ninja"))
        {
            collision.transform.GetComponent<saglik>().canKaybi(4f);
        }
    }
}
