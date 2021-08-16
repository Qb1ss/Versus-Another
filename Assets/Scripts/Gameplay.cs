using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour
{
    [Header ("UI")]
    [SerializeField] private Slider _slider;
    [Space(height: 5f)]

    [SerializeField] private GameObject _redResultPanel;
    [SerializeField] private GameObject _blueResultPanel;
    [Space (height: 5f)]

    [Header("Audio")]
    [SerializeField] private AudioSource _tapEffect;


    public void Button_Up()
    {
        _slider.value--;

        _tapEffect.Play();

        �heckStatus();
    }


    public void Button_Down()
    {
        _slider.value++;

        _tapEffect.Play();

        �heckStatus();
    }


    private void �heckStatus()
    {
        if (_slider.value == _slider.minValue)
        {
            _redResultPanel.SetActive(true);
        }
        if (_slider.value == _slider.maxValue)
        {
            _blueResultPanel.SetActive(true);
        }
    }


    public void NewGame()
    {
        _slider.value = (_slider.minValue + _slider.maxValue) / 2;
        �heckStatus();
    }
}