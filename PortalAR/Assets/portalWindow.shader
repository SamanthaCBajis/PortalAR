Shader "Portal/portalWindow" //inside new folder called Portal
{
	
	SubShader
    {
        Zwrite off //dont want to write to zbot
        Colormask 0 //want portal window to be clear
        cull off //render transparent skybox
        
        Stencil{ //pixel mask that saves discarding pixels
        Ref 1
        Pass replace
        }
    
		Pass
		{
			
		}
	}
}
