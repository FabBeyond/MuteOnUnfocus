using MelonLoader;
using System.Linq.Expressions;
using UnityEngine;

[assembly: MelonInfo(typeof(MuteOnUnfocus.Core), "MuteOnUnfocus", "1.0.0", "fabbeyond", null)]
[assembly: MelonGame("TraipseWare", "Peaks of Yore")]

namespace MuteOnUnfocus
{
    public class Core : MelonMod
    {
        public override void OnUpdate()
        {
            AudioSource[] audioListeners = GameObject.FindObjectsOfType<AudioSource>();

            try
            {
                if (Application.isFocused)
                {
                    foreach (AudioSource audioListener in audioListeners)
                    {
                        if (audioListener)
                        {
                            audioListener.GetComponent<AudioSource>().mute = false;
                        }
                    }
                }
                else
                {
                    foreach (AudioSource audioListener in audioListeners)
                    {
                        if (audioListener)
                        {
                            audioListener.GetComponent<AudioSource>().mute = true;
                        }
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