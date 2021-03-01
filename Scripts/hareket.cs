using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer renderer;
    [SerializeField]
    private Animator animator;
    void Start()
    {
        renderer = this.gameObject.GetComponent<SpriteRenderer>();
        transform.position = new Vector3(-10.45f, -4.41f,-0.9f);
        animator = this.GetComponent<Animator>();
        animator.enabled = false;
    }
   

  
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal")*6f*Time.deltaTime; //Yatay eksen üzerinde hareketi sağlar.
        transform.Translate(new Vector3(x,0f,0f));
        if(x !=0f && !animator.GetCurrentAnimatorStateInfo(0).IsName("kilic"))
        {
            animator.enabled = true;
            animator.SetInteger("isWalking", (int)transform.position.x);
        }
        else
        {
            animator.SetInteger("isWalking",0);
        }
        if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown("right") && !animator.GetCurrentAnimatorStateInfo(0).IsName("kilic"))
        {
            transform.localScale = new Vector3(0.2f, transform.localScale.y,transform.localScale.z);
            animator.enabled = false;
            animator.SetInteger("isWalking",(int)transform.position.x);
            
        }
        
        if(Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown("left") && !animator.GetCurrentAnimatorStateInfo(0).IsName("kilic"))
         {
            transform.localScale = new Vector3(-0.2f,transform.localScale.y,transform.localScale.z);
            animator.enabled = true;
            animator.SetInteger("isWalking",(int)transform.position.x);
        }

        if(Input.GetKeyDown("space"))
        {
            transform.position += Vector3.up;
        }
        if(Input.GetKeyUp("space"))
        {
            transform.position -= Vector3.up;
        }
        
    }
}
