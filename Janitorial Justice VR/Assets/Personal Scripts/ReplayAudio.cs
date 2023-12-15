using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReplayAudio : MonoBehaviour
{

    public AudioSource lessonAudio;

    public void RepeatLessonAudio()
    {
        lessonAudio.Play();
    }

}
