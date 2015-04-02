Shader "Transparency Projectors" {	

Properties {_MainTex ("Cookie", 2D) = "" {TexGen ObjectLinear}}

SubShader
{
	Tags {"Queue" = "Geometry+200"}
	
	Pass 
	{
		ColorMask A
		Blend One One
		SetTexture[_MainTex] {Matrix[_Projector]}
	}   
}


}