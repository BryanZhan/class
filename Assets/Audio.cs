using UnityEngine;
using System.Collections;

public class Audio : MonoBehaviour {
    AudioSource audio;
    // Use this for initialization
    void Start (){
        audio = GetComponent<AudioSource> ();
    }

    public void PlayAudio(){
        audio.Play ();
    }
    public void PauseAudio(){
        if (audio.isPlaying) {
            audio.Pause ();//音效暫停
            Time.timeScale = 0;//遊戲暫停
        } else {
            audio.UnPause ();
            Time.timeScale = 1;
        }
    }
    public void StopAudio(){
        audio.Stop ();
    }
}


