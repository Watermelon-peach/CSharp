using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         //While
         //[1]�ʱ��
         int i = 0;

         while(i < 3)    //���ǽ�
         {
             //�ݺ����๮
             Debug.Log("�ȳ��ϼ���");

             //[2]������
             i++;

         }*/

        //doWhile
        //[1]�ʱ��
        int i = 0;

        do
        {
            //�ݺ� ���๮
            Debug.Log("�ȳ��ϼ���");

            //[2]������
            i++;
        } while (i < 3);    //[3] ���ǽ�

        //i:0 => ��� => i:1 => i<3 (��) => ��� => i:2 => i<3 (��) => ���
        //i:3 => i<3 (����) => do while ����
    }
}
/*
doWhile �� - �ݺ���
���� �ݺ� ���๮ 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� false�̸� while�� �����Ѵ�

do
{
    //�ݺ� ���๮

} while (���ǽ�)
 
 
*/