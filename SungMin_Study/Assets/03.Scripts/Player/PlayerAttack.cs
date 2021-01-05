using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    private PlayerInput playerInput;
    private float curTime;
    [SerializeField]
    private float coolTime = 0.5f;

    void Start()
    {
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if(curTime <= 0 && playerInput.p_isAttack == true)
        {
            Debug.Log("공격!");
            animator.SetTrigger("attack");
            curTime = coolTime;
            playerInput.p_isAttack = false;
        }
        else
        {
            curTime -= Time.deltaTime;
        }
    }
}
