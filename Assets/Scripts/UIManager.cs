using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public static int IntScore;
    public Text scoreText;
    public Text LooseText;
    public static bool OnAudio;
    public static int CubeLoose;

    void Start()
    {
        Screen.SetResolution(540, 960, false);
    }
    void Update()
    {
        IntScore = TargetDestroy.score;
        scoreText.text = (IntScore * 10).ToString();
        OnAudio = TargetDestroy.AudioOn;
        if (OnAudio)
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            OnAudio = false;
            TargetDestroy.AudioOn = OnAudio;
        }
        CubeLoose = TargetDestroy.LooseCube;
        LooseText.text = ("Remain"+CubeLoose).ToString();

    }
}
