using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;
    public void SceneLoad()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
