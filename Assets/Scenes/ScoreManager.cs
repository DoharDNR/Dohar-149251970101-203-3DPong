using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public int pemain1Score, pemain2Score, pemain3Score, pemain4Score;
    public GameObject pemain1Obj, pemain2Obj, pemain3Obj, pemain4Obj;
    public bool isPemain1, isPemain2, isPemain3, isPemain4;

    public int maxScore;
    public int jumlahPemain = 4;

    public void AddPemain1Score(int increment)
    {
        if (isPemain1)
        {
            pemain1Score += increment;
            if (pemain1Score >= maxScore)
            {
                pemain1Obj.SetActive(false);
                isPemain1 = false;
                jumlahPemain -= 1;
            }
        }
    }

    public void AddPemain2Score(int increment)
    {
        if (isPemain2)
        {
            pemain2Score += increment;
            if (pemain2Score >= maxScore)
            {
                pemain2Obj.SetActive(false);
                isPemain2 = false;
                jumlahPemain -= 1;
            }
        }
    }

    public void AddPemain3Score(int increment)
    {
        if (isPemain3)
        {
            pemain3Score += increment;
            if (pemain3Score >= maxScore)
            {
                pemain3Obj.SetActive(false);
                isPemain3 = false;
                jumlahPemain -= 1;
            }
        }
    }

    public void AddPemain4Score(int increment)
    {
        if (isPemain4)
        {
            pemain4Score += increment;
            if (pemain4Score >= maxScore)
            {
                pemain4Obj.SetActive(false);
                isPemain4 = false;
                jumlahPemain -= 1;
            }
        }
    }

    void Update()
    {
        if(jumlahPemain == 1)
        {
            gameObject.SetActive(false);
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenuPong");
    }
}