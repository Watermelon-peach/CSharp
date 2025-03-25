using UnityEngine;

namespace Test
{
    public class TestTwo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int[] inputs = { -2, -5, -3, -7, -1 };

            //최소값을 저장할 변수 min 선언 및 초기화
            //min 초기값은 int형 최대값으로 지정
            int min = int.MaxValue;

            //최소값 구하기 알고리즘
            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] < min)
                {
                    min = inputs[i];
                }
            }

            //출력
            Debug.Log($"최소값은 {min}");
        }
    }

}
