using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    [SerializeField] private TextMesh text;
    [SerializeField] private ParticleSystem sparksParticles;
    
    [SerializeField] private float textSwitchInterval = 1.5f;
    [SerializeField] private float rotatingSpeed = 1.0f;

    private List<string> textToDisplay = new List<string>();
    private float timeToNextText;
    private int currentTextIndex;

    private void Start()
    {
        InitializeTexts();
        DisplayCurrentText();
        PlayParticles();
    }

    private void Update()
    {
        UpdateTextDisplay();
    }

    private void InitializeTexts()
    {
        textToDisplay.Add("Congratulations");
        textToDisplay.Add("All Errors Fixed");
        
        timeToNextText = 0f;
        currentTextIndex = 0;
    }

    private void UpdateTextDisplay()
    {
        timeToNextText += Time.deltaTime;

        if (timeToNextText >= textSwitchInterval)
        {
            timeToNextText = 0f;
            SwitchToNextText();
        }
    }

    private void SwitchToNextText()
    {
        currentTextIndex = (currentTextIndex + 1) % textToDisplay.Count;
        DisplayCurrentText();
    }

    private void DisplayCurrentText()
    {
        if (text != null && textToDisplay.Count > 0)
        {
            text.text = textToDisplay[currentTextIndex];
        }
    }

    private void PlayParticles()
    {
        if (sparksParticles != null)
        {
            sparksParticles.Play();
        }
    }
}