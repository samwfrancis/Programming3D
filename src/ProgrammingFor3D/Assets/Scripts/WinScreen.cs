using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Restart(){
        SceneManager.LoadScene("Game");
    }

    public void SelectDifficulty(){
        SceneManager.LoadScene("Select Difficulty");
    }

    public void Quit(){
        Application.Quit();
    }
}
