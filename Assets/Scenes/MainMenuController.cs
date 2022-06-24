using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("PermainanPong");
    }

    public void OpenAuthor()
    {
        SceneManager.LoadScene("CreditScene");
        Debug.Log("Created By DoharSiregar - 149251970101-203");
    }
}
