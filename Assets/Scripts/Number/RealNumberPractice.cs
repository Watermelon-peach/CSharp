using UnityEngine;

public class RealNumberPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float fl = 3.14f;
        double db = 3.14;
        decimal de = 3.14m;

        Debug.Log($"float: {fl}");
        Debug.Log($"double: {db}");
        Debug.Log($"decimal: {de}");
    }
}

/*
[Q]
�Ǽ��� �� float 3.14, double 3.14, decimal 3.14 �� ����ϱ�

[output]
float: 3.14
double: 3.14
decimal: 3.14
 */