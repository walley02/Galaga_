using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoad : MonoBehaviour
{
    public void Loadscenebyname(string Galaga)
    {
        SceneManager.LoadScene(Galaga);
    }
}

