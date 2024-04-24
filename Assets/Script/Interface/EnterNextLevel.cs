using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterNextLevel : MonoBehaviour
{

    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
    }
}
