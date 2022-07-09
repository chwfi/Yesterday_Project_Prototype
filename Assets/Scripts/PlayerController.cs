using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void swordAttack()
    {
        anim.SetTrigger("swordAttack");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            swordAttack();
        }
    }
}
