using UnityEngine;

//팩토리얼 구하는 알고리즘(4!)
public class RecursionDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //4! = 1 * 2 * 3 * 4
        Debug.Log(4 * 3 * 2 * 1);

        //For Factiorial
        Debug.Log(FactorialFor(4));

        //재귀함수 Factorial
        Debug.Log(Factorial(-4));

        //재귀함수 Factor
        Debug.Log(Factor(4));
    }


    //For문 이용 Factiorial 값 구하기
    int FactorialFor(int n)
    {
        int result = 1;

        for(int i = 1; i<= n; i++)
        {
            result *= i;
        }
        return result;
    }

    //3항 연산자를 이용한 Factorial 만들기
    int Factor(int n)
    {
        /*if (n <= 1)
            return 1;
        return n * Factor(n - 1);*/

        return (n > 1) ? n * Factor(n - 1) : 1;
    }


    //재귀함수 이용 Factorial 값 구하기
    int Factorial(int n)
    {
        //종료 조건 부분
        if(n == 1)
        {
            return 1;
        }
        else if(n <= 0)
        {
            return 404;
        }

            //재귀 호출 부분
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
재귀함수 : 함수가 자신의 코드 블록 안에서 자기 자신을 다시 호출(재귀 호출)하는 함수
- 재귀함수 매개변수 : 매개변수는 감산, 가산이 된다
- 재귀함수 코드 블록 안에는 재기함수를 종료할 수 있는 조건이 필요하다

Factorial (n!)
4! = 4 * 3 * 2 * 1
   = 4 * 3!
         3 * 2!
             2 * 1!
                 1
n! = n * (n-1)!
*/