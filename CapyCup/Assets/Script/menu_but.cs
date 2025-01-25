using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menu_but : MonoBehaviour
{
    [SerializeField] private GameObject _chosePanel;

    public void Open_ChoseMenu() {
        _chosePanel.SetActive(true);
    }
    public void Close_ChoseMenu() {
        _chosePanel.SetActive(false);
    }
}
