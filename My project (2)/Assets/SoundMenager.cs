using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMenager : MonoBehaviour
{
    public static AudioClip walkingsound;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

   //  walkingsound = Assets.Load<AudioClip>("walkingsound");
     //  P�niej ogarn� bo errory wipierdalaj�
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "walking":
                audioSrc.PlayOneShot(walkingsound);
                break;
        }
    }
}
