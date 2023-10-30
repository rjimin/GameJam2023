using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishiSound;

    private bool levelCompleted = false;

    // Start is called before the first frame update
    private void Start()
    {
        finishiSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collison) 
    {
        if(collison.gameObject.name == "Player" && !levelCompleted)
        {
            finishiSound.Play();
            levelCompleted = true;
            Invoke("CompleteLevel", 2f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(2);
    }
}
