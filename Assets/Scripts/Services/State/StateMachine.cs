using System;
using System.Collections.Generic;

namespace PlayableAd.Services.State
{
    public class StateMachine
    {
        private readonly Dictionary<Type, IState> _states = new Dictionary<Type, IState>();
        private IState _currentState;

        public void RegisterState(IState state) 
            => _states.TryAdd(state.GetType(), state);

        public void Enter<TState>() where TState : IState
        {
            var state = _states[typeof(TState)];
            Enter(state);
        }
        
        public void Enter(IState state)
        {
            if (state is IExitableState exitableState)
                exitableState.Exit();
            _currentState = state;
            _currentState.Enter();
        }
    }
}