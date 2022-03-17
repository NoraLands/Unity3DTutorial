
using UnityEngine;

public class TestInvoke : MonoBehaviour
{
    public GameObject prefab;
    int Counter = 0;
    void Start()
    {
        Invoke("CreatePrefab", 0.5f);
        Debug.Log("Invoke 1 is been called");
    }

    void CreatePrefab(){
        Vector3 pos = new Vector3(  Mathf.Cos(Counter * 2 * Mathf.PI) / 10, 0, Mathf.Sin(Counter * 2 * Mathf.PI) / 10);
        pos *= 5;
        Instantiate(prefab, pos, Quaternion.identity);
        Counter++;
        if (Counter < 10){
            Invoke("CreatePrefab", 0.5f);
            Debug.Log("Invoke 1 is been called" + Counter);
        }
    }
}
