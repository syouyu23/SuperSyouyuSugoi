using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("s_Main", LoadSceneMode.Single);
    }
}
