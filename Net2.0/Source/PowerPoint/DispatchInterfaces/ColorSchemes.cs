//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.PowerPointApi
{
	///<summary>
	/// DispatchInterface ColorSchemes SupportByLibrary PP09 PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
	public class ColorSchemes : Collection
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorSchemes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorSchemes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorSchemes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ColorSchemes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.PowerPointApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public COMObject Parent
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Parent", paramsArray);
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem);
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="index">Int32 index</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.ColorScheme Item(Int32 index)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray);
			LateBindingApi.PowerPointApi.ColorScheme newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.ColorScheme;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary PP09 PP10 PP11 PP12 PP14 
		/// </summary>
		/// <param name="Scheme">LateBindingApi.PowerPointApi.ColorScheme Scheme</param>
		[SupportByLibrary("PP09","PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.ColorScheme Add(LateBindingApi.PowerPointApi.ColorScheme scheme)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(scheme);
			object returnItem = Invoker.MethodReturn(this, "Add", paramsArray);
			LateBindingApi.PowerPointApi.ColorScheme newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.PowerPointApi.ColorScheme;
			return newObject;
		}

		#endregion
		#pragma warning restore
	}
}