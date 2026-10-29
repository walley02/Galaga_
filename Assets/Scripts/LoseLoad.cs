using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseLoad : MonoBehaviour
{
    public void Loadscenebyname(string Lose)
    {
        SceneManager.LoadScene(Lose);
    }
}

