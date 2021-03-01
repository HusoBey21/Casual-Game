using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nesneHavuzu : MonoBehaviour
{
    [SerializeField]
    private Transform kent;
    void Start()
    {
        kent = GameObject.FindGameObjectWithTag("Tokyo").transform;

    }
    // Update is called once per frame
    void Update()
    {
        if((kent.position.x + 10f) < Camera.main.transform.position.x)
        {
            ilerleme();
        }
        if((kent.position.x + 10f) > Camera.main.transform.position.x)
        {
            gerileme();
        }
    }

    public void ilerleme()
    {
       
        kent.position = new Vector3((kent.position.x +10f),kent.position.y,kent.position.z);
    }

    public void gerileme()
    {
      
       
        kent.position = new Vector3((kent.position.x - 10f),kent.position.y,kent.position.z);
    }
}
