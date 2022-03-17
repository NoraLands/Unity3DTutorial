using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CtrlCollider : MonoBehaviour
{
    GameObject PassPanel;

    // Start is called before the first frame update
    void Start()//为什么第一次调用并debug后报了空引用
    {
        PassPanel = GameObject.Find("Canvas/Win");
        Debug.Log(PassPanel.name);
        PassPanel.SetActive(false);
    }

    // Update is called once per frame
    
        private void OnTriggerEnter(Collider other) {
            PassPanel.SetActive(true);             
            Time.timeScale = 0;
        }
}
