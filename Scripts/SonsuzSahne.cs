using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonsuzSahne : MonoBehaviour
{
    [SerializeField]
    private float mesafe;
    
    void Start()
    {
        mesafe = 5f;
       
    }

    // Update is called once per frame
    void Update()
    {
        if((transform.position.x + mesafe)<Camera.main.transform.position.x)
        {
            ileri();
        }
        if((transform.position.x + mesafe) > Camera.main.transform.position.x)
        {
            geri(); 
        }
    }

    public void ileri()
    {
        transform.position = new Vector3((transform.position.x+mesafe),transform.position.y,transform.position.z);
    }
    public void geri()
    {
        transform.position = new Vector3((transform.position.x - mesafe), transform.position.y, transform.position.z);
    }
}
