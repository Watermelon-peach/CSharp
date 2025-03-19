using UnityEngine;

namespace Method
{
    //[3] 반환형 전달 방법 (out int num)
    public class ParameterOut : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //정수형 변수 선언, 초기화 x
            int number;
            //Debug.Log($"[1]: {number}");      //값이 없음
            PrintNumber(out number);

            Debug.Log($"[2]: {number}");
        }

        //정수형 out number를 매개변수로 입력받아 출력하는 함수
        //반환형 매개변수 전달 방식
        //참조형 방식과 동일, 함수 내부에서 반드시 초기화(값)을 설정
        void PrintNumber(out int number)
        {
            number = 1234;
            Debug.Log($"[1]: {number}");   //[2] 
        }
    }

}
