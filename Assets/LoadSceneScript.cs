using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadSceneScript : MonoBehaviour
{
    public string sceneName;
    public void loadScene()
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Additive);
    }
}
