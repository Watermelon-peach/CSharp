using UnityEngine;

public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] long�� ���� l�� �����ϰ� long�� ������ ���� �� �ִ� ���� ū �� ����
        long l = long.MaxValue;
        Debug.Log($"l�� ��: {l}"); // �ܼ�â�� ����϶�

        //[2] int�� ���� i�� �����ϰ� l���� ����
        /*
        int i = l;
        Debug.Log($"i�� ��: {i}");
        */
    }
}
