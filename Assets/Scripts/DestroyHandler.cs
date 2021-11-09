using UnityEngine;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// Handles lifetime of gameobject.
    /// </summary>
    public class DestroyHandler : MonoBehaviour
    {
        /// <summary>
        /// lifetime of the particle after which gameobject will be destroyed.
        /// </summary>
        public float lifeTime = 4f;

        /// <summary>
        /// destroy gameobject after duration in event of collision.
        /// </summary>
        public float destroyAfterCollideTime = 0.3f;

        private void Start()
        {
            Destroy(this.gameObject, lifeTime);
        }

        private void OnCollisionEnter(Collision other)
        {
            Destroy(this.gameObject, destroyAfterCollideTime);
        }
    }
}