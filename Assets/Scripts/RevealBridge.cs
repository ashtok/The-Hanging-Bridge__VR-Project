using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HangingBridge
{
    public class RevealBridge : MonoBehaviour
    {
        [SerializeField]
        private BridgeHandler brigeHandler;

        /// <summary>
        /// Reveals all the planks color based on their safety. Green - Safe; Red - Unsafe;
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Trigger is Triggered");
            if (other.gameObject.CompareTag("Player"))
            {
                brigeHandler.ShowColorCoding();
                Debug.Log("Trigger is Triggered by Player");
            }

        }

        /// <summary>
        /// Hides Color of planks when out o trigger bounds
        /// </summary>
        /// <param name="other"></param>
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                brigeHandler.HideColorCoding();
            }
        }
    }
}