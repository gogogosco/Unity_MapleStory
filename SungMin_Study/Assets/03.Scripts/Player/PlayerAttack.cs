using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    Animator animator;
    private PlayerInput playerInput;
    private float attackTime = 1.0f; // 공격 애니메이션 실행 시간

    void Start()
    {
        animator = GetComponent<Animator>();
        playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if(playerInput.p_isAttack == true)
        {
            StartCoroutine("Attack");                  
        }
    }

    IEnumerator Attack()
    {
        animator.SetBool("attack", true);
        Debug.Log("공격!");

        yield return new WaitForSeconds(attackTime); // 공격 애니메이션 진행 시간
        playerInput.p_isAttack = false;
        animator.SetBool("attack", false);
    }
}
