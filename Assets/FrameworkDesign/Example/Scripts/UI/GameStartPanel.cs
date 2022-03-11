﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    public class GameStartPanel : MonoBehaviour
    {

        private void Start()
        {
            transform.Find("BtnGameStart").GetComponent<Button>().onClick.AddListener((() =>
            {
                gameObject.SetActive(false);
                GameStartEvent.Trigger();
            }));
        }
    }
}