using UnityEngine;

//1���� n(10)������ ���� �� ¦���� ���� ���ϴ� ���α׷� ����
public class ForSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        for (int i = 0; i < n+1; i+=2)
        {
            sum += i;
        }
        Debug.Log($"1���� {n}������ ¦���� ���� {sum}");
    }
}
