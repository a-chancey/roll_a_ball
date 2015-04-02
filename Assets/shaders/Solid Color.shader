Shader "Solid Color" {

Properties {_Color ("Color", Color) = (1,1,1)}

SubShader
{
	Pass {Color [_Color]}   
}

}