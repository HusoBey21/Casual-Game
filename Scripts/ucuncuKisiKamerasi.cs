using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ucuncuKisiKamerasi : MonoBehaviour
{
    [SerializeField]
    private Transform oyuncu;
    [SerializeField]
    private Vector3 istenenKonum,kameraKonumu;
    void Start()
    {
        oyuncu = GameObject.FindGameObjectWithTag("Ninja").transform;
        kameraKonumu = Camera.main.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        istenenKonum = kameraKonumu + oyuncu.position;
        transform.position = Vector3.MoveTowards(transform.position,istenenKonum,4f*Time.deltaTime);
    }
}
