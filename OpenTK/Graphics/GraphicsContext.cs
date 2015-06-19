#region --- License ---
/* Licensed under the MIT/X11 license.
 * Copyright (c) 2006-2008 the OpenTK Team.
 * This notice may not be removed from any source distribution.
 * See license.txt for licensing detailed licensing details.
 */
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

using OpenTK.Platform;

namespace OpenTK.Graphics
{
	/// <summary>
	/// Represents and provides methods to manipulate an OpenGL render context.
	/// </summary>
	public sealed class GraphicsContext : IGraphicsContext, IGraphicsContextInternal
	{
		#region --- Fields ---

		IGraphicsContext implementation;  // The actual render context implementation for the underlying platform.
		bool disposed;

		readonly static object SyncRoot = new object();
		// Maps OS-specific context handles to GraphicsContext weak references.
		readonly static Dictionary<ContextHandle, WeakReference> available_contexts = new Dictionary<ContextHandle, WeakReference>();

		#endregion

		#region --- Constructors ---
		
		/// <summary>
		/// Constructs a new GraphicsContext with the specified GraphicsMode and attaches it to the specified window.
		/// </summary>
		/// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GraphicsContext.</param>
		/// <param name="window">The OpenTK.Platform.IWindowInfo to attach the GraphicsContext to.</param>
		public GraphicsContext(GraphicsMode mode, IWindowInfo window)
			: this(mode, window, 1, 0)
		{ }

		/// <summary>
		/// Constructs a new GraphicsContext with the specified GraphicsMode, version and flags,  and attaches it to the specified window.
		/// </summary>
		/// <param name="mode">The OpenTK.Graphics.GraphicsMode of the GraphicsContext.</param>
		/// <param name="window">The OpenTK.Platform.IWindowInfo to attach the GraphicsContext to.</param>
		/// <param name="major">The major version of the new GraphicsContext.</param>
		/// <param name="minor">The minor version of the new GraphicsContext.</param>
		/// <param name="flags">The GraphicsContextFlags for the GraphicsContext.</param>
		/// <remarks>
		/// Different hardware supports different flags, major and minor versions. Invalid parameters will be silently ignored.
		/// </remarks>
		public GraphicsContext(GraphicsMode mode, IWindowInfo window, int major, int minor)
		{
			lock (SyncRoot)
			{
				if (mode == null) throw new ArgumentNullException("mode", "Must be a valid GraphicsMode.");
				if (window == null) throw new ArgumentNullException("window", "Must point to a valid window.");

				// Silently ignore invalid major and minor versions.
				if (major <= 0) major = 1;
				if (minor < 0) minor = 0;

				Debug.Print("Creating GraphicsContext.");
				try
				{
					Debug.Indent();
					Debug.Print("GraphicsMode: {0}", mode);
					Debug.Print("IWindowInfo: {0}", window);
					Debug.Print("Requested version: {0}.{1}", major, minor);
					
					IPlatformFactory factory = Factory.Default;
					implementation = factory.CreateGLContext(mode, window, major, minor);
					// Note: this approach does not allow us to mix native and EGL contexts in the same process.
					// This should not be a problem, as this use-case is not interesting for regular applications.
					// Note 2: some platforms may not support a direct way of getting the current context
					// (this happens e.g. with DummyGLContext). In that case, we use a slow fallback which
					// iterates through all known contexts and checks if any is current (check GetCurrentContext
					// declaration).
					if (GetCurrentContext == null)
					{
						GetCurrentContextDelegate temp = factory.CreateGetCurrentGraphicsContext();
						if (temp != null)
						{
							GetCurrentContext = temp;
						}
					}

					available_contexts.Add((this as IGraphicsContextInternal).Context, new WeakReference(this));
				}
				finally
				{
					Debug.Unindent();
				}
			}
		}
		#endregion

		#region Private Members

		#endregion

		#region --- Static Members ---

		#region public static void Assert()

		/// <summary>
		/// Checks if a GraphicsContext exists in the calling thread and throws a GraphicsContextMissingException if it doesn't.
		/// </summary>
		/// <exception cref="GraphicsContextMissingException">Generated when no GraphicsContext is current in the calling thread.</exception>
		public static void Assert()
		{
			if (GraphicsContext.CurrentContext == null)
				throw new GraphicsContextMissingException();
		}

		#endregion

		#region public static IGraphicsContext CurrentContext

		internal delegate ContextHandle GetCurrentContextDelegate();
		internal static GetCurrentContextDelegate GetCurrentContext = delegate
		{
			// Note: this is a slow, generic fallback for use with DummyGLContext.
			// Most other platforms can query the current context directly (via
			// [Wgl|Glx|Agl|Egl].GetCurrentContext()) so the GraphicsContext
			// constructor will replace this implementation with a platform-specific
			// one, if it exists.
			foreach (WeakReference weak_ref in available_contexts.Values)
			{
				IGraphicsContext context = (IGraphicsContext)weak_ref.Target;
				if (context.IsCurrent)
				{
					return (context as IGraphicsContextInternal).Context;
				}
			}

			return ContextHandle.Zero;
		};

		/// <summary>
		/// Gets the GraphicsContext that is current in the calling thread.
		/// </summary>
		/// <remarks>
		/// Note: this property will not function correctly when both desktop and EGL contexts are
		/// available in the same process. This scenario is very unlikely to appear in practice.
		/// </remarks>
		public static IGraphicsContext CurrentContext
		{
			get
			{
				lock (SyncRoot)
				{
					if (available_contexts.Count > 0)
					{
						ContextHandle handle = GetCurrentContext();
						if (handle.Handle != IntPtr.Zero)
							return (GraphicsContext)available_contexts[handle].Target;
					}
					return null;
				}
			}
		}

		#endregion

		#endregion

		#region --- IGraphicsContext Members ---

		/// <summary>
		/// Creates an OpenGL context with the specified direct/indirect rendering mode and sharing state with the
		/// specified IGraphicsContext.
		/// </summary>
		/// <param name="direct">Set to true for direct rendering or false otherwise.</param>
		/// <param name="source">The source IGraphicsContext to share state from.</param>.
		/// <remarks>
		/// <para>
		/// Direct rendering is the default rendering mode for OpenTK, since it can provide higher performance
		/// in some circumastances.
		/// </para>
		/// <para>
		/// The 'direct' parameter is a hint, and will ignored if the specified mode is not supported (e.g. setting
		/// indirect rendering on Windows platforms).
		/// </para>
		/// </remarks>
		void CreateContext(bool direct, IGraphicsContext source)
		{
			lock (SyncRoot)
			{
				available_contexts.Add((this as IGraphicsContextInternal).Context, new WeakReference(this));
			}
		}

		/// <summary>
		/// Swaps buffers on a context. This presents the rendered scene to the user.
		/// </summary>
		public void SwapBuffers()
		{
			implementation.SwapBuffers();
		}

		/// <summary>
		/// Makes the GraphicsContext the current rendering target.
		/// </summary>
		/// <param name="window">A valid <see cref="OpenTK.Platform.IWindowInfo" /> structure.</param>
		/// <remarks>
		/// You can use this method to bind the GraphicsContext to a different window than the one it was created from.
		/// </remarks>
		public void MakeCurrent(IWindowInfo window)
		{
			implementation.MakeCurrent(window);
		}

		/// <summary>
		/// Gets a <see cref="System.Boolean"/> indicating whether this instance is current in the calling thread.
		/// </summary>
		public bool IsCurrent
		{
			get { return implementation.IsCurrent; }
		}

		/// <summary>
		/// Gets a <see cref="System.Boolean"/> indicating whether this instance has been disposed.
		/// It is an error to access any instance methods if this property returns true.
		/// </summary>
		public bool IsDisposed
		{
			get { return disposed && implementation.IsDisposed; }
			private set { disposed = value; }
		}

		/// <summary>
		/// Gets or sets a value indicating whether VSync is enabled.
		/// </summary>
		public bool VSync
		{
			get { return implementation.VSync; }
			set { implementation.VSync = value;  }
		}

		/// <summary>
		/// Updates the graphics context.  This must be called when the render target
		/// is resized for proper behavior on Mac OS X.
		/// </summary>
		/// <param name="window"></param>
		public void Update(IWindowInfo window)
		{
			implementation.Update(window);
		}

		/// <summary>
		/// Loads all OpenGL entry points.
		/// </summary>
		/// <exception cref="OpenTK.Graphics.GraphicsContextException">
		/// Occurs when this instance is not current on the calling thread.
		/// </exception>
		public void LoadAll()
		{
			if (GraphicsContext.CurrentContext != this)
				throw new GraphicsContextException();

			implementation.LoadAll();
		}
		
		#endregion

		#region --- IGraphicsContextInternal Members ---

		/// <summary>
		/// Gets a handle to the OpenGL rendering context.
		/// </summary>
		ContextHandle IGraphicsContextInternal.Context
		{
			get { return ((IGraphicsContextInternal)implementation).Context; }
		}

		/// <summary>
		/// Gets the GraphicsMode of the context.
		/// </summary>
		public GraphicsMode GraphicsMode
		{
			get { return (implementation as IGraphicsContext).GraphicsMode; }
		}

		/// <summary>
		/// Gets the address of an OpenGL extension function.
		/// </summary>
		/// <param name="function">The name of the OpenGL function (e.g. "glGetString")</param>
		/// <returns>
		/// A pointer to the specified function or IntPtr.Zero if the function isn't
		/// available in the current opengl context.
		/// </returns>
		IntPtr IGraphicsContextInternal.GetAddress(string function)
		{
			return (implementation as IGraphicsContextInternal).GetAddress(function);
		}

		#endregion

		#region --- IDisposable Members ---

		/// <summary>
		/// Disposes of the GraphicsContext.
		/// </summary>
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		void Dispose(bool manual)
		{
			if (!IsDisposed)
			{
				Debug.Print("Disposing context {0}.", (this as IGraphicsContextInternal).Context.ToString());
				lock (SyncRoot)
				{
					available_contexts.Remove((this as IGraphicsContextInternal).Context);
				}

				if (manual) {
					if (implementation != null)
						implementation.Dispose();
				}
				IsDisposed = true;
			}
		}

		#endregion
	}
}