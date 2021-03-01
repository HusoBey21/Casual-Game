using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hedefeDogru : MonoBehaviour
{
    [SerializeField]
    private Transform hedef;
    void Start()
    {
        hedef = GameObject.FindGameObjectWithTag("Ninja").transform;

    }

    // Update is called once per frame
    void Update()
    {
        hedefBelirleme();
    }


    public void hedefBelirleme()
    {
        
        Vector3 uzaklik = hedef.position - transform.position;
        float aci = Mathf.Atan2(uzaklik.y, uzaklik.x) * Mathf.Rad2Deg;
        Quaternion donus = Quaternion.AngleAxis(aci,transform.forward);
        transform.position += uzaklik * 2f * Time.deltaTime;
        transform.rotation = Quaternion.Slerp(transform.rotation,donus,3f*Time.deltaTime); //Küresel ve doğrusal bir dönüş gerçekleşti
        
    }
}
