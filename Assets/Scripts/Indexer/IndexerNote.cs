using UnityEngine;

namespace Indexer
{
    public class IndexerNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Car클래스의 인스턴스 생성
            Car car = new Car(3);
            car[0] = "제네시스";
            car[1] = "똥구멍";
            car[2] = "아방구";

            //인덱서 사용
            /*for (int i = 0; i < car.length; i++)
            {
                Debug.Log(car[i]);
            }*/

            foreach(var c in car)
            {
                Debug.Log(c);
            }
        }
    }

}
