using UnityEngine;

public class SquareClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Square 클래스의 정적(static) 메서드 GetNamd(); 호출
        //정적 메서드 호출 방법: 클래스이름(Square).메서드이름(GetName())
        string name = Square.GetName();
        Debug.Log(name);
    }
}
