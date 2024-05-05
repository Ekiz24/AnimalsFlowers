using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseSetting : MonoBehaviour
{
    public GameObject Close;


    public void CloseSettingButton()
    {
        Close.SetActive(false);
    }

}
