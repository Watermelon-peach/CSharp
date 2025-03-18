using System.Collections;
using UnityEditor.VersionControl;
using UnityEngine;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]StackŬ������ ��ü(�ν��Ͻ�, ��ü) ����
        Stack stack = new Stack();

        //[2]������ �Է�
        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        //[3]������ ��������
        Debug.Log(stack.Pop()); //?
        Debug.Log(stack.Pop()); //?
        Debug.Log(stack.Pop()); //?

        try
        {
            //����ִ� ���ÿ��� ������ ������
            Debug.Log(stack.Pop());

        }
        catch (System.Exception ex)
        {

            Debug.Log($"��������: {ex.Message}");
        }
    }
}

/*
Stack Ŭ���� : LIFO(Last In First Out) ���·� �����͸� ���� �����ϴ� Ŭ����
LIFO(Last In First Out) : ���Լ���, �������� ���� �����͸� ���� ���� ������
- �ֹ��� ���ø� �׾Ƴ��� ������ ������ ����, �칰�� â�� ������ ����

Push() : ���� ������ ������ �Է�
Pop() : ���� �������� ������ ���
Peek() : ���� ������ �����͵� �� ���� ���(�������� �Է�)�� �������� ���� ��ȯ
Count : ���ÿ� ���� ����Ǿ� �ִ� ������ ��

Overflow : ������ ����á���� �߻�
Underflow : ������ ������� �߻�
 */