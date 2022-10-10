using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        anim.SetFloat("Vertical", y);
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("Horizontal", x);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetFloat("Jump", 1);
        }
        else
        {
            anim.SetFloat("Jump", 0);
        }
    }
}
