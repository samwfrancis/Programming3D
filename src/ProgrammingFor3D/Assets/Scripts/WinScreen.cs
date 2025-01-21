using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField] private AudioSource levelComplete;
    [SerializeField] private AudioClip levelCompleteAudio;
    // Start is called before the first frame update
    void Start()
    {
        levelComplete.PlayOneShot(levelCompleteAudio);
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
