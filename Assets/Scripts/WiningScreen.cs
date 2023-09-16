using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WiningScreen : MonoBehaviour
{
    [SerializeField] private GameObject _WiningScreen;
    [SerializeField] private TextMeshProUGUI _FinalScore;
    [SerializeField] private TextMeshProUGUI _Timer;
    private int _score;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("flag"))
        {
            _WiningScreen.SetActive(true);
        }
        if (other.gameObject.CompareTag("Coin"))
        {
            _score += 1;
            _FinalScore.text = "SCORE: " + _score.ToString();
        }
        _Timer.text = "TIME: " + Time.timeSinceLevelLoad + "secs";

    }
    
}
