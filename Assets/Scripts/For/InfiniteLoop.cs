using UnityEngine;

//InfiniteLoop(무한루프): 
public class InfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(; ; )
        {
            Debug.Log("무한루프");
        }
    }
}
