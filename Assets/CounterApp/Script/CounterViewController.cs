using System;
using FrameworkDesign;
using UnityEngine;
using UnityEngine.UI;

namespace CounterApp
{
    public class CounterViewController : MonoBehaviour
    {
        private void Start()
        {
            CountModel.Instance.Count.OnValueChange += OnValueChanged;
            
            transform.Find("BtnAdd").GetComponent<Button>()
                .onClick.AddListener((() => { new AddCountCommand().Execute(); }));
            transform.Find("BtnSub").GetComponent<Button>()
                .onClick.AddListener((() => { new SubCountCommand().Execute();}));
        }

        private void OnValueChanged(int newCount)
        {
            transform.Find("CountText").GetComponent<Text>().text = newCount.ToString();
        }
    }

    public  class CountModel : Singleton<CountModel>
    {
        private  CountModel(){}
        public  BindableProperty<int> Count = new BindableProperty<int>()
        {
            Value = 0
        };
    }
}