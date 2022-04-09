using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChangeScene : MonoBehaviour
{
    public void NextLevel(string _scenename)
    {
        SceneManager.LoadScene(_scenename);
    }
}