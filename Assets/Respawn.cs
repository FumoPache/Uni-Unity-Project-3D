using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync("SimpleNaturePack/Scenes/Level");
    }

}
