using ComputeSharp.D2D1;

namespace ComputeSharp.SwapChain.Shaders.D2D1;

/// <summary>
/// A shader creating an abstract and colorful animation.
/// Ported from <see href="https://www.shadertoy.com/view/WtjyzR"/>.
/// <para>Created by Benoit Marini.</para>
/// <para>License Creative Commons Attribution-NonCommercial-ShareAlike 3.0 Unported License.</para>
/// </summary>
[D2DInputCount(0)]
[D2DRequiresScenePosition]
[D2DShaderProfile(D2D1ShaderProfile.PixelShader50)]
[D2DGeneratedShaderMarshaller]
[AutoConstructor]
internal readonly partial struct ColorfulInfinity : ID2D1PixelShader
{
    /// <summary>
    /// The current time since the start of the application.
    /// </summary>
    private readonly float time;

    /// <summary>
    /// The dispatch size for the current output.
    /// </summary>
    private readonly int2 dispatchSize;

    /// <summary>
    /// The total number of layers for the final animation.
    /// </summary>
    private const float NumberOfLayers = 16.0f;

    /// <summary>
    /// The number of iterations to calculate a texel value.
    /// </summary>
    private const int NumberOfIterations = 23;

    /// <summary>
    /// Makes some magic happen.
    /// </summary>
    private float4 Tex(float3 p)
    {
        float t = this.time + 78.0f;
        float4 o = new(p.X, p.Y, p.Z, 3.0f * Hlsl.Sin(t * 0.1f));
        float4 dec =
            new float4(1.0f, 0.9f, 0.1f, 0.15f) +
            new float4(0.06f * Hlsl.Cos(t * 0.1f), 0, 0, 0.14f * Hlsl.Cos(t * 0.23f));

        for (int i = 0; i++ < NumberOfIterations;)
        {
            o.XZYW = Hlsl.Abs((o / Hlsl.Dot(o, o)) - dec);
        }

        return o;
    }

    /// <inheritdoc/>
    public float4 Execute()
    {
        int2 xy = (int2)D2D.GetScenePosition().XY;
        float2 uv = (xy - ((float2)this.dispatchSize * 0.5f)) / this.dispatchSize.Y;
        float3 col = 0;
        float t = this.time * 0.3f;

        for (float i = 0.0f; i <= 1.0f; i += 1.0f / NumberOfLayers)
        {
            float d = Hlsl.Frac(i + t);
            float s = Hlsl.Lerp(5.0f, 0.5f, d);
            float f = d * Hlsl.SmoothStep(1.0f, 0.9f, d);

            col += Tex(new float3(uv.X * s, uv.Y * s, i * 4.0f)).XYZ * f;
        }

        col /= NumberOfLayers;
        col *= new float3(2, 1.0f, 2.0f);
        col = Hlsl.Pow(col, 0.5f);

        return new(col.X, col.Y, col.Z, 1.0f);
    }
}