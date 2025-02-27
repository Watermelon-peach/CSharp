using UnityEngine;

// Constant(상수) : 변하지 않는 변수, 읽기 전용 변수
public class ConstantDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 정수 형식의 상수 선언
        const int MAX = 100;

        //[2] 상수 사용하기
        Debug.Log("쵀대값 :" + MAX);
    }
}
