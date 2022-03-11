using System;
using UnityEngine;

namespace FrameworkDesign.Example
{
    public class Game : MonoBehaviour
    {
        private void Awake()
        {
            GameStartEvent.Register(OnGameStart);
            GameModel.KillCount.OnValueChange += OnEnemyKilled;
        }

        private void OnEnemyKilled(int killCount)
        {
            if (killCount == 4)
            {
                GamePassEvent.Trigger();
            }
        }

        private void OnDestroy()
        {
            GameStartEvent.Unregister(OnGameStart);
            
        }

        private void OnGameStart()
        {
            transform.Find("Enemies").gameObject.SetActive(true);
        }
    }
}