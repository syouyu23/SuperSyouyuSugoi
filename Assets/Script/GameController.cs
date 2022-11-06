using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ClearUI;
    public GameObject GameOverUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Block").Length;
        int count1 = GameObject.FindGameObjectsWithTag("Ball").Length;
        Debug.Log(count);

        if (count==0)
        {
            Debug.Log("ÉNÉäÉA");
            ClearUI.SetActive(true);
        }
        if (count1 == 0)
        {
            GameOverUI.SetActive(true);
        }

    }
}
