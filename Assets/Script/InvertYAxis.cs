using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class InvertYAxis : MonoBehaviour
{
    public Toggle toggle;
    public Slider sensitivitySlider;
    public float lookSensitivity = 10f;
    // Start is called before the first frame update
    void Start()
    {
        toggle.isOn = false;
        toggle.onValueChanged.AddListener(OnToggleValueChanged);
        sensitivitySlider.value = lookSensitivity;
        sensitivitySlider.onValueChanged.AddListener(OnSensitivityChanged);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnToggleValueChanged(bool isOn)
    {
        if (isOn)
        {
            lookSensitivity = -lookSensitivity;
        }
        else
        {
            lookSensitivity = Mathf.Abs(lookSensitivity);
        }
        sensitivitySlider.value = lookSensitivity;
    }

    private void OnSensitivityChanged(float value)
    {
        lookSensitivity = value * (toggle.isOn ? -1 : 1);
    }
}
