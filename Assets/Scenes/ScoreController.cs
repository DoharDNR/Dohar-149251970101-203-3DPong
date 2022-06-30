using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public Text skorPemain1;
    public Text skorPemain2;
    public Text skorPemain3;
    public Text skorPemain4;

    public ScoreManager manager;

    private void Update()
    {
        skorPemain1.text = manager.pemain1Score.ToString();
        skorPemain2.text = manager.pemain2Score.ToString();
        skorPemain3.text = manager.pemain3Score.ToString();
        skorPemain4.text = manager.pemain4Score.ToString();
    }
}
