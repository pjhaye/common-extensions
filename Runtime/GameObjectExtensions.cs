using UnityEngine;

namespace CommonExtensions
{
    public static class GameObjectExtensions
    {
        public static void SetLayerRecursively(this GameObject gameObject, int layerMask)
        {
            var transforms = gameObject.GetComponentsInChildren<Transform>();
            foreach (var transform in transforms)
            {
                transform.gameObject.layer = layerMask;
            }
        }
    }
}
