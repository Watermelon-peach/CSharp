using UnityEngine;

public class EnumIndexChange : MonoBehaviour
{
    //[1] �������� �����ϴ� ������ ����
    // ������ ���� ������� 0���� �����ؼ� 1�� �����Ѵ�
    enum Animale
    {
        Horse,  //0
        Sheep = 5,  //1->5
        Monkey  //2->6 �տ��� ���� �����ϸ� ���� �� + 1�� �ٲ�
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log((int)Animale.Monkey);     // ?
    }

}
