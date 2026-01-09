using UnityEngine;

public class ChangeMusicScript : MonoBehaviour
{

    private int id;
    public AudioFade music;
    public AudioFade AmbienceGameObject;
    public void method()
    {
        bool done = false;
        if (id == 0 && !done)
        {
            AmbienceGameObject.StartFadeIn();
            music.StartFadeOut();
            Debug.Log("id: " + id);
            id++;
            done = true;
        }
        if (id == 1 && !done)
        {
            music.StartFadeIn();
            AmbienceGameObject.StartFadeOut();
            Debug.Log("id: " + id);
            id++;
            done = true;
            if (id > 1)
                id = 0;
            
        }
    }
}
