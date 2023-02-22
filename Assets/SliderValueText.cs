using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderValueText : MonoBehaviour
{
    private Slider slider;
    private TextMeshPro textComp;

     void Awake()
    {
        slider = GetComponentInParent<Slider>();
        textComp = GetComponent<TextMeshPro>();
    }

     void Start()
    {
        UpdateText(slider.value);
        slider.onValueChanged.AddListener(UpdateText);
    }

    void UpdateText(float val)
    {
        textComp.text = slider.value.ToString();
    }
}
