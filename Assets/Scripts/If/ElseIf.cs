using UnityEngine;

public class ElseIf : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //score�� 90�� �̻��̸� A, 80�� �̻��̸� B, 70�� �̻��̸� C,
        //60�� �̻��̸� D, ������ F

        int score = 99;
        char grade = 'A';

        //[1] score�� 90�� �̻��̸� A
        if(score >= 90)
        {
            grade = 'A';
        }
        //[2] score�� 80�� �̻��̸� B
        else if (score >= 80)
        {
            grade = 'B';
        }
        //[3] score�� 70�� �̻��̸� C
        else if (score >= 70)
        {
            grade = 'C';
        }
        //[4] score�� 60�� �̻��̸� D
        else if (score >= 60)
        {
            grade = 'D';
        }

        else //[5] ������ F
        {
            grade = 'F';
        }

        Debug.Log($"{grade} ����");
    }
}
