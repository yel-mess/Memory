using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    public bool mouseOver = false;

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        
    }
    void OnMouseOver() {
        mouseOver = true;
        animator.SetBool("MouseOver", true);
    }
    void OnMouseExit() {
        mouseOver = false;
        animator.SetBool("MouseOver", false);
    }
}
