using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public GameObject gameObject = null;
    private Toggle toggle = null;

    void Start()
    {
        toggle = GetComponent<Toggle>();
    }

    void Update()
    {
        if (!toggle.isOn)
        {
            gameObject.GetComponent<AudioSource>().Pause();
        }
        if (toggle.isOn)
        {
            gameObject.GetComponent<AudioSource>().UnPause();
        }
    }
}
