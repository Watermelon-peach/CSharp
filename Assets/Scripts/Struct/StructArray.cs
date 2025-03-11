using Unity.VisualScripting;
using UnityEngine;

//[1] ����ü ����, ����: ���� �����͸� �����ϴ� ����ü
struct UserInfo
{
    public string name; //�� �̸�
    public int age;     //�� ����
    //....

}
public class StructArray : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] ����ü ���� ����
        UserInfo info;
        //[2] ����ü �ʱ�ȭ
        info.name = "ȫ�浿";
        info.age = 20;
        //[3] ����ü ���
        //PrintUserInfo(info.name, info.age);
        PrintUserInfo(info);

        //[1] ����ü�� �迭 ���� ����, �迭�� ��Ҽ�(ũ��) ����
        UserInfo[] userInfos = new UserInfo[2];
        //[2] ����ü �迭�� �ʱ�ȭ
        userInfos[0].name = "��λ�";
        userInfos[0].age = 22;
        userInfos[1].name = "�Ӳ���";
        userInfos[1].age = 33;

        //[3] ����ü �迭 ���
        PrintUserInfo(userInfos);
    }
    //���� ����� ����ϴ� �Լ�
    void PrintUserInfo(string name, int age)
    {
        Debug.Log($"{name}���� ���̴� {age}���Դϴ�.");
    }

    void PrintUserInfo(UserInfo userInfo)
    {
        Debug.Log($"{userInfo.name}���� ���̴� {userInfo.age}���Դϴ�.");
    }

    void PrintUserInfo(UserInfo[] userInfos)
    {
        for (int i = 0; i < userInfos.Length; i++)
        {
            Debug.Log($"{ userInfos[i].name}���� ���̴� {userInfos[i].age}���Դϴ�.");
        }
    }
 
}
