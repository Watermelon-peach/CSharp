using UnityEngine;

// + : 더하기 연산의 추가 기능
public class AdditionOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello" + "World!!!");    //문자열 더하기
        Debug.Log("Hi" + " " + "EveryOne");

        Debug.Log("123" + "456");           // 문자열 + 문자열 => 문자열 123456
        Debug.Log("123" + 456);             // 문자열 + 숫자 => 문자열 123456

        Debug.Log(123 + "456" + 789 + 890 + 890); // 숫자 + 문자열 => 문자열 123456789890
        Debug.Log(123 + 456);               // 숫자 + 숫자 => 숫자 579

        Debug.Log("123" + true);            // 문자열 + bool형 => 문자열 123True

        //Debug.Log("123" - 156); =>문자열은 빼기 없음 (컴파일 에러)
    }
}
