using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : State
{
    private Enemy enemy;

    public void OnEnter(Enemy enemy)
    {
        this.enemy = enemy;
    }

    public void Update()
    {
        enemy.transform.Translate(Vector3.right * 0.01f);

        if(enemy.transform.position.x > enemy.Enemy_defaultPostion + 2.0f)
        {
            enemy.transform.localScale = new Vector3(-1, 1, 1);
            enemy.SetState(new MoveLeft());
        }
    }


    public void OnExit()
    {

    }
}
