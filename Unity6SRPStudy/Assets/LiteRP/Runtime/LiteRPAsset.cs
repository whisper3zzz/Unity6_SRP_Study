using UnityEngine;
using UnityEngine.Rendering;

namespace LiteRP
{
    [CreateAssetMenu(menuName = "Lite Render Pipeline/Lite Render Pipeline Asset")]
    public class LiteRP : RenderPipelineAsset<LiteRenderPipeline>
    {
        // Create a new instance of the Render Pipeline
        protected override RenderPipeline CreatePipeline()
        {
            return new LiteRenderPipeline();
        }
    }

    
}
