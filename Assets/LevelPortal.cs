using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher : SceneOpener
{
    public string lvlToOpen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(lvlToOpen);
    }
}