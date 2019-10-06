Shader "CustomShaders/BumpMapping" 
{
    Properties
    {
        _myDiffuse("Example Colour",2D) = "white"{}
        _myBumpMap("Bump texture",2D) = "bump" {}
        _mySlider("Bump Intensity",Range(0,10)) = 1
        _myScaleSlider("Scale Textures",Range(0,2)) = 1
    }

    SubShader{
        CGPROGRAM
        #pragma surface surf Lambert

        struct Input{
            float2 uv_myDiffuse;
            float2 uv_myBumpMap;
        };

        sampler2D _myDiffuse;
        sampler2D _myBumpMap;
        half _mySlider;
        half _myScaleSlider;

        void surf (Input IN, inout SurfaceOutput o )
        {
            IN.uv_myBumpMap *= _myScaleSlider;
            IN.uv_myDiffuse *= _myScaleSlider;
            o.Albedo = tex2D(_myDiffuse, IN.uv_myDiffuse).rgb;
            o.Normal = UnpackNormal(tex2D(_myBumpMap,IN.uv_myBumpMap));
            o.Normal *= float3(_mySlider,_mySlider,1);
        }
        ENDCG
    }
    FallBack "Diffuse"
}