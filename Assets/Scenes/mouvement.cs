using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvement : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = Input.GetAxis("Vertical");
        anim.SetFloat("DirectionY",y);
        float x = Input.GetAxis("Horizontal");
        anim.SetFloat("DirectionX", x);
    }
}
