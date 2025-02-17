using MelonLoader;
using System.Linq.Expressions;
using UnityEngine;

[assembly: MelonInfo(typeof(MuteOnUnfocus.Core), "MuteOnUnfocus", "1.0.0", "fabbeyond", null)]
[assembly: MelonGame("TraipseWare", "Peaks of Yore")]

namespace MuteOnUnfocus
{
    public class Core : MelonMod
    {
        AudioSource[] audioListeners;
        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            audioListeners = GameObject.FindObjectsOfType<AudioSource>();

            base.OnSceneWasInitialized(buildIndex, sceneName);
        }

        public override void OnUpdate()
        {
            try
            {
                if (Application.isFocused)
                {
                    foreach (AudioSource audioListener in audioListeners)
                    {
                        audioListener.GetComponent<AudioSource>().mute = false;
                    }
                }
                else
                {
                    foreach (AudioSource audioListener in audioListeners)
                    {
                        audioListener.GetComponent<AudioSource>().mute = true;
                    }
                }
            }
            catch (Exception e)
            {

            }

            base.OnUpdate();
        }
    }
}