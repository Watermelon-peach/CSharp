using UnityEngine;

//AndOperator(And ������)
//��� : true, false
public class AndOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] �Ѵ� ���϶� ��
        Debug.Log(true && true);    // => true

        //[2] �� �߿� �ϳ��� �����̶�� ����
        Debug.Log(true && false);   // => false
        Debug.Log(false && true);   // => false
    }
}
