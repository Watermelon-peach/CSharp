using UnityEditor.VersionControl;
using UnityEngine;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] result = new int[5];
        result[0] = Add(5, 3);
        result[1] = Substract(5, 3);
        result[2] = Multiply(5, 3);
        result[3] = Devide(5, 3);
        result[4] = Remainder(5, 3);

        Debug.Log(string.Join(", ", result));
        Hi();
    }

    int Add(int x, int y)
    {
        return x + y;
    }

    //ȭ��ǥ �Լ�, ���ٽ�, ����� �Լ�
    int Substract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Devide(int x, int y) => x / y;
    int Remainder(int x, int y) => x % y;

    void Hi() => Debug.Log("�ȳ��ϼ���");
}

/*
[Q]
��Ģ������ ���ϴ� �Լ� �����
�ΰ��� ������ �Է¹޾� +, -, *, /, % ����Ͽ�
������� ��ȯ�ϴ� �Լ� �����
Add, Substract, Multiply, Devide, Remainder
 
�Է°�: 5, 3
[output]

 
 */