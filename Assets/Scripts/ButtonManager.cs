using System.Threading;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Toggle[] toggles = new Toggle[9];
    public GameObject panel;
    public GameObject panel2;


    private IEnumerator EndGame(float value)
    {
        yield return new WaitForSeconds(value);
        panel.SetActive(false);
        panel2.SetActive(true);
    }

    public void GameAgan()
    {
        panel2.SetActive(false);
        panel.SetActive(true);
        foreach (var item in toggles)
            item.isOn = false;
    }

    private void Update()
    {
        if (toggles[0].isOn && toggles[1].isOn && toggles[2].isOn && toggles[3].isOn && toggles[4].isOn && toggles[5].isOn && toggles[6].isOn && toggles[7].isOn && toggles[8].isOn)
        {
            StartCoroutine(EndGame(1f));
        }
    }
    public void Button1()
    {
        foreach (var item in toggles)
        {
            if (item.name == "2" || item.name == "4")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button2()
    {
        foreach (var item in toggles)
        {
            if (item.name == "1" || item.name == "3" || item.name == "5")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button3()
    {
        foreach (var item in toggles)
        {
            if (item.name == "2" || item.name == "6")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button4()
    {
        foreach (var item in toggles)
        {
            if (item.name == "1" || item.name == "5" || item.name == "7")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button5()
    {
        foreach (var item in toggles)
        {
            if (item.name == "2" || item.name == "4" || item.name == "6" || item.name == "8")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button6()
    {
        foreach (var item in toggles)
        {
            if (item.name == "3" || item.name == "5" || item.name == "9")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button7()
    {
        foreach (var item in toggles)
        {
            if (item.name == "4" || item.name == "8")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button8()
    {
        foreach (var item in toggles)
        {
            if (item.name == "5" || item.name == "7" || item.name == "9")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }

    public void Button9()
    {
        foreach (var item in toggles)
        {
            if (item.name == "8" || item.name == "6")
            {
                if (item.isOn)
                {
                    item.isOn = false;
                }
                else item.isOn = true;
            }
        }
    }
}
