Shader "CustomShaders/DiffusionEmission" 
{
    Properties
    {
        _myDiffuse("Example Diffuse",2D) = "white" {}
        _myEmission("Example Emission",2D) = "white"{}
    }

    SubShader{
        CGPROGRAM
        #pragma surface surf Lambert

        struct Input{
            float2 uv_myDiffuse;
        };

        sampler2D _myDiffuse;
        sampler2D _myEmission;

        void surf (Input IN, inout SurfaceOutput o )
        {
            o.Albedo = tex2D(_myDiffuse,IN.uv_myDiffuse).rgb;
            o.Emission = tex2D(_myEmission,IN.uv_myDiffuse).rgb;
        }
        ENDCG
    }
    FallBack "Diffuse"
}