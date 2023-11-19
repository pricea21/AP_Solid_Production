using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class AnimationSelector : MonoBehaviour, ISelectionResponse
{
    public GameObject pickMeText;
    public GameObject whinyText;

    public void OnDeselect(Transform selection)
    {
        pickMeText.SetActive(false);
        whinyText.SetActive(true);
        Invoke("TurnWhinyOff", 1.0f);
    }
    public void OnSelect(Transform selection)
    {
        pickMeText.SetActive(true);
        whinyText.SetActive(false);
    }

    public void TurnWhinyOff()
    {
        whinyText.SetActive(false);
    }
}
