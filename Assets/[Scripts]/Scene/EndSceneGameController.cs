using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneGameController : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<SoundManager>().PlayMusic(Sound.END_MUSIC);
    }

}
