using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void StartGame()
    {
        GameManager.Instance.LoadScene("GetStarted_Scene");
        GameManager.Instance.ChangeState(GameManager.GameState.Gameplay);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}