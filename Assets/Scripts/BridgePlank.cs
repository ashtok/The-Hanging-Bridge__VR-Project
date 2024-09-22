using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace HangingBridge
{
    [System.Serializable]
    public class BridgePlank
    {
        public bool isSafe = true;
        public GameObject tileRef;

        private Color safeColor = Color.green;
        private Color dangerColor = Color.red;
        private Color originalColor;

        /// <summary>
        /// Sets safety of the plank
        /// </summary>
        /// <param name="value"></param>
        public void SetSafety(bool value)
        {
            isSafe = value;
        }

        /// <summary>
        /// Sets the original color of the plank
        /// </summary>
        /// <param name="oColor"></param>
        internal void SetOriginalColor(Color oColor)
        {
            if (tileRef != null)
            {
                originalColor = oColor;
            }
            else
            {
                Debug.LogError("tileRef is not assigned");
            }
        }

        /// <summary>
        /// Returns Safe Color
        /// </summary>
        /// <returns></returns>
        public Color GetSafeColor()
        {
            return safeColor;
        }

        /// <summary>
        /// Returns Danger Color
        /// </summary>
        /// <returns></returns>
        public Color GetDangerColor()
        {
            return dangerColor;
        }

        /// <summary>
        /// Returns the stored original color
        /// </summary>
        /// <returns></returns>
        public Color GetOriginalColor()
        {
            return originalColor;
        }

    }
}
