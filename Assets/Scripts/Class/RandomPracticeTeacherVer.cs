using UnityEngine;

public class RandomPracticeTeacherVer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //RandomŬ���� ��ü(��ü,�ν��Ͻ�) ����
        System.Random rand = new System.Random();

        //�迭 ���� ���� �� ��Ҽ� ����
        int[] numbers = new int[6];
        bool flag = false;
        int number = 0;

        for (int i = 0; i < 6; i++)
        {
            //1~46 �������� �޾ƿ´�
            number = rand.Next(1, 46);

            //�ߺ� üũ - number�� ���� ���� �ζǹ�ȣ ���ؼ� �˻�
            flag = false;
            if (i > 0)
            {
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == number)
                    {
                        flag = true;
                    }
                }
            }


            //
            if(flag == false)   //�ߺ��� �ƴϸ�
            {
                numbers[i] = number;
            }
            else //�ߺ��̸� �ٽ� ���
            {
                i--;
            }
        }

        //�ζǹ�ȣ ���
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(numbers[i]);
        }
    }
}
/*
numbers[0] x
numbers[1] : [0]
numbers[2] : [0] [1]
numbers[3] : [0] [1] [2]
numbers[4] : [0] [1] [2] [3]
numbers[5] : [0] [1] [2] [3] [4]
 
 
 */

/*
[Q]
�ζ� ��ȣ ������ �����
[1] 6�� ��ȣ
[2] 1~45�� ������ ���� ��ȣ
[3] �ߺ��� ���ڰ� ������ �ȵȴ�.

[output] - ���ǿ� �´� ��ȣ 6�� ���
1
2
3
4
5
6
 */