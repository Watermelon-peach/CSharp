using UnityEngine;

//InfiniteLoop(公茄风橇): 
public class InfiniteLoop : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(; ; )
        {
            Debug.Log("公茄风橇");
        }
    }
}
