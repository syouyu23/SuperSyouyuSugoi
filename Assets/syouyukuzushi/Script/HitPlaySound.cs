using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlaySound : MonoBehaviour
{
    //private AudioSource  audio;
    [SerializeField]
    private AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        //audio = gameObject.AddComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Ball")
            
        {
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
