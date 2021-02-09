using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GmController : MonoBehaviour
{
    public Player player;
    public MathProblems[] problems;
    public ProgressBar timer, power;
    public TextMeshProUGUI currentMathProblem;

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
        // Decrease time on UI bar
        currentTime -= Time.deltaTime;
        timer.SetProgress(currentTime);
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
        } else {
            Debug.Log("Resposta ERRADA");
            player.TakeDamage(20);
        }
    }

    public void ChangeUIProblem() {
        // Change UI math problem text
        currentMathProblem.text = string.Format("{0:n0}", problems[currentMathProblemId].text);
    }
}
