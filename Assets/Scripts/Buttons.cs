using UnityEngine;
using UnityEngine.Events;

public class Buttons : MonoBehaviour
{
    public UnityEvent OnRestartGame;


    public void Button_Restart(GameObject endGameWindow)
    {
        endGameWindow.SetActive(false);

        OnRestartGame.Invoke();
    } 


    public void Button_Start(GameObject startGameWindow)
    {
        startGameWindow.SetActive(false);
    }
}