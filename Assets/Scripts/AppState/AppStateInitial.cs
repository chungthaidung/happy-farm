using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class AppStateInitial : IState
    {
        public bool IsInitialized => _isInitialized;
        private bool _isInitialized;
        public void Initialize()
        {
            _isInitialized = true;
            Debug.Log("AppStateInitial");

            AppManager.Instance.Switch(new AppStateGameplay());
            // AppManager.Instance.Switch(new AppStateMainMenu());
        }

        public void Exit()
        { }
        public void Resume()
        { }
        public void Clear()
        { }
    }

}
