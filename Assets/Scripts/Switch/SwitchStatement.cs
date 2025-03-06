using UnityEngine;

public class SwitchStatement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("¿À´Ã ³¯¾¾´Â ¾î¶²°¡¿ä? (¸¼À½, Èå¸², ºñ, ´«)");
        string weather = "„¢Œæ˜Š‡–¨U";

        switch(weather)
        {
            case "¸¼À½":
                Debug.Log("¿À´Ã ³¯¾¾´Â ¸¼½À´Ï´Ù");
                break;

            case "Èå¸²":
                Debug.Log("¿À´Ã ³¯¾¾´Â Èå¸³´Ï´Ù");
                break;

            case "ºñ":
                Debug.Log("¿À´Ã ³¯¾¾´Â ºñ°¡ ³»¸³´Ï´Ù");
                break;

            case "´«":
                Debug.Log("¿À´Ã ³¯¾¾´Â ´«ÀÌ ³»¸³´Ï´Ù");
                break;

            default:
                Debug.Log("È¤½Ã ¿ì¹ÚÀÌ ¿À³ª¿ä?");
                break;
        }

    }
}
