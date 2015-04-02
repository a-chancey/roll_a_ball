Shader "Transparent via Projector" {
	
SubShader
{
	Tags {"Queue" = "Geometry+300"}	
	Pass 
	{
		// The alpha is supplied by the projector.
		Blend OneMinusDstAlpha DstAlpha
		
		Color (.6,0,.7)
	}
}


}