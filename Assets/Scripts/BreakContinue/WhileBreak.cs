using UnityEngine;

//1터 10까지의 정수의 합을 구하는 프로그램 구현
//구한 합이 22이상이 되면 더이상 합을 구하지 않는다
//while문 이용
public class WhileBreak : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int sum = 0;
        int goal = 22;

        //초기식
        int i = 0;

        while(i <= n)   //조건식
        {
            //반복실행문
            sum += i;

            //구한 합(sum)이 22(goal)이상이 되면
            if(sum >= goal)
            {
                Debug.Log(sum);
                break;
            }

            //증감식
            i++;
        }
    }
}
