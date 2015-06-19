﻿using System;
using ClassicalSharp.GraphicsAPI;

namespace ClassicalSharp {
	
	public struct Texture {
		public int ID;
		public int X1, Y1;
		public int Width, Height;
		public float U1, V1;
		// Normally just used for graphics cards that don't support non power of two textures.
		public float U2, V2;

		public Texture( int id, int x, int y, int width, int height, float u2, float v2 )
			: this( id, x, y, width, height, 0, u2, 0, v2 )	{
		}
		
		public Texture( int id, int x, int y, int width, int height, TextureRectangle rec )
			: this( id, x, y, width, height, rec.U1, rec.U2, rec.V1, rec.V2 )	{
		}
		
		public Texture( int id, int x, int y, int width, int height, float u1, float u2, float v1, float v2 ) {
			ID = id;
			X1 = x;
			Y1 = y;
			Width = width;
			Height = height;
			U1 = u1;
			V1 = v1;
			U2 = u2;
			V2 = v2;
		}
		
		public bool IsValid {
			get { return ID > 0; }
		}
		
		public void Render( OpenGLApi graphics ) {
			graphics.Texturing = true;
			graphics.Bind2DTexture( ID );
			graphics.Draw2DTexture( ref this );
			graphics.Texturing = false;
		}
		
		public void RenderNoBind( OpenGLApi graphics ) {
			graphics.Draw2DTexture( ref this );
		}
		
		public int X2 {
			get { return X1 + Width; }
			//set { X1 = value - Width; }
		}
		
		public int Y2 {
			get { return Y1 + Height; }
			//set { Y1 = value - Height; }
		}
		
		public override string ToString() {
			return ID + String.Format( "({0}, {1} -> {2},{3}", X1, Y1, Width, Height );
		}
	}
}