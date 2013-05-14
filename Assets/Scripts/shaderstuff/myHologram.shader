Shader "Hologram" {
Properties{
	_Color ("Color Tint", Color) = (0.1, 0.04, 0.02, 1)
	_Color2("Effect Color", Color) = (0.1, 0.04, 0.02, 1)
	_Rate ("Rate", Range (1, 1000)) = 500
}
SubShader 
{
		ZWrite Off ZTest Always Cull Off Blend One One
	Pass
	{
		CGPROGRAM
		#pragma vertex vert
		#pragma fragment frag
		#pragma fragmentoption ARB_fog_exp2
		#include "UnityCG.cginc"

		float4 _Color;
		float4 _Color2;
		float _Rate;

	struct v2f 
		{
			float4 pos : SV_POSITION;
			float4 texcoord : TEXCOORD0;
		};

	v2f vert (appdata_base v)
	{
		v2f o;
		o.pos = mul (UNITY_MATRIX_MVP, v.vertex);
		o.texcoord = v.texcoord;
		return o;
	}

	half4 frag (v2f i) : COLOR
	{
		float3 color;
		float m;
		m = _Time[0]*_Rate + ((i.texcoord[0]+i.texcoord[1])*_Color2.a*_Color2.a);
		m = tan(m)/2;
		color = float3(m*_Color2.r, m*_Color2.g, m*_Color2.b);
		return half4( color, 1 );
	}
ENDCG 
    }
	Pass
	{
		Fog { Mode Off }
		ZWrite Off ZTest Always Cull Off Blend One One
		Color[_Color]
	}
}
}
