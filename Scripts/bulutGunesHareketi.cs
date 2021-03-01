using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulutGunesHareketi : MonoBehaviour
{
    [SerializeField]
    private float sure;
    [SerializeField]
    private float ilerleme;
    void Start()
    {
        ilerleme = 5f;
    }

    void Update()
    {
        hareketlenme();
    }

    public void hareketlenme()
    {
        sure += Time.deltaTime;
        if(sure >=4f)
        {
            transform.position = new Vector3((transform.position.x + ilerleme * sure), transform.position.y, transform.position.z);
            sure = 0f;
        }
    }
}
