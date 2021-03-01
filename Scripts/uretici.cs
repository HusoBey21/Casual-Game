using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uretici : MonoBehaviour
{
    [SerializeField]
    private GameObject[] meyveler;
    [SerializeField]
    private Transform oyuncu;
    [SerializeField]
    private float duseyAralik,sure,rastgele;
    
    void Start()
    {
        meyveler = GameObject.FindGameObjectsWithTag("Meyve");
        oyuncu = GameObject.FindGameObjectWithTag("Ninja").transform;
        duseyAralik = Random.Range((oyuncu.position.y - 5f), (oyuncu.position.y + 5f));
        rastgele = Random.Range(0f, 10f);
      
        
    }

    // Update is called once per frame
    void Update()
    {
        sagdanUretici();
        soldanUretici();
    }


    public void  sagdanUretici()
    {
        sure += Time.deltaTime;
        if(sure >= 10f)
        {
            for (int i=0;i<meyveler.Length; i++)
            {


                if (meyveler[i] != null)
                {
                    GameObject uretilenMeyve = Instantiate(meyveler[i], new Vector3((oyuncu.position.x + rastgele), duseyAralik, meyveler[i].transform.position.z), Quaternion.identity);
                    uretilenMeyve.AddComponent<hedefeDogru>();
                    
                    uretilenMeyve.AddComponent<carpisma>();
                  
                    Destroy(uretilenMeyve, 7f);
                    sure = 0f;
                }
            }

           
        }
        
    }

    public void soldanUretici()
    {
        sure += Time.deltaTime;
        if (sure >= 10f)
        {
            for (int i =0;i<meyveler.Length;i++)
            {


                if (meyveler[i]!= null)
                {
                    GameObject uretilenMeyve = Instantiate(meyveler[i], new Vector3((oyuncu.position.x - rastgele), duseyAralik, meyveler[i].transform.position.z), Quaternion.identity);
                    uretilenMeyve.AddComponent<hedefeDogru>();
                    
                    uretilenMeyve.AddComponent<carpisma>();
                    Destroy(uretilenMeyve, 7f);
                    sure = 0f;
                }
            }


        }
    }
}
