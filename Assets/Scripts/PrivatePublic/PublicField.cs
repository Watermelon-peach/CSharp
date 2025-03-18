using UnityEngine;

namespace PrivatePublic
{
    public class PublicField : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            //Category 클래스의 인스턴스 생성
            Category book = new Category();

            //(다른 클래스의) 필드에 데이터 저장 - 개체이름.멤버이름
            book.CategoryName = "책";

            //필드 사용
            Debug.Log(book.CategoryName);

        }

    }

}
