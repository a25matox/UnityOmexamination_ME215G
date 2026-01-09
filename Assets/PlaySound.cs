using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    public void Play()
    {
        source.PlayOneShot(clip);
    }
}
