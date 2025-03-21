using UnityEngine;

namespace Delegate
{
    //반환값도 있고 매개변수도 있는 메서드의 델리게이트 생성
    public class DelegateDemo : MonoBehaviour
    {
        //[1]Delegate 생성 - double형 반환, 매개변수 int 
        //delegate double (대리자이름) (int)
        delegate double GetCircleArea(int r);


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //[2] Delegate 변수 선언하고 메서드 등록
            GetCircleArea area = GetArea;

            //[3] Delegate 사용
            Debug.Log(area(10));
            Debug.Log(area.Invoke(10));
        }

        //매개변수로 원의 반지름을 입력받아 면적을 구하는 메서드
        double GetArea(int r)
        {
            return System.Math.PI * r * r;
        }
    }

}
