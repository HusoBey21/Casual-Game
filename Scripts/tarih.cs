using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tarih : MonoBehaviour
{
    [SerializeField]
    private Text metin;
    void Start()
    {
        metin = GameObject.FindGameObjectWithTag("Bugün").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bugun();
    }

    public void bugun()
    {
        string tarihimiz = System.DateTime.Now.ToString();
        metin.text = tarihimiz;
    }
}
