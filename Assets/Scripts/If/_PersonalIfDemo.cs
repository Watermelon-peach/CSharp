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
            medalColor = "��";
        }
        else if(score >= 80)
        {
            medalColor = "��";
        }
        else if(score >= 70)
        {
            medalColor = "��";
        }
        else
        {
            medalColor = "��";
        }
        Debug.Log($"{medalColor}�޴��� �����Ͽ����ϴ�");
    }
}
