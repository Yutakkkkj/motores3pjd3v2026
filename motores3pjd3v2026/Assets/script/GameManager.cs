using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState CurrentState;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        ChangeState(GameState.Iniciando);
        LoadScene("Splash");
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;
        Debug.Log("Estado atual: " + CurrentState);
    }

    public void LoadScene(string sceneName)
    {
        // Controle de mudança de cena baseado no estado
        switch (CurrentState)
        {
            case GameState.Iniciando:
                SceneManager.LoadScene(sceneName);
                break;

            case GameState.MenuPrincipal:
                SceneManager.LoadScene(sceneName);
                break;

            case GameState.Gameplay:
                SceneManager.LoadScene(sceneName);
                break;

            default:
                Debug.LogWarning("Mudança de cena não permitida!");
                break;
        }
    }

    // Botão de iniciar jogo
    public void StartGame()
    {
        ChangeState(GameState.Gameplay);
        LoadScene("GetStarted_Scene");
    }

    // Botão de sair
    public void QuitGame()
    {
        Debug.Log("Saindo do jogo...");
        Application.Quit();
    }

    // Input (simples - single player)
    public void AssignInput(PlayerInput playerInput)
    {
        Debug.Log("Input atribuído ao jogador");
    }
}