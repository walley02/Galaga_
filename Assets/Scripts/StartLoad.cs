using UnityEngine;
using UnityEngine.SceneManagement;

public class StartLoad : MonoBehaviour
{
    public void Loadscenebyname(string Start)
    {
        SceneManager.LoadScene(Start);
    }
}

