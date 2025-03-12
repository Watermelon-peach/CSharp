using UnityEngine;

public class EnumIndexChange : MonoBehaviour
{
    //[1] 동물들을 구분하는 열거형 생성
    // 열거형 값은 순서대로 0부터 시작해서 1씩 증가한다
    enum Animale
    {
        Horse,  //0
        Sheep = 5,  //1->5
        Monkey  //2->6 앞에서 값을 지정하면 앞의 값 + 1로 바뀜
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey);     // ?
    }

}
