using UnityEngine;

//1���� 20������ ���� ���ϴ� ���α׷� ����
public class ForSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int sum = 0;
        
        for(int i = 1; i<21; i++)
        {
            sum += i;
        }
        Debug.Log($"���� {sum}");
    }
}
