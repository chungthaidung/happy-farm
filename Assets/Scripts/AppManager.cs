using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class AppManager : MonoBehaviour
    {
        public static AppManager Instance;
        private AppStateMachine _stateMachine;
        public AppStateMachine StateMachine {
            get {return _stateMachine;}
        }
        void Awake() {
            Instance = this;
            DontDestroyOnLoad(this);
            _stateMachine = new AppStateMachine();    
        }
        // Start is called before the first frame update
        void Start()
        {
            SetupApp();
        }
        public void SetupApp()
        {
            Switch(new AppStateInitial());
        }
        public void Switch(IState newState)
        {
            StartCoroutine(_stateMachine.SwitchProcess(newState));
        }

        // public void SaveData(string key, )
    }
}
