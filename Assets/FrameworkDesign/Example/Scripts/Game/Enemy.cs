using System;
using UnityEngine;
using UnityEngine.UI;

namespace FrameworkDesign.Example
{
    public class Enemy : MonoBehaviour
    {
        private void OnMouseDown()
        {
            Destroy(gameObject);
            new KillEnemyCommand().Execute();
        }
    }
}