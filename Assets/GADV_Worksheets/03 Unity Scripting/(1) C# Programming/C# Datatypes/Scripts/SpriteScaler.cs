using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0";

        void Start()
        {
            spriteTransform = GetComponent<Transform>();

            float parsedScale = float.Parse(scale);
            spriteTransform.localScale = new Vector3(parsedScale, parsedScale, 1f);
        }
    }
}
