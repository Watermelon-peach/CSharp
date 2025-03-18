using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] inputs = { 90, 65, 78, 50, 95 };

        //코딩 고수 강진구의 정답
        /*double average = inputs.Where(n => n >= 70 && n <= 95).Average();

        Debug.Log($"평균점수: {average:#.##}");*/

        //뉴비용 정답
        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < inputs.Length; i++)
        {
            if (inputs[i] >= 70 && inputs[i] <= 95)
            {
                sum += inputs[i];
                count++;
            }
        }

        if(count > 0)
        {
            average = sum / (double)count;
        }
        Debug.Log($"평균점수: {average:#.##}");
    }
}

/*
[Q] 
입력데이터   {90, 65, 78, 50, 95}
국어 점수 중 70점 이상이고 95점 이하인 점수들의 평균을 구하라

[output] - 소수점 이하 2자리까지
평균점수: average
 
*/