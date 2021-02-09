using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Math Problem", menuName = "Math Problem")]
public class MathProblems : ScriptableObject {
    public string text;
    public int answer;
    public int score;
}
