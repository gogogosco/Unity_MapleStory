using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall_Shooter : MonoBehaviour
{
    public GameObject fireBall;
    private float curTime;
    private float coolTime = 0.1f; //파이어볼 쿨타임

    private void Update()
    {
        if (Input.GetKey(KeyCode.W)) //W키누르면 파이어볼 발사!
        {
            if (curTime <= 0)
            {
                Instantiate(fireBall, transform.position, transform.rotation); //Shooter 위치에서 파이어볼 생성
                curTime = coolTime; //쿨타임 초기화
            }
            else
            {
                curTime -= Time.deltaTime;
            }
        }        
    }
}
