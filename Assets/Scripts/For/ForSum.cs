using UnityEngine;

//1부터 20까지의 합을 구하는 프로그램 구현
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
        Debug.Log($"합은 {sum}");
    }
}
