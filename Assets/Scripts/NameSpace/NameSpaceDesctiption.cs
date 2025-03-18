//네임스페이스 선언부
using UnityEngine;  //UnityEngine 네임스페이스를 가져다 씀.
using Foo;
using Bar;

//NamseSpace(네임 스페이스)
//1. 클래스(사용자 정의 형식) 등들을 서로 관련있는(비슷한 기능) 것들기리 묶어서 관리
//2. 같은 이름의 충돌을 방지
//3. 같은 네임스페이스 안에서는 다른 클래스를 네임스페이스 없이 사용이 가능하다
public class NameSpaceDesctiption : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]Foo 네임스페이스의 Car 클래스 호출
        //Car의 객체 만들기
        Foo.Car FooCar = new Foo.Car();
        FooCar.Go();

        //[2]Bar 네임스페이스의 Car 클래스 호출
        //Car의 객체 만들기
        Bar.Car barcar = new Bar.Car();
        barcar.Go();
    }
}
/*
NameSpace 선언

namespace 네임스페이스 이름
{

}
 
 
 */