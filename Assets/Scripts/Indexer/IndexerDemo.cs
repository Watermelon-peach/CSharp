using UnityEngine;
namespace Indexer
{
    public class IndexerDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Person 클래스의 인스턴스 생성
            Person person = new Person();
            person[0] = "홍길똥";
            Debug.Log(person[0]);   //홍길똥

            person[1] = "뿡빵삥";
            Debug.Log(person[1]);   //뿡빵삥

            Debug.Log(person[0]);   //뿡빵삥
        }
    }

}
