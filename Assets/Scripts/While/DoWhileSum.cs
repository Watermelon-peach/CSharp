using UnityEngine;

//doWhile문을 이용해서 1부터 n(100)까지의 정수 중에서 짝수의 합을 구하는 프로그램 구현
public class DoWhileSum : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 0;
        int n = 100;
        int sum = 0;
        do
        {
            if(i%2==0)
            {
                sum += i;
            }

            i++;
        } while (i <= n);
    }
}
