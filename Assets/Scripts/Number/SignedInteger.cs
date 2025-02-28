using UnityEngine;

public class SignedInteger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //SignedInteger (+, -) ��ȣ�� �ִ� ������ ������ ����(Ÿ��)
        sbyte iSbyte = 127; //8bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        short iInt16 = 32767; //16bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        int iInt32 = 2147483647; //32bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ
        long iInt64 = 9223372036845775807; //64bit ��ȣ�� �ִ� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("sbyte: " + iSbyte);
        Debug.Log("Short: " + iInt16);
        Debug.Log("int: " + iInt32);
        Debug.Log("long: " + iInt64);

        //UnSignedInteger (+, -) ��ȣ�� ���� ������ ������ ����(Ÿ��)
        byte iByte = 255; //8bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ushort iUInt16 = 65535; //16bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        uint iUInt32 = 429496785; //32bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ
        ulong iUInt64 = 18446744073709551615; //64bit ��ȣ�� ���� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log("byte: " + iByte);
        Debug.Log("uShort: " + iUInt16);
        Debug.Log("uint: " + iUInt32);
        Debug.Log("ulong: " + iUInt64);
    }
}

/*
1 Bit 0,1

1 Byte : 8 bit

0000 0000 -> 0
0000 0001 -> 1
0000 0010 -> 2
0000 0011 -> 3
0000 0100 -> 4

8bit
(+, -, 0)
sbyte : -128 ~ 127

(+, 0)
byte  : 0 ~ 255
*/


/* 



 



 
*/