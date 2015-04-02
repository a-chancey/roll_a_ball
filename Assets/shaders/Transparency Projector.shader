Shader "Transparency Projector" {	

Properties {_MainTex ("Cookie", 2D) = "" {TexGen ObjectLinear}}

SubShader
{
	Tags {"Queue" = "Geometry+10"}
	Pass
	{
		ColorMask A   		
		SetTexture[_MainTex] {Matrix[_Projector]}
	}   
}


}