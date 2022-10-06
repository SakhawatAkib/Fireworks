using UnityEngine;
using UnityEngine.VFX;

class SoundControl : VFXSpawnerCallbacks
{
    public AudioSource rocket;
    public AudioSource explosion;
    public class InputProperties
    {
        [Min(0), Tooltip("Sets the number of particles to spawn per second.")]
        public float Rate = 10;
    }

    static private readonly int rateID = Shader.PropertyToID("Rate");

    public sealed override void OnPlay(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
    {
        
    }

    public sealed override void OnUpdate(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
    {
        // if (state.playing)
        // {
        //     float currentRate = vfxValues.GetFloat(rateID);
        //     state.spawnCount += currentRate * state.deltaTime;
        // }
    }

    public sealed override void OnStop(VFXSpawnerState state, VFXExpressionValues vfxValues, VisualEffect vfxComponent)
    {
    }
}
