using UnityEngine;

public class IfElsePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 90;
        string medal = "";
        //90 �̻��̸� ��
        if(score >=90)
        {
            medal = "��";
        }
        else
        {
            //80 �̻��̸� ��
            if(score >=80)
            {
                medal = "��";
            }
            else
            {
                //70 �̻��̸� ��
                if(score >= 70)
                {
                    medal = "��";
                }
                else // 0~69
                {
                    medal = "��";
                }
            }
        }
        Debug.Log($"{medal}�޴��� �����Ͽ����ϴ�");
    }
}



/*
[Q]
score�� 90�̻��̸� �ݸ޴� ���, 80�̻��̸� ���޴� ���
70 �̻��̸� ���޴� ���, �� �� �������� ��޴� ���
score�� 85��

[output]
()�޴��� �����Ͽ����ϴ�
 */