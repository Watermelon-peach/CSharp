using UnityEngine;

//
public class RandomPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //내가한거
        int[] lotto = new int[6];
        System.Random random = new System.Random();
        //배열 범위 초과를 방지하기 위해 첫번째값 lotto[0] 따로 설정
        lotto[0] = random.Next(1, 46);

        //lotto[1] 부터 lotto[5]까지 생성
        for (int i = 1; i < 6; i++)
        {
            lotto[i] = random.Next(1, 46);

            //중복검사: lotto[0] 부터 lotto[i-1]까지 하나씩 중복확인
            for(int j  = 0; j < i; j++)
            {
                //중복값이 있으면 다시 생성
                if (lotto[i] == lotto[j])
                {
                    lotto[i] = random.Next(1, 46);
                }
                else break;
            }
            
        }
        for (int i = 0; i < 6; i++)
        {
            Debug.Log(lotto[i]);
        }
    }
}

/*
[Q]
로또 번호 생성기 만들기
[1] 6개 번호
[2] 1~45번 사이의 랜덤 번호
[3] 중복된 숫자가 나오면 안된다.

[output] - 조건에 맞는 번호 6개 출력
1
2
3
4
5
6
 */