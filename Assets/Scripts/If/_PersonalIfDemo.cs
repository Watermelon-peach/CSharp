using UnityEngine;

public class _PersonalIfDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 90;
        string medalColor = "";
        if(score >= 90)
        {
            medalColor = "금";
        }
        else if(score >= 80)
        {
            medalColor = "은";
        }
        else if(score >= 70)
        {
            medalColor = "동";
        }
        else
        {
            medalColor = "노";
        }
        Debug.Log($"{medalColor}메달을 수상하였습니다");
    }
}
