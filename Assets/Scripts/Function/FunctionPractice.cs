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

    //화살표 함수, 람다식, 축약형 함수
    int Substract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Devide(int x, int y) => x / y;
    int Remainder(int x, int y) => x % y;

    void Hi() => Debug.Log("안녕하세요");
}

/*
[Q]
사칙연산을 구하는 함수 만들기
두개의 정수를 입력받아 +, -, *, /, % 계산하여
결과값을 반환하는 함수 만들기
Add, Substract, Multiply, Devide, Remainder
 
입력값: 5, 3
[output]

 
 */