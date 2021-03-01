using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resimBoyutu : MonoBehaviour
{
    [SerializeField]
    private Transform arkaplan;
    [SerializeField]
    private SpriteRenderer ikiboyutluGiydirici;
    void Start()
    {
        arkaplan = GameObject.FindGameObjectWithTag("Arkaplan").transform;
        ikiboyutluGiydirici = arkaplan.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(1f, 1f, 1f);
        float x = Camera.main.orthographicSize * 2f*5f;
        float y = Screen.height * x / Screen.width;
        float resimEni = ikiboyutluGiydirici.bounds.size.x;
        float resimBoy = ikiboyutluGiydirici.bounds.size.y;
        float oranX = x / resimEni;
        float oranY = y / resimBoy;
        transform.localScale = new Vector3(oranX, oranY, 1f);
    }
}
