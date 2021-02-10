using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GmController : MonoBehaviour
{
    public Player player;
    public Boss boss;
    public MathProblems[] problems;
    public ProgressBar timer, power;
    public TextMeshProUGUI currentMathProblem;
    public GameObject VictoryUI, DefeatUI;

    public float currentTime, currentPower;
    public int maxTimer = 100, maxPower = 100;
    public int currentMathProblemId;
    
    // Start is called before the first frame update
    void Start()
    {
        currentMathProblemId = 0;

        currentTime = maxTimer; 
        timer.SetMaxProgress(maxTimer, currentTime);

        currentPower = 0;
        power.SetMaxProgress(maxPower, currentPower);

        ChangeUIProblem();
    }

    // Update is called once per frame
    void Update()
    {

        if (currentTime <= 0) {
            Defeat();
        } else {
            // Decrease time on UI bar
            currentTime -= Time.deltaTime;
            timer.SetProgress(currentTime);
        }
    }

    public void AnswerIsCorrect(int value) {
        if (problems[currentMathProblemId].answer == value) {
            // Show next math problem
            currentMathProblemId += 1;
            ChangeUIProblem();

            // Reset timer
            currentTime = maxTimer;
            timer.SetProgress(maxTimer);

            // Increase power bar
            currentPower += 10;
            power.SetProgress(currentPower);

            boss.TakeDamage(183);
        } else {
            Debug.Log("Resposta ERRADA");
            player.TakeDamage(20);
        }

        if (player.GetHealth() <= 0) {
            Defeat();
        }
    }

    public void ChangeUIProblem() {
        // Change UI math problem text
        currentMathProblem.text = string.Format("{0:n0}", problems[currentMathProblemId].text);
    }

    public void Defeat() {
        DefeatUI.SetActive(true);
        GameObject.Find("MathProblems").SetActive(false);
    }
}
