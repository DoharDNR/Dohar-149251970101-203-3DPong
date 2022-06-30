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
        skorPemain1.text = "Pemain 1 = " + manager.pemain1Score.ToString();
        skorPemain2.text = "Pemain 2 = " + manager.pemain2Score.ToString();
        skorPemain3.text = "Pemain 3 = " + manager.pemain3Score.ToString();
        skorPemain4.text = "Pemain 4 = " + manager.pemain4Score.ToString();
    }
}
