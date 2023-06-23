using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

namespace utils
{
    public sealed class Utils
    {
        private static readonly Utils instance = new Utils();

        static Utils() { }

        private Utils() { }

        public static Utils Instance
        {
            get { return instance; }
        }

        public async UniTask<Sprite> LoadSpriteFromFile(string filePath)
        {
            var result = await Resources
                .LoadAsync<Sprite>(filePath)
                .ToUniTask(Progress.Create<float>(x => Debug.Log("Load image: " + x)));
            return (result as Sprite);
        }
    }
}
