using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HappyFarm
{
    public class AppStateMachine
    {
        private IState _currentState;
        public IState CurrentState
        {
            get { return _currentState; }
        }

        public IEnumerator SwitchProcess(IState newState)
        {
            IState previousState = _currentState;
            _currentState = newState;

            if (_currentState.IsInitialized)
            {
                _currentState.Resume();
            }
            else
            {
                previousState?.Exit();
                _currentState.Initialize();
                while (!_currentState.IsInitialized)
                    yield return null;
                previousState?.Clear();
            }
        }
    }
}

