using UnityEngine.UI;
using UnityEngine;

public class LoadingAnimHammer : MonoBehaviour
{

    public Slider slider;


    public void SetMaxValue(float Timeline)
    {
        slider.value = Timeline;
        slider.maxValue = Timeline;
    }
    public void SetValue(float OverTime)
    {
        slider.value = OverTime;
    }
}
