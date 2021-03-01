using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animasyonolusumu : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    [SerializeField]
    private float zaman;
    void Start()
    {
        animator = this.GetComponent<Animator>(); //İçindeki bileşeni çağırdık.
        zaman = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        animate();
    }
    public void animate()
    {
        if(animator.isInitialized)
        {
            zaman += Time.deltaTime;
            animator.SetBool("isRunning", true);
            if(zaman >=6f)
            {
                animator.SetBool("isRunning",false);
                zaman = 0f;
            }
           
        }
    }

}
