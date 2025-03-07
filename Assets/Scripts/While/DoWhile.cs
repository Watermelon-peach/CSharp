using UnityEngine;

public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
         //While
         //[1]초기식
         int i = 0;

         while(i < 3)    //조건식
         {
             //반복실행문
             Debug.Log("안녕하세요");

             //[2]증감식
             i++;

         }*/

        //doWhile
        //[1]초기식
        int i = 0;

        do
        {
            //반복 실행문
            Debug.Log("안녕하세요");

            //[2]증감식
            i++;
        } while (i < 3);    //[3] 조건식

        //i:0 => 출력 => i:1 => i<3 (참) => 출력 => i:2 => i<3 (참) => 출력
        //i:3 => i<3 (거짓) => do while 종료
    }
}
/*
doWhile 문 - 반복문
먼저 반복 실행문 1번 실행한다
조건식이 true이면 반복문을 실행한다
조건식이 false이면 while문 종료한다

do
{
    //반복 실행문

} while (조건식)
 
 
*/