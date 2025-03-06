using UnityEngine;

public class Switch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //"1,2,3,4번 답을 선택했습니다"
        //1,2,3,4번 외의 값을 선택하면 "잘못 선택했습니다" 출력

        int answer = 1;
        /*
        switch(answer)
        {
            case 1:
                Debug.Log("1번 답을 선택했습니다");
                break;
            case 2:
                Debug.Log("2번 답을 선택했습니다");
                break;
            case 3:
                Debug.Log("3번 답을 선택했습니다");
                break;
            case 4:
                Debug.Log("4번 답을 선택했습니다");
                break;

            default:
                Debug.Log("잘못 선택했습니다");
                break;
        }*/

        //if 문
        if (answer == 1)
        {
            Debug.Log("1번 답을 선택했습니다");
        }
        else if (answer == 2)
        {
            Debug.Log("2번 답을 선택했습니다");
        }
        else if (answer == 3)
        {
            Debug.Log("3번 답을 선택했습니다");
        }
        else if (answer == 4)
        {
            Debug.Log("4번 답을 선택했습니다");
        }

        else
        {
            Debug.Log("잘못 선택했습니다");
        }
    }
}
