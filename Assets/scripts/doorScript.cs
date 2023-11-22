using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorScript : MonoBehaviour
{
    
    private Animator anim;
    private BoxCollider2D myCollider;
    public itemCollector fk;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        fk = FindObjectOfType<itemCollector>();
        if (fk.cherries != 10)
        {
            gameObject.tag = "trap";
            anim.SetBool("doorOn", false);
            myCollider.isTrigger = false;
        }
        else if (fk.cherries == 10)
        {
            gameObject.tag = "Untagged";
            anim.SetBool("doorOn", true);
            myCollider.isTrigger = true;

        }
        
    }
}
