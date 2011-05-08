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
	/// DispatchInterface AnimationBehavior SupportByLibrary PP10 PP11 PP12 PP14 
	///</summary>
	[SupportByLibrary("PP10","PP11","PP12","PP14")]
	public class AnimationBehavior : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public AnimationBehavior()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
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
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
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

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Enums.MsoAnimAdditive Additive
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Additive", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.MsoAnimAdditive)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Additive", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Enums.MsoAnimAccumulate Accumulate
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Accumulate", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.MsoAnimAccumulate)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Accumulate", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Enums.MsoAnimType Type
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Type", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.MsoAnimType)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Type", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.MotionEffect MotionEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MotionEffect", paramsArray);
				LateBindingApi.PowerPointApi.MotionEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.MotionEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.ColorEffect ColorEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ColorEffect", paramsArray);
				LateBindingApi.PowerPointApi.ColorEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.ColorEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.ScaleEffect ScaleEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "ScaleEffect", paramsArray);
				LateBindingApi.PowerPointApi.ScaleEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.ScaleEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.RotationEffect RotationEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "RotationEffect", paramsArray);
				LateBindingApi.PowerPointApi.RotationEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.RotationEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.PropertyEffect PropertyEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PropertyEffect", paramsArray);
				LateBindingApi.PowerPointApi.PropertyEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.PropertyEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.Timing Timing
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Timing", paramsArray);
				LateBindingApi.PowerPointApi.Timing newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Timing;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.CommandEffect CommandEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "CommandEffect", paramsArray);
				LateBindingApi.PowerPointApi.CommandEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.CommandEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.FilterEffect FilterEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FilterEffect", paramsArray);
				LateBindingApi.PowerPointApi.FilterEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.FilterEffect;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public LateBindingApi.PowerPointApi.SetEffect SetEffect
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "SetEffect", paramsArray);
				LateBindingApi.PowerPointApi.SetEffect newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.SetEffect;
				return newObject;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP10 PP11 PP12 PP14 
		/// </summary>
		[SupportByLibrary("PP10","PP11","PP12","PP14")]
		public void Delete()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "Delete", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}