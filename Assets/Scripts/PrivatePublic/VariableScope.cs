using UnityEngine;

namespace PrivatePublic
{
    public class VariableScope : MonoBehaviour
    {
        // 필드 선언부
        string globalVariable = "전역변수";
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[1] 지역변수 선언 및 사용
            string localVariable = "지역변수";
            Debug.Log(localVariable);

            //[2] 함수 호출 - 전역변수 사용
            TestPrint();
        }

        void TestPrint()
        {
            //Debug.Log(localVariable); error

            //[2] 전역변수 사용
            Debug.Log(globalVariable);
        }
    }

}
