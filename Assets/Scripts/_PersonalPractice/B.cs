using UnityEngine;

namespace Test
{
    public class A
    {
        //필드
        private string[] arr = { "일", "월", "화", "수", "목", "금", "토" };

        //인스턴트 멤버 함수 만들기
        public void PrintArr()
        {
            foreach (var day in arr)
            {
                Debug.Log(day);
            }
        }

        //정적(static) 멤버 함수 만들기
        public static int Sum(int a, int b)
        {
            return a + b;
        }
    }
    public class B : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //클래스(A)의 인스턴스 함수를 호출하기
            A answer = new A();
            answer.PrintArr();
            //클래스(A)의 정적 함수를 호출하여 결과값을 반환 받아 출력하기 : 매개변수(5, 6)
            Debug.Log(A.Sum(5, 6));
        }


    }
}
