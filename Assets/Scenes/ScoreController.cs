using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public Text skorKiri;
    public Text skorKanan;

    public ScoreManager manager;

    private void Update()
    {
        skorKiri.text = manager.leftScore.ToString();
        skorKanan.text = manager.rightScore.ToString();
    }
}
