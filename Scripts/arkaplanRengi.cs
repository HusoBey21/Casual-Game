using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arkaplanRengi : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer renderer;
    [SerializeField]
    private Transform transforma;
    void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
        transforma = GameObject.FindGameObjectWithTag("Güneş").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > transforma.position.x)
        {
            arkaplan();
        }
    }
    
    public void arkaplan()
    {
        renderer.material.color = new Color(210f, 180f, 140f);
    }
}
