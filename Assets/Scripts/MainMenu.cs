using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void EndGameAndStartNew()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void StartMainMenu()
    {
        SceneManager.LoadScene("FigthScene");
    }
    public void QuitGame()
    {
        //Debug.Log("������ ������ � ������� ������.");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }

}
