using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
  
    void Start()
    {
        //1. 변수
        Debug.Log("Hello Unity!");
        int level = 5;
        float strength = 15.5f;
        string playername = "나검사";
        bool isfulllevel;

        //2. 그룹형 변수
        string[] monsters = { "슬라임", "사막뱀", "악마" };
        int[] monstersLevel = new int[3];
        monstersLevel[0] = 1;
        monstersLevel[1] = 6;
        monstersLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);




    }


}
