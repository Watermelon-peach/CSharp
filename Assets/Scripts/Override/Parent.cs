using System.Xml.Serialization;
using UnityEngine;

namespace Override
{
    //부모 클래스
    public class Parent
    {
        public void Say() => Debug.Log("부모 ㅎㅇ");
        public void Run() => Debug.Log("부모 런침");
        public virtual void Walk() => Debug.Log("부모 못뜀");
    }

    //자식 클래스
    public class Child : Parent
    {
        //virtual이 없으면 new, virtual이 있으면 override로 덮어쓸 수 있음
        public  void Say() => Debug.Log("자식 ㅎㅇ");
        public new void Run() => Debug.Log("자식 런침");
        public override void Walk() => Debug.Log("자식 못뜀");

    }
}
