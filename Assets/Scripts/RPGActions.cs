using JMRSDK.InputModule;
using UnityEngine;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// Actions like Grenade Throw.
    /// </summary>
    public class RPGActions : MonoBehaviour
    {
        /// <summary>
        /// force with which object will be thrown.
        /// </summary>
        public float throwForce;

        private JMRPointerManager _jmrPointerManager;
        private void Start() => _jmrPointerManager = FindObjectOfType<JMRPointerManager>();
        
        /// <summary>
        /// Instantiate and throw ball prefab from laser pointer origin in the direction of the laser pointer. 
        /// </summary>
        /// <param name="ballToThrow">Gameobject Prefab to throw</param>
        /// <remarks>
        /// Needs to be accessed through UnityEvents.
        /// </remarks>
        public void ThrowBall(GameObject ballToThrow)
        {
            var ray = _jmrPointerManager.GetCurrentRay();
            GameObject ball = Instantiate(ballToThrow, ray.origin, ballToThrow.transform.rotation);
            ball.GetComponent<Rigidbody>()?.AddForce(ray.direction * throwForce, ForceMode.Impulse);
        }
    }
}