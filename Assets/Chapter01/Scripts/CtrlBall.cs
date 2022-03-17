using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class CtrlBall : MonoBehaviour
{
    public float speed = 10f;
    //GameObject FailPanel;
    // Start is called before the first frame update
    void Start()
    {
      //  FailPanel = GameObject.Find("Canvas/Lose");
        //Debug.Log(FailPanel.name);

        //FailPanel.SetActive(false);
        transform.position = new Vector3(1f, 0.3f, 0f);
    }
    private void MoveBall(){
        float x = Input.GetAxis("Vertical");
        float y = - Input.GetAxis("Horizontal");
        transform.position += new Vector3(Time.deltaTime / 5 * x, 0, y * speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        MoveBall(); 
        if (transform.position.z >= 2 || transform.position.z <= -2){
            transform.position -= new Vector3 (0, Time.deltaTime, 0);            
        }
        if (transform.position.y < -2){
            //FailPanel.SetActive(true);
            Time.timeScale = 0; 
        }
        if (Input.GetKeyDown(KeyCode.R)){
            SceneManager.LoadScene(0);
            Time.timeScale = 1;
        }
        float y = - Input.GetAxis("Horizontal");

        Transform Cam = Camera.main.transform;
        Quaternion cur = Cam.rotation;
        Quaternion targ = cur * Quaternion.Euler(0, 0, y * 0.3f);
        Camera.main.transform.rotation = Quaternion.Slerp(cur, targ, 0.5f);
    }
}
