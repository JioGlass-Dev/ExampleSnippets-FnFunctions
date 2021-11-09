using System;
using JMRSDK.InputModule;
using UnityEngine;
using UnityEngine.Events;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// calls function actions when the specific button is pressed;
    /// </summary>
    public class FnButtons : MonoBehaviour, IFn1Handler, IFn2Handler
    {
        [SerializeField] private bool showLogs = true;

        /// <summary>
        /// Unity event when Fn1 button is pressed
        /// </summary>
        public UnityEvent onFn1Action;

        /// <summary>
        /// Unity event when Fn2 button is pressed
        /// </summary>
        public UnityEvent onFn2Action;

        /// <summary>
        /// Added Global Listener in Start method.
        /// </summary>
        public void Start()
        {
            JMRInputManager.Instance.AddGlobalListener(gameObject);
        }

        /// <summary>
        /// Called on Fn1 button, when touchpad is pressed once.
        /// </summary>
        public void OnFn1Action()
        {
            if (showLogs) Debug.Log("Fn1 Action Called");

            onFn1Action.Invoke();
        }

        /// <summary>
        /// Called on Fn2 button, when touchpad is pressed twice.
        /// </summary>
        public void OnFn2Action()
        {
            if (showLogs) Debug.Log("Fn2 Action Called");

            onFn2Action.Invoke();
        }
    }
}