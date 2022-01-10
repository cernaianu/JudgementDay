using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlignmentController : MonoBehaviour
{
    private Slider alignmentSlider;
    private float initialStartingPoint = 0f;

    void Start()
    {
        alignmentSlider = GetComponent<Slider>();
        alignmentSlider.value = initialStartingPoint;
    }

    public float getCurrentValue()
    {
        return alignmentSlider.value;
    }

    public void setCurrentValue(float value)
    {
        alignmentSlider.value = value;
    }

}
