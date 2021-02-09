using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;
    public Image fill;

    public void SetMaxProgress(int progress, float currentProgress) {
        slider.maxValue = progress;
        slider.value = (int)currentProgress;
    }

    public void SetProgress(float progress) {
        slider.value = Mathf.Round(progress);
    }
}
