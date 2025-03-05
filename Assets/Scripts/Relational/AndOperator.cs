using UnityEngine;

//AndOperator(And 연산자)
//결과 : true, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 둘다 참일때 참
        Debug.Log(true && true);    // => true

        //[2] 둘 중에 하나라도 거짓이라면 거짓
        Debug.Log(true && false);   // => false
        Debug.Log(false && true);   // => false
    }
}
