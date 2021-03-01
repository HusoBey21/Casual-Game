using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sure : MonoBehaviour
{
    [SerializeField]
    private float surem;
    [SerializeField]
    private Text metin;
    void Start()
    {
        surem = 600f;
        metin = GameObject.FindGameObjectWithTag("Sure").GetComponent<Text>();
        int dakika = Mathf.RoundToInt((surem / 60f));
        int saniye = Mathf.RoundToInt((surem % 60f));
        metin.text= "Time:" + string.Format("{0}:{00}", dakika, saniye);

    }

    // Update is called once per frame
    void Update()
    {
        sureler();
    }


    public void sureler()
    {
        surem -= Time.deltaTime;
        int dakika = Mathf.FloorToInt(surem / 60);
        int saniye = Mathf.FloorToInt(surem % 60);
        metin.text = "Time:" + dakika.ToString() + ":" + saniye.ToString();
        if(saniye <10f)
        {
            metin.text = "Time:" + dakika.ToString() + ":" + "0"+ saniye.ToString();
        }
        

        if(dakika == 0f && saniye==0f)
        {
            SceneManager.LoadScene(0);
        }

    }


}
