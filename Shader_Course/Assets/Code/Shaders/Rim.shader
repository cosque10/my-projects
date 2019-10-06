Shader "CustomShaders/Rim"
{
    Properties{
        _RimColor ("Rim Color",Color) = (0,0.5,0.5,0.0)
        _RimPower ("Rim Power", Range(0.5,8.0)) = 3.0
        _BunnyTexture ("Bunny Texture", 2D) = "white" {}
        _StripesWitdh ("Stripes Witdh", Range(0.0,10.0)) = 10
    }
    SubShader{
        CGPROGRAM
        #pragma surface surf Lambert
        struct Input{
            float3 viewDir;
            float3 worldPos;
            float2 uv_BunnyTexture;
        };

        float4 _RimColor;
        sampler2D _BunnyTexture;
        float _RimPower;
        float _StripesWitdh;

        void surf(Input IN, inout SurfaceOutput o){
            half rim = 1-saturate(dot(normalize(IN.viewDir),o.Normal));
            float3 textureBunny = tex2D(_BunnyTexture,IN.uv_BunnyTexture).rgb;
            o.Albedo = textureBunny;
            o.Emission = frac(IN.worldPos.y *_StripesWitdh *0.5)>0.4 ? float3(0,1,0)*rim: float3(1,0,0)*rim;
        }
        ENDCG
    }
    FallBack "Diffuse"
}

