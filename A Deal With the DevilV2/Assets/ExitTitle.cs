using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitTitle : MonoBehaviour
{
    public int NextScene = 1;
    public float Timer;
   
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(Timer);
        SceneManager.LoadScene(NextScene);
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeScene());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
