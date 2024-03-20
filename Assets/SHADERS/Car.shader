Shader "Custom/Car"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        MyEmission("Emi", Color) = (1,1,1,1)
        MyRange("Range", Range(0, 1)) = 1
        _Metallic ("Metallic", Range(0,1)) = 0.0
        /*_MainTex ("Albedo (RGB)", 2D) = "white" {}
        _Glossiness ("Smoothness", Range(0,1)) = 0.5*/
    }
    SubShader
    {
        CGPROGRAM
        
        //Tags { "Queue" = "Geometry"}

        #pragma surface surf StandardSpecular

        //sampler2D _MainTex;

        struct Input
        {
            float2 uv_MainTex;
        };

        //half _Glossiness;
        half _Metallic;
        fixed4 _Color;
        fixed4 MyEmission;
        half  MyRange;

        void surf (Input IN, inout SurfaceOutputStandardSpecular o)
        {
            fixed4 c = _Color;
            o.Albedo = c.rgb * _Metallic;
            o.Emission = c.rgb * MyRange;
            o.Specular = _Metallic;
            /*o.Smoothness = _Glossiness;
            o.Alpha = c.a;*/
        }
        ENDCG
    }
    FallBack "Diffuse"
}
