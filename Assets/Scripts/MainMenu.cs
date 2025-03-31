using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private AudioSource click;

    // Start is called before the first frame update
    void Start()
    {
        click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play() {
        click.Play();
        SceneManager.LoadScene("Instructions");
    }

    public void quit() {
        click.Play();
        Application.Quit();
    }

    public void continueGame() {
        click.Play();
        SceneManager.LoadScene("Play");
    }

    public void mainMenu() {
        click.Play();
        SceneManager.LoadScene("MainMenu");
    }
}
