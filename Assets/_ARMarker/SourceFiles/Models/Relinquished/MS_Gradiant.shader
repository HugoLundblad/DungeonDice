Shader "Unlit/MS_Gradiant"
{
    Properties
    {
        _TopColor("Top Gradiant Color",Color) = (1,1,1,1)
        _BotColor("Bottom Gradiant Color",Color) = (0,0,0,1)
    }
    SubShader
    {
        Tags {
            "RenderType" = "Transparent"
            "Queue" = "Transparent"
            "RenderFace" = "Both"
        }
        LOD 100

        Pass
        {
            blend SrcAlpha OneMinusSrcAlpha
            ZWrite off
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            
            
            
            #include "UnityCG.cginc"

            struct  appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 color: TEXCOORD0;
                float4 vertex : SV_POSITION;
            };
            
            fixed4 _TopColor;
            fixed4 _BotColor;
            
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                
                o.color = lerp(_BotColor, _TopColor, v.uv.y);
                return o;
            }
            
            fixed4 frag (v2f i) : SV_Target
            {
                
                return i.color;
                
                
                
            }
            ENDCG
        }
    }
}
