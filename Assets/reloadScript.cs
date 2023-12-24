using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reloadScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void reloader() {
        playerController.myScore = 0;
        fruitsGenerator.fruitCounter = 0;
        SceneManager.LoadScene("SampleScene");

    }
    public void reloader2() {
        SceneManager.LoadScene("SampleScene");
    }

}
