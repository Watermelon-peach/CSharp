using UnityEngine;

//1�� 10������ ������ ���� ���ϴ� ���α׷� ����
//���� ���� 22�̻��� �Ǹ� ���̻� ���� ������ �ʴ´�
//while�� �̿�
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        //�ʱ��
        int i = 0;

        while(i <= n)   //���ǽ�
        {
            //�ݺ����๮
            sum += i;

            //���� ��(sum)�� 22(goal)�̻��� �Ǹ�
            if(sum >= goal)
            {
                Debug.Log(sum);
                break;
            }

            //������
            i++;
        }
    }
}
