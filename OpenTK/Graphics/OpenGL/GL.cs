#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

namespace OpenTK.Graphics.OpenGL {
	using System;
	using System.Text;
	using System.Runtime.InteropServices;
	#pragma warning disable 3019
	#pragma warning disable 1591
	#pragma warning disable 1572
	#pragma warning disable 1573

	partial class GL {
		
		[AutoGenerated(Category = "Version13", Version = "1.3", EntryPoint = "glActiveTexture")]
		public static void ActiveTexture(TextureUnit texture) {
			Delegates.glActiveTexture(texture);
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glAlphaFunc")]
		public static void AlphaFunc(AlphaFunction func, Single @ref) {
			Delegates.glAlphaFunc(func, @ref);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glAttachShader")]
		public static void AttachShader(Int32 program, Int32 shader) {
			Delegates.glAttachShader((UInt32)program, (UInt32)shader);
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glBindBuffer")]
		public static void BindBuffer(BufferTarget target, Int32 buffer) {
			Delegates.glBindBuffer(target, (UInt32)buffer);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glBindTexture")]
		public static void BindTexture(TextureTarget target, Int32 texture) {
			Delegates.glBindTexture(target, (UInt32)texture);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glBlendFunc")]
		public static void BlendFunc(BlendingFactor sfactor,BlendingFactor dfactor) {
			Delegates.glBlendFunc(sfactor, dfactor);
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glBufferData")]
		public static void BufferData(BufferTarget target, IntPtr size, IntPtr data, BufferUsageHint usage) {
			Delegates.glBufferData(target, size, data, usage);
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glBufferData")]
		public static void BufferData<T2>(BufferTarget target, IntPtr size, [InAttribute, OutAttribute] T2[] data, BufferUsageHint usage)
			where T2 : struct {
			GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				Delegates.glBufferData(target, size, data_ptr.AddrOfPinnedObject(), usage);
			}
			finally {
				data_ptr.Free();
			}
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glBufferSubData")]
		public static void BufferSubData(BufferTarget target, IntPtr offset, IntPtr size, IntPtr data) {
			Delegates.glBufferSubData(target, offset, size, data);
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glBufferSubData")]
		public static void BufferSubData<T3>(BufferTarget target, IntPtr offset, IntPtr size, [InAttribute, OutAttribute] T3[] data)
			where T3 : struct {
			GCHandle data_ptr = GCHandle.Alloc(data, GCHandleType.Pinned);
			try {
				Delegates.glBufferSubData(target, offset, size, data_ptr.AddrOfPinnedObject());
			}
			finally {
				data_ptr.Free();
			}
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glClear")]
		public static void Clear(ClearBufferMask mask) {
			Delegates.glClear(mask);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glClearColor")]
		public static void ClearColor(Single red, Single green, Single blue, Single alpha) {
			Delegates.glClearColor(red, green, blue, alpha);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glClearDepth")]
		public static void ClearDepth(Double depth) {
			Delegates.glClearDepth(depth);
		}
		
		[AutoGenerated(Category = "Version13Deprecated", Version = "1.3", EntryPoint = "glClientActiveTexture")]
		public static void ClientActiveTexture(OpenTK.Graphics.OpenGL.TextureUnit texture) {
			Delegates.glClientActiveTexture((OpenTK.Graphics.OpenGL.TextureUnit)texture);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glColorMask")]
		public static void ColorMask(bool red, bool green, bool blue, bool alpha) {
			Delegates.glColorMask(red, green, blue, alpha);
		}
		
		[AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glColorPointer")]
		public static void ColorPointer(Int32 size, ColorPointerType type, Int32 stride, IntPtr pointer) {
			Delegates.glColorPointer(size, type, stride, pointer);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glCompileShader")]
		public static void CompileShader(Int32 shader) {
			Delegates.glCompileShader((UInt32)shader);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glCreateProgram")]
		public static Int32 CreateProgram() {
			return Delegates.glCreateProgram();
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glCreateShader")]
		public static Int32 CreateShader(ShaderType type) {
			return Delegates.glCreateShader(type);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glCullFace")]
		public static void CullFace(CullFaceMode mode) {
			Delegates.glCullFace(mode);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glDeleteBuffers")]
		public static unsafe void DeleteBuffers(Int32 n, Int32* buffers) {
			Delegates.glDeleteBuffers(n, (UInt32*)buffers);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glDeleteProgram")]
		public static void DeleteProgram(Int32 program) {
			Delegates.glDeleteProgram((UInt32)program);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glDeleteShader")]
		public static void DeleteShader(Int32 shader) {
			Delegates.glDeleteShader((UInt32)shader);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glDeleteTextures")]
		public static unsafe void DeleteTextures(Int32 n, Int32* textures) {
			Delegates.glDeleteTextures(n, (UInt32*)textures);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glDepthFunc")]
		public static void DepthFunc(DepthFunction func) {
			Delegates.glDepthFunc(func);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glDepthMask")]
		public static void DepthMask(bool flag) {
			Delegates.glDepthMask(flag);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glDepthRange")]
		public static void DepthRange(Double near, Double far) {
			Delegates.glDepthRange(near, far);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glDetachShader")]
		public static void DetachShader(Int32 program, Int32 shader) {
			Delegates.glDetachShader((UInt32)program, (UInt32)shader);
		}

		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glDisable")]
		public static void Disable(EnableCap cap) {
			Delegates.glDisable(cap);
		}

		[AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glDisableClientState")]
		public static void DisableClientState(ArrayCap array) {
			Delegates.glDisableClientState(array);
		}

		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glDisableVertexAttribArray")]
		public static void DisableVertexAttribArray(Int32 index) {
			Delegates.glDisableVertexAttribArray((UInt32)index);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glDrawArrays")]
		public static void DrawArrays(BeginMode mode, Int32 first, Int32 count) {
			Delegates.glDrawArrays(mode, first, count);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glDrawElements")]
		public static void DrawElements(BeginMode mode, Int32 count, DrawElementsType type, IntPtr indices) {
			Delegates.glDrawElements(mode, count, type, indices);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glEnable")]
		public static void Enable(EnableCap cap) {
			Delegates.glEnable(cap);
		}
		
		[AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glEnableClientState")]
		public static void EnableClientState(OpenTK.Graphics.OpenGL.ArrayCap array) {
			Delegates.glEnableClientState(array);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glEnableVertexAttribArray")]
		public static void EnableVertexAttribArray(Int32 index) {
			Delegates.glEnableVertexAttribArray((UInt32)index);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glFinish")]
		public static void Finish() {
			Delegates.glFinish();
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glFlush")]
		public static void Flush() {
			Delegates.glFlush();
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glFogf")]
		public static void Fog(FogParameter pname, Single param) {
			Delegates.glFogf(pname, param);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glFogfv")]
		public static unsafe void Fog(FogParameter pname, Single* @params) {
			Delegates.glFogfv(pname, @params);
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glFogi")]
		public static void Fog(FogParameter pname, Int32 param) {
			Delegates.glFogi(pname, param);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glFogiv")]
		public static unsafe void Fog(FogParameter pname, Int32* @params) {
			Delegates.glFogiv(pname, @params);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glFrontFace")]
		public static void FrontFace(FrontFaceDirection mode) {
			Delegates.glFrontFace(mode);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glGenBuffers")]
		public static unsafe void GenBuffers(Int32 n, [OutAttribute] Int32* buffers) {
			Delegates.glGenBuffers(n, (UInt32*)buffers);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glGenTextures")]
		public static unsafe void GenTextures(Int32 n, [OutAttribute] Int32* textures) {
			Delegates.glGenTextures(n, (UInt32*)textures);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetActiveAttrib")]
		public unsafe static void GetActiveAttrib(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveAttribType* type, [OutAttribute] StringBuilder name) {
			Delegates.glGetActiveAttrib((UInt32)program, (UInt32)index, bufSize, length, size, type, (StringBuilder)name);
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetActiveUniform")]
		public unsafe static void GetActiveUniform(Int32 program, Int32 index, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] Int32* size, [OutAttribute] ActiveUniformType* type, [OutAttribute] StringBuilder name) {
			Delegates.glGetActiveUniform((UInt32)program, (UInt32)index, bufSize, length, size, type, name);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetAttribLocation")]
		public static Int32 GetAttribLocation(Int32 program, String name) {
			return Delegates.glGetAttribLocation((UInt32)program, name);
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glGetBooleanv")]
		public static unsafe void GetBoolean(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] bool* @params) {
			Delegates.glGetBooleanv(pname, @params);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glGetError")]
		public static OpenTK.Graphics.OpenGL.ErrorCode GetError() {
			return Delegates.glGetError();
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glGetFloatv")]
		public unsafe static void GetFloat(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] Single* @params) {
			Delegates.glGetFloatv(pname, @params);
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glGetIntegerv")]
		public static unsafe void GetInteger(OpenTK.Graphics.OpenGL.GetPName pname, [OutAttribute] Int32* @params) {
			Delegates.glGetIntegerv(pname, @params);
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetProgramInfoLog")]
		public unsafe static void GetProgramInfoLog(Int32 program, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog) {
			Delegates.glGetProgramInfoLog((UInt32)program, bufSize, length, infoLog);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetProgramiv")]
		public unsafe static void GetProgram(Int32 program, OpenTK.Graphics.OpenGL.ProgramParameter pname, [OutAttribute] Int32* @params) {
			Delegates.glGetProgramiv((UInt32)program, pname, @params);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetShaderInfoLog")]
		public unsafe static void GetShaderInfoLog(Int32 shader, Int32 bufSize, [OutAttribute] Int32* length, [OutAttribute] StringBuilder infoLog) {
			Delegates.glGetShaderInfoLog((UInt32)shader, bufSize, length, infoLog);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetShaderiv")]
		public unsafe static void GetShader(Int32 shader, OpenTK.Graphics.OpenGL.ShaderParameter pname, [OutAttribute] Int32* @params) {
			Delegates.glGetShaderiv((UInt32)shader, pname, @params);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glGetString")]
		public unsafe static System.String GetString(OpenTK.Graphics.OpenGL.StringName name) {
			return new string((sbyte*)Delegates.glGetString(name));
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glGetUniformLocation")]
		public static Int32 GetUniformLocation(Int32 program, String name) {
			return Delegates.glGetUniformLocation((UInt32)program, name);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glHint")]
		public static void Hint(HintTarget target, HintMode mode) {
			Delegates.glHint(target, mode);
		}
		
		[AutoGenerated(Category = "Version15", Version = "1.5", EntryPoint = "glIsBuffer")]
		public static bool IsBuffer(Int32 buffer) {
			return Delegates.glIsBuffer((UInt32)buffer);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glIsProgram")]
		public static bool IsProgram(Int32 program) {
			return Delegates.glIsProgram((UInt32)program);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glIsShader")]
		public static bool IsShader(Int32 shader) {
			return Delegates.glIsShader((UInt32)shader);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glIsTexture")]
		public static bool IsTexture(Int32 texture) {
			return Delegates.glIsTexture((UInt32)texture);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glLinkProgram")]
		public static void LinkProgram(Int32 program) {
			Delegates.glLinkProgram((UInt32)program);
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glLoadIdentity")]
		public static void LoadIdentity() {
			Delegates.glLoadIdentity();
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glLoadMatrixf")]
		public static unsafe void LoadMatrix(Single* m) {
			Delegates.glLoadMatrixf(m);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glLogicOp")]
		public static void LogicOp(OpenTK.Graphics.OpenGL.LogicOp opcode) {
			Delegates.glLogicOp(opcode);
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glMatrixMode")]
		public static void MatrixMode(MatrixMode mode) {
			Delegates.glMatrixMode(mode);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glMultMatrixf")]
		public static unsafe void MultMatrix(Single* m) {
			Delegates.glMultMatrixf(m);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glPixelStoref")]
		public static void PixelStore(PixelStoreParameter pname, Single param) {
			Delegates.glPixelStoref(pname, param);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glPixelStorei")]
		public static void PixelStore(PixelStoreParameter pname, Int32 param) {
			Delegates.glPixelStorei(pname, param);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glPolygonOffset")]
		public static void PolygonOffset(Single factor, Single units) {
			Delegates.glPolygonOffset(factor, units);
		}

		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glPopMatrix")]
		public static void PopMatrix() {
			Delegates.glPopMatrix();
		}

		[AutoGenerated(Category = "ArbProvokingVertex", Version = "1.2", EntryPoint = "glProvokingVertex")]
		public static void ProvokingVertex(ProvokingVertexMode mode) {
			Delegates.glProvokingVertex(mode);
		}
		
		[AutoGenerated(Category = "Version10Deprecated", Version = "1.0", EntryPoint = "glPushMatrix")]
		public static void PushMatrix() {
			Delegates.glPushMatrix();
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glReadPixels")]
		public static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, PixelFormat format, PixelType type, [OutAttribute] IntPtr pixels) {
			Delegates.glReadPixels(x, y, width, height, format, type, pixels);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glShaderSource")]
		public static unsafe void ShaderSource(Int32 shader, Int32 count, String[] @string, Int32* length) {
			Delegates.glShaderSource((UInt32)shader, count, @string, length);
		}
		
		[AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glTexCoordPointer")]
		public static void TexCoordPointer(Int32 size, OpenTK.Graphics.OpenGL.TexCoordPointerType type, Int32 stride, IntPtr pointer) {
			Delegates.glTexCoordPointer(size, type, stride, pointer);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glTexImage2D")]
		public static void TexImage2D(TextureTarget target, Int32 level, PixelInternalFormat internalformat, Int32 width, Int32 height, Int32 border, PixelFormat format, PixelType type, IntPtr pixels) {
			Delegates.glTexImage2D(target, level, internalformat, width, height, border, format, type, pixels);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glTexParameterf")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Single param) {
			Delegates.glTexParameterf(target, pname, param);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glTexParameteri")]
		public static void TexParameter(TextureTarget target, TextureParameterName pname, Int32 param) {
			Delegates.glTexParameteri(target, pname, param);
		}
		
		[AutoGenerated(Category = "Version11", Version = "1.1", EntryPoint = "glTexSubImage2D")]
		public static void TexSubImage2D(TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, PixelFormat format, PixelType type, IntPtr pixels) {
			Delegates.glTexSubImage2D(target, level, xoffset, yoffset, width, height, format, type, pixels);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1f")]
		public static void Uniform1(Int32 location, Single v0) {
			Delegates.glUniform1f(location, v0);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1fv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, Single[] value) {
			fixed (Single* value_ptr = value) {
				Delegates.glUniform1fv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1fv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, ref Single value) {
			fixed (Single* value_ptr = &value) {
				Delegates.glUniform1fv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1fv")]
		public static unsafe void Uniform1(Int32 location, Int32 count, Single* value) {
			Delegates.glUniform1fv(location, count, value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1i")]
		public static void Uniform1(Int32 location, Int32 v0) {
			Delegates.glUniform1i(location, v0);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1iv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, Int32[] value) {
			fixed (Int32* value_ptr = value) {
				Delegates.glUniform1iv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1iv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, ref Int32 value) {
			fixed (Int32* value_ptr = &value) {
				Delegates.glUniform1iv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform1iv")]
		public static unsafe void Uniform1(Int32 location, Int32 count, Int32* value) {
			Delegates.glUniform1iv(location, count, value);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform1ui")]
		public static void Uniform1(Int32 location, UInt32 v0) {
			Delegates.glUniform1ui(location, (UInt32)v0);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform1uiv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, UInt32[] value) {
			fixed (UInt32* value_ptr = value) {
				Delegates.glUniform1uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform1uiv")]
		public unsafe static void Uniform1(Int32 location, Int32 count, ref UInt32 value) {
			fixed (UInt32* value_ptr = &value) {
				Delegates.glUniform1uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform1uiv")]
		public static unsafe void Uniform1(Int32 location, Int32 count, UInt32* value) {
			Delegates.glUniform1uiv(location, count, (UInt32*)value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2f")]
		public static void Uniform2(Int32 location, Single v0, Single v1) {
			Delegates.glUniform2f(location, v0, v1);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2fv")]
		public unsafe static void Uniform2(Int32 location, Int32 count, Single[] value) {
			fixed (Single* value_ptr = value) {
				Delegates.glUniform2fv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2fv")]
		public unsafe static void Uniform2(Int32 location, Int32 count, ref Single value) {
			fixed (Single* value_ptr = &value) {
				Delegates.glUniform2fv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2fv")]
		public static unsafe void Uniform2(Int32 location, Int32 count, Single* value) {
			Delegates.glUniform2fv(location, count, value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2i")]
		public static void Uniform2(Int32 location, Int32 v0, Int32 v1) {
			Delegates.glUniform2i(location, v0, v1);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2iv")]
		public unsafe static void Uniform2(Int32 location, Int32 count, Int32[] value) {
			fixed (Int32* value_ptr = value) {
				Delegates.glUniform2iv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform2iv")]
		public static unsafe void Uniform2(Int32 location, Int32 count, Int32* value) {
			Delegates.glUniform2iv(location, count, value);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform2ui")]
		public static void Uniform2(Int32 location, UInt32 v0, UInt32 v1) {
			Delegates.glUniform2ui(location, (UInt32)v0, (UInt32)v1);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform2uiv")]
		public unsafe static void Uniform2(Int32 location, Int32 count, UInt32[] value) {
			fixed (UInt32* value_ptr = value) {
				Delegates.glUniform2uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform2uiv")]
		public unsafe static void Uniform2(Int32 location, Int32 count, ref UInt32 value) {
			fixed (UInt32* value_ptr = &value) {
				Delegates.glUniform2uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform2uiv")]
		public static unsafe void Uniform2(Int32 location, Int32 count, UInt32* value) {
			Delegates.glUniform2uiv(location, count, (UInt32*)value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3f")]
		public static void Uniform3(Int32 location, Single v0, Single v1, Single v2) {
			Delegates.glUniform3f(location, v0, v1, v2);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3fv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, Single[] value) {
			fixed (Single* value_ptr = value) {
				Delegates.glUniform3fv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3fv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, ref Single value) {
			fixed (Single* value_ptr = &value) {
				Delegates.glUniform3fv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3fv")]
		public static unsafe void Uniform3(Int32 location, Int32 count, Single* value) {
			Delegates.glUniform3fv(location, count, value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3i")]
		public static void Uniform3(Int32 location, Int32 v0, Int32 v1, Int32 v2) {
			Delegates.glUniform3i(location, v0, v1, v2);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3iv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, Int32[] value) {
			fixed (Int32* value_ptr = value) {
				Delegates.glUniform3iv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3iv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, ref Int32 value) {
			fixed (Int32* value_ptr = &value) {
				Delegates.glUniform3iv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform3iv")]
		public static unsafe void Uniform3(Int32 location, Int32 count, Int32* value) {
			Delegates.glUniform3iv(location, count, value);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform3ui")]
		public static void Uniform3(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2) {
			Delegates.glUniform3ui(location, (UInt32)v0, (UInt32)v1, (UInt32)v2);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform3uiv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, UInt32[] value) {
			fixed (UInt32* value_ptr = value) {
				Delegates.glUniform3uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform3uiv")]
		public unsafe static void Uniform3(Int32 location, Int32 count, ref UInt32 value) {
			fixed (UInt32* value_ptr = &value) {
				Delegates.glUniform3uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform3uiv")]
		public static unsafe void Uniform3(Int32 location, Int32 count, UInt32* value) {
			Delegates.glUniform3uiv(location, count, (UInt32*)value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4f")]
		public static void Uniform4(Int32 location, Single v0, Single v1, Single v2, Single v3) {
			Delegates.glUniform4f(location, v0, v1, v2, v3);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4fv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, Single[] value) {
			fixed (Single* value_ptr = value) {
				Delegates.glUniform4fv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4fv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, ref Single value) {
			fixed (Single* value_ptr = &value) {
				Delegates.glUniform4fv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4fv")]
		public static unsafe void Uniform4(Int32 location, Int32 count, Single* value) {
			Delegates.glUniform4fv(location, count, value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4i")]
		public static void Uniform4(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3) {
			Delegates.glUniform4i(location, v0, v1, v2, v3);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4iv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, Int32[] value) {
			fixed (Int32* value_ptr = value) {
				Delegates.glUniform4iv(location, count, value_ptr);
			}
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4iv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, ref Int32 value) {
			fixed (Int32* value_ptr = &value) {
				Delegates.glUniform4iv(location, count, value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniform4iv")]
		public static unsafe void Uniform4(Int32 location, Int32 count, Int32* value) {
			Delegates.glUniform4iv(location, count, value);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform4ui")]
		public static void Uniform4(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3) {
			Delegates.glUniform4ui(location, (UInt32)v0, (UInt32)v1, (UInt32)v2, (UInt32)v3);
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform4uiv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, UInt32[] value) {
			fixed (UInt32* value_ptr = value) {
				Delegates.glUniform4uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform4uiv")]
		public unsafe static void Uniform4(Int32 location, Int32 count, ref UInt32 value) {
			fixed (UInt32* value_ptr = &value) {
				Delegates.glUniform4uiv(location, count, (UInt32*)value_ptr);
			}
		}
		
		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glUniform4uiv")]
		public static unsafe void Uniform4(Int32 location, Int32 count, UInt32* value) {
			Delegates.glUniform4uiv(location, count, (UInt32*)value);
		}

		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniformMatrix4fv")]
		public unsafe static void UniformMatrix4(Int32 location, Int32 count, bool transpose, Single[] value) {
			fixed (Single* value_ptr = value) {
				Delegates.glUniformMatrix4fv(location, count, transpose, value_ptr);
			}
		}

		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniformMatrix4fv")]
		public unsafe static void UniformMatrix4(Int32 location, Int32 count, bool transpose, ref Single value) {
			fixed (Single* value_ptr = &value) {
				Delegates.glUniformMatrix4fv(location, count, transpose, value_ptr);
			}
		}

		[System.CLSCompliant(false)]
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUniformMatrix4fv")]
		public static unsafe void UniformMatrix4(Int32 location, Int32 count, bool transpose, Single* value) {
			Delegates.glUniformMatrix4fv(location, count, transpose, value);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glUseProgram")]
		public static void UseProgram(Int32 program) {
			Delegates.glUseProgram((UInt32)program);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glValidateProgram")]
		public static void ValidateProgram(Int32 program) {
			Delegates.glValidateProgram((UInt32)program);
		}

		[AutoGenerated(Category = "Version30", Version = "3.0", EntryPoint = "glVertexAttribIPointer")]
		public static void VertexAttribIPointer(Int32 index, Int32 size, VertexAttribIPointerType type, Int32 stride, IntPtr pointer) {
			Delegates.glVertexAttribIPointer((UInt32)index, size, type, stride, pointer);
		}
		
		[AutoGenerated(Category = "Version20", Version = "2.0", EntryPoint = "glVertexAttribPointer")]
		public static void VertexAttribPointer(Int32 index, Int32 size, VertexAttribPointerType type, bool normalized, Int32 stride, IntPtr pointer) {
			Delegates.glVertexAttribPointer((UInt32)index, size, type, normalized, stride, pointer);
		}
		
		[AutoGenerated(Category = "Version11Deprecated", Version = "1.1", EntryPoint = "glVertexPointer")]
		public static void VertexPointer(Int32 size, VertexPointerType type, Int32 stride, IntPtr pointer) {
			Delegates.glVertexPointer(size, type, stride, pointer);
		}
		
		[AutoGenerated(Category = "Version10", Version = "1.0", EntryPoint = "glViewport")]
		public static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height) {
			Delegates.glViewport(x, y, width, height);
		}
	}
}