Shader "Custom/Grass"
{
    Properties
    {
        //_MyTex("Texture", 2D) = "white" {}
        _MyColor("Color", Color) = (1,1,1,1)
        _MyEmission("Emission", Color) = (1,1,1,1)
        _MyRange("Fuerza de Emission", Range(0.0, 10.0)) = 1.0
    }
    SubShader
    {
        Tags
        {
            "RenderType" = "Opaque"
        }

        CGPROGRAM
        #pragma surface surf Standard fullforwardshadows

        //sampler2D _MyTex;
        fixed4 _MyColor;
        fixed4 _MyEmission;
        float _MyRange;

        struct Input
        {
            float2 uv_MainTex;
        };

        void surf(Input IN, inout SurfaceOutputStandard o)
        {
            //fixed4 c = tex2D(_MyTex, IN.uv_MainTex) * _MyColor;
            o.Albedo = _MyColor.rgb;
            o.Emission = _MyEmission.rgb * _MyColor * _MyRange;
            //o.Alpha = _MyColor.a;
        }
        ENDCG
    }
        FallBack "Diffuse"
}
