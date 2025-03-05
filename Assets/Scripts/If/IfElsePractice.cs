using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 90;
        if(score >=90)
        {
            Debug.Log("금메달을 수상하였습니다.");
        }
        else
        {
            if(score >=80)
            {
                Debug.Log("은메달을 수상하였습니다.");
            }
            else
            {
                if(score >= 70)
                {
                    Debug.Log("동메달을 수상하였습니다.");
                }
                else
                {
                    Debug.Log("노메달을 수상하였습니다.");
                }
            }
        }
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