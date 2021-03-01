using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gorusAcisi : MonoBehaviour
{
    [SerializeField]
    private AudioSource sesKaynagi;
    [SerializeField]
    private AudioClip klip;
    [SerializeField]
    private Text sayacMetni;
    [SerializeField]
    private int sayac;
    [SerializeField]
    private Animator animator;
   
    [SerializeField]
    private Animation clip;
     void Start()
    {
        sesKaynagi = this.GetComponent<AudioSource>();
        sayacMetni = GameObject.FindGameObjectWithTag("Sayac").GetComponent<Text>();
        sayac = 0;
        sayacMetni.text = "Amount of Destroyed Fruits:" + sayac.ToString();
        animator = this.GetComponent<Animator>();
        animator.enabled = false;
        
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           
            gorusAlani();
            animator.enabled = true;
          
        }
       
        
    }


    public void gorusAlani()
    {
       
        Vector3 kameraFareKonumu = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D isinDokumu = Physics2D.Raycast(transform.position,kameraFareKonumu); //Görüş açısı ayarı sağlanacak.
        if (isinDokumu.transform != null)
        {


            if (isinDokumu.transform.CompareTag("Meyve"))
            {
                Debug.Log(isinDokumu.transform.name + ":Görülen");
                Destroy(isinDokumu.transform.gameObject);
                sayac++;
                sayacMetni.text = "Amount of Destroyed Fruits:" + sayac.ToString();
            }
        }

        if(!sesKaynagi.isPlaying)
        {
            sesKaynagi.clip = klip;
            sesKaynagi.Play();
        }
        animator.enabled = true;
        StartCoroutine(yap(animator));
      
       
      
    }
    IEnumerator yap(Animator a)
    {
        a.SetBool("isAttacking", true);
        yield return new WaitForSeconds(4f);
        a.SetBool("isAttacking", false);
    }
}
