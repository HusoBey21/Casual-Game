using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class saglik : MonoBehaviour
{
    [SerializeField]
    private float can;
    [SerializeField]
    private float sure;
    [SerializeField]
    private Text metin;
    void Start()
    {
        can = 100f;
        metin = GameObject.FindGameObjectWithTag("Metin").GetComponent<Text>();
        metin.text = "Player's health:" + can.ToString();
    }

    void Update()
    {
        yaraSar();
    }


    public void canKaybi(float hasar)
    {
        can -= hasar;
        sure += Time.deltaTime;
       
        if(can <=0f)
        {
            can = 0f;
            if(sure >=3f)
            {
                SceneManager.LoadScene(0);
                sure = 0f;
            }
            
        }
        metin.text = "Player's health:" + can.ToString();
    }


    public void yaraSar()
    {
        sure += Time.deltaTime;
        if(sure >= 7f)
        {
            can += 10f;
        }
        if(can >=100f)
        {
            can = 100f;
        }
      
    }
}
