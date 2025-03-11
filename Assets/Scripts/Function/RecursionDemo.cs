using UnityEngine;

//���丮�� ���ϴ� �˰���(4!)
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Factiorial
        Debug.Log(FactorialFor(4));

        //����Լ� Factorial
        Debug.Log(Factorial(-4));

        //����Լ� Factor
        Debug.Log(Factor(4));
    }


    //For�� �̿� Factiorial �� ���ϱ�
    int FactorialFor(int n)
    {
        int result = 1;

        for(int i = 1; i<= n; i++)
        {
            result *= i;
        }
        return result;
    }

    //3�� �����ڸ� �̿��� Factorial �����
    int Factor(int n)
    {
        /*if (n <= 1)
            return 1;
        return n * Factor(n - 1);*/

        return (n > 1) ? n * Factor(n - 1) : 1;
    }


    //����Լ� �̿� Factorial �� ���ϱ�
    int Factorial(int n)
    {
        //���� ���� �κ�
        if(n == 1)
        {
            return 1;
        }
        else if(n <= 0)
        {
            return 404;
        }

            //��� ȣ�� �κ�
            return n * Factorial(n - 1);
    }
    /*
               4 * Factorial(3)
                   3 * Factorial(2)
                       2 * Factorial(1)
                           1 * Factorial(0)
                               0 * Factorial(-1)
     */
}
/*
����Լ� : �Լ��� �ڽ��� �ڵ� ��� �ȿ��� �ڱ� �ڽ��� �ٽ� ȣ��(��� ȣ��)�ϴ� �Լ�
- ����Լ� �Ű����� : �Ű������� ����, ������ �ȴ�
- ����Լ� �ڵ� ��� �ȿ��� ����Լ��� ������ �� �ִ� ������ �ʿ��ϴ�

Factorial (n!)
4! = 4 * 3 * 2 * 1
   = 4 * 3!
         3 * 2!
             2 * 1!
                 1
n! = n * (n-1)!
*/