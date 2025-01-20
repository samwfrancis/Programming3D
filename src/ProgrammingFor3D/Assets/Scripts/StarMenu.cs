using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StarMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Easy(){
        GameManager.playerDifficulty = 1;
        SceneManager.LoadScene("Game");
    }

    public void Medium(){
        GameManager.playerDifficulty = 2;
        SceneManager.LoadScene("Game");
    }

    public void Hard(){
        GameManager.playerDifficulty = 3;
        SceneManager.LoadScene("Game");
    }
}
