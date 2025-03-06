using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 90;
        string medal = "";
        //90 이상이면 금
        if(score >=90)
        {
            medal = "금";
        }
        else
        {
            //80 이상이면 은
            if(score >=80)
            {
                medal = "은";
            }
            else
            {
                //70 이상이면 동
                if(score >= 70)
                {
                    medal = "동";
                }
                else // 0~69
                {
                    medal = "노";
                }
            }
        }
        Debug.Log($"{medal}메달을 수상하였습니다");
    }
}



/*
[Q]
score가 90이상이면 금메달 출력, 80이상이면 은메달 출력
70 이상이면 동메달 출력, 그 외 나머지는 노메달 출력
score는 85점

[output]
()메달을 수상하였습니다
 */