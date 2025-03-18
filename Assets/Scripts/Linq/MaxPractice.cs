using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] inputs = { -2, -5, -3, -7, -1 };

        //역시나 코딩고수 강진구의 정답
        //Debug.Log($"최대값: {inputs.Max()}");


        //내가 예상한 뉴비용 정답 <<까지 예측성공 ㄷㄷ 강진규그는감히전설이라고할수있다
        //최대값을 저장하는 변수
        int max = int.MinValue;
        for (int i = 0; i < inputs.Length; i++)
        {
            if (inputs[i] > max)
            {
                max = inputs[i];
            }
        }
        Debug.Log($"최대값: {max}");

    }
}

/*
[Q]
입력데이터 {-2, -5, -3, -7, -1}
입력 데이터 중에서 최대값을 구하세요

[output]
최대값: -1
 
 */