using UnityEngine;

public class TryCatchFinallyDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 5;
        int y = 0;
        int r = 0;


        try     //예외가 발생할 가능성이 있는 명령문
        {
            //[1]
            r = x / y;
            Debug.Log($"{x} / {y} = {r}");
        }
        catch   //try 절에서 예외가 발생하면 catch절을 실행
        {
            //[2]
            Debug.Log("예외가 발생했습니다");
        }
        finally //try 절에서 예외가 발생하든, 안 하든 상관 없이 실행
        {
            //[3]
            Debug.Log("프로그램을 종료합니다");
        }

        //try 절에서 예외가 발생하면 : [1] -> [2] -> [3]
        //try 절에서 예외가 발생 안 하면 : [1] -> [3]
    }
}
