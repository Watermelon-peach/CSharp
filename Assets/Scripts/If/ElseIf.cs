using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score가 90점 이상이면 A, 80점 이상이면 B, 70점 이상이면 C,
        //60점 이상이면 D, 나머지 F

        int score = 99;
        char grade = 'A';

        //[1] score가 90점 이상이면 A
        if(score >= 90)
        {
            grade = 'A';
        }
        //[2] score가 80점 이상이면 B
        else if (score >= 80)
        {
            grade = 'B';
        }
        //[3] score가 70점 이상이면 C
        else if (score >= 70)
        {
            grade = 'C';
        }
        //[4] score가 60점 이상이면 D
        else if (score >= 60)
        {
            grade = 'D';
        }

        else //[5] 나머지 F
        {
            grade = 'F';
        }

        Debug.Log($"{grade} 학점");
    }
}
