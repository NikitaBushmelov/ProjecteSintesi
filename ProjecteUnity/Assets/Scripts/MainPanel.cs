using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainPanel : MonoBehaviour
{
    [Header("Options")]
    public Slider volumeFX;
    public Slider volumeMaster;
    public Toggle mute;
    public AudioMixer mixer;
    public AudioSource fxSource;
    public AudioClip clickSound;
    private float lastVolume;
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject optionsPanel;
    public GameObject instructionsPanel;
    public GameObject instructionsPanel2;
    public GameObject instructionsPanel3;
    public GameObject instructionsPanel4;


    private void Awake()
    {
        volumeFX.onValueChanged.AddListener(ChangeVolumeFX);
        volumeMaster.onValueChanged.AddListener(ChangeVolumeMaster);
    }

    public void PlayLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
    public void SetMute()
    {
        if (mute.isOn)
        {
            mixer.GetFloat("VolMaster", out lastVolume);
            mixer.SetFloat("VolMaster", -80);
        }
       else
            mixer.SetFloat("VolMaster", lastVolume);
    }

    public void OpenPanel( GameObject panel)
    {
        mainPanel.SetActive(false);
        optionsPanel.SetActive(false);
        panel.SetActive(true);
        PlaySoundButton();
    }
    public void OpenInstruction1(GameObject instructionsPanel) {
        mainPanel.SetActive(false);
        instructionsPanel.SetActive(true);
        PlaySoundButton();
    }
    public void OpenInstruction2(GameObject instructionsPanel2)
    {
        instructionsPanel.SetActive(false);
        instructionsPanel2.SetActive(true);
        PlaySoundButton();
    }
    public void OpenInstruction3(GameObject instructionsPanel3)
    {
        instructionsPanel2.SetActive(false);
        instructionsPanel3.SetActive(true);
        PlaySoundButton();
    }
    public void OpenInstruction4(GameObject instructionsPanel4)
    {
        instructionsPanel3.SetActive(false);
        instructionsPanel4.SetActive(true);
        PlaySoundButton();
    }
    public void OpenInstruction5(GameObject mainPanel)
    {
        instructionsPanel4.SetActive(false);
        mainPanel.SetActive(true);
        PlaySoundButton();
    }

    public void ChangeVolumeMaster(float v)
    {
        mixer.SetFloat("VolMaster", v);
    }
    public void ChangeVolumeFX(float v)
    {
        mixer.SetFloat("VolFX", v);
    }
    public void PlaySoundButton()
    {
        fxSource.PlayOneShot(clickSound);
    }
}
