using UnityEngine;

//
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�����Ѱ�
        int[] lotto = new int[6];
        System.Random random = new System.Random();
        //�迭 ���� �ʰ��� �����ϱ� ���� ù��°�� lotto[0] ���� ����
        lotto[0] = random.Next(1, 46);

        //lotto[1] ���� lotto[5]���� ����
        for (int i = 1; i < 6; i++)
        {
            lotto[i] = random.Next(1, 46);

            //�ߺ��˻�: lotto[0] ���� lotto[i-1]���� �ϳ��� �ߺ�Ȯ��
            for(int j  = 0; j < i; j++)
            {
                //�ߺ����� ������ �ٽ� ����
                if (lotto[i] == lotto[j])
                {
                    lotto[i] = random.Next(1, 46);
                }
                else break;
            }
            
        }
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(lotto[i]);
        }
    }
}

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