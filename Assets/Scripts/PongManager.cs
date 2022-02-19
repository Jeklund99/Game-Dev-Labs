using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongManager : MonoBehaviour
{
    [SerializeField] private PongGoal p1Goal;
    [SerializeField] private PongGoal p2Goal;
    [SerializeField] private Ball ball;
    [SerializeField] private float maxScore;
    [SerializeField] private TMP_Text p1Text;
    [SerializeField] private TMP_Text p2Text;
    [SerializeField] private GameObject winnerText;


    private float p1Score;
    private float p2Score;
    public static WaitForSeconds waitTime = new WaitForSeconds(5f);

    private void Awake()
    {
        p1Goal.onScore += HandleP2Score; // ball entered goal 1
        p2Goal.onScore += HandleP1Score;
    }

    private void HandleP1Score()
    {
        p1Score++;
        if (p1Score == maxScore)
        {
            p1Text.text = p1Score.ToString();
            StartCoroutine(displayWinner("Blue"));
        }
        else
        {
            p1Text.text = p1Score.ToString();
            ball.Restart();
        }

    }

    private void HandleP2Score()
    {
        p2Score++;
        if (p2Score == maxScore)
        {
            p2Text.text = p2Score.ToString();
            StartCoroutine(displayWinner("Red"));
            
        }
        else
        {
            p2Text.text = p2Score.ToString();
            ball.Restart();
        }
    }

    private IEnumerator displayWinner(string winner)
    {
        winnerText.GetComponent<TMP_Text>().text = winner + " wins!";
        winnerText.SetActive(true);
        ball.Freeze();
        yield return waitTime;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
