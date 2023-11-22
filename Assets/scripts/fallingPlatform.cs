using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlatform : MonoBehaviour
{
    private float timer = 0f; // Change int to float
    private Animator anim;
    private BoxCollider2D myCollider;

    // Start is called before the first frame update
    void Start()
    {
        myCollider = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 3f)
        {
            gameObject.tag = "untagged";
            anim.SetBool("on", true);
            timer += Time.deltaTime * 1f;
            myCollider.isTrigger = false;
        }
        else if (timer >= 3f && timer < 5f)
        {
            gameObject.tag = "Untagged";
            anim.SetBool("on", false);
            timer += Time.deltaTime * 1f;
            myCollider.isTrigger = true;

        }
        else if (timer >= 5f)
        {
            timer = 0f;
        }
    }
}
