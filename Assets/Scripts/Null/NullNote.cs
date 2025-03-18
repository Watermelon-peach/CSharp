using UnityEngine;

//null 연산자: ??(null 병합 연사자), ?.(null 조건부 연산자)
public class NullNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //??(null 병합연산자)
        string nullValue = null;
        string message = "";

        //message 변수 초기화
        /*if (nullValue == null)
        {
            message = "null이면 새로운 값으로 초기화";
        }*/
        message = nullValue ?? "null이면 새로운 값으로 초기화";

        Debug.Log(message);

        //?.(null 조건부 연산자)
        int? len;               //msg 길이를 저장하는 변수
        string msg = null;

        /*if (msg != null)
        {
            len = msg.Length;
        }
        else
        {
            len = null;
        }*/

        // msg가 null이면 null을 반황, null 아니면 ?. 뒤에 있는 값 반황
        len = msg?.Length;

        msg = "안녕하세요";
        len = msg?.Length;

        Debug.Log(len);
    }
}
