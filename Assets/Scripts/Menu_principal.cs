using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_principal : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadSceneAsync(1);
    }
}