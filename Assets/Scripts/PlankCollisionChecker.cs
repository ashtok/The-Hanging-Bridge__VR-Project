using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HangingBridge
{
    public class PlankCollisionChecker : MonoBehaviour
    {
        public bool isColidingWithPlayer = false;

        /// <summary>
        /// Checks collision with player and sets isCollidingWithPlayer accordingly
        /// </summary>
        /// <param name="other"></param>
        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isColidingWithPlayer = true;
                Debug.Log($"Is colliding with Player {isColidingWithPlayer}");
            }
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isColidingWithPlayer = false;
                Debug.Log($"Is colliding with Player {isColidingWithPlayer}");
            }
        }

        /// <summary>
        /// Returns isCoollidingWithPlayer value
        /// </summary>
        /// <returns></returns>
        public bool isColliding()
        {
            return isColidingWithPlayer;
        }
    }
}