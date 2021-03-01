using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulutUret : MonoBehaviour
{
    [SerializeField]
    private Transform asd, ninja;
    [SerializeField]
    private float sure;
    [SerializeField]
    private float mesafe;
    void Start()
    {
        asd = GameObject.FindGameObjectWithTag("Güneş").transform;
        ninja = GameObject.FindGameObjectWithTag("Ninja").transform;
        sure = 0f;
        mesafe = Random.Range(0f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        uretim();
    }

    public void uretim()
    {
        sure += Time.deltaTime;
        if(asd !=null)
        {
            if(sure > 10f)
            {
                Transform sa = Instantiate(asd,new Vector3((ninja.position.x + mesafe),asd.position.y,asd.position.z),Quaternion.identity) as Transform;
                Destroy(sa.gameObject,7f);
                sure = 0f;
            }
        }
    }
}
