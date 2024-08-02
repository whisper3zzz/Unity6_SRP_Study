using System;
using UnityEngine;
using UnityEngine.Rendering;

public class SetUpLiteRP : MonoBehaviour
{
   public RenderPipelineAsset currentRenderPipeline;
   void OnEnable()
   {
      GraphicsSettings.defaultRenderPipeline
         = currentRenderPipeline;
   }

   private void OnValidate()
   {
      GraphicsSettings.defaultRenderPipeline
         = currentRenderPipeline;
   }
}
