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
	/// DispatchInterface LegendKey SupportByLibrary PP14 
	///</summary>
	[SupportByLibrary("PP14")]
	public class LegendKey : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LegendKey(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LegendKey(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LegendKey(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public LegendKey()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
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
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.ChartBorder Border
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Border", paramsArray);
				LateBindingApi.PowerPointApi.ChartBorder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.ChartBorder;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Interior Interior
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Interior", paramsArray);
				LateBindingApi.PowerPointApi.Interior newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.Interior;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.ChartFillFormat Fill
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Fill", paramsArray);
				LateBindingApi.PowerPointApi.ChartFillFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.ChartFillFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool InvertIfNegative
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "InvertIfNegative", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "InvertIfNegative", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 MarkerBackgroundColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerBackgroundColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerBackgroundColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Enums.XlColorIndex MarkerBackgroundColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerBackgroundColorIndex", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.XlColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerBackgroundColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 MarkerForegroundColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerForegroundColor", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerForegroundColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Enums.XlColorIndex MarkerForegroundColorIndex
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerForegroundColorIndex", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.XlColorIndex)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerForegroundColorIndex", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 MarkerSize
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerSize", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerSize", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.Enums.XlMarkerStyle MarkerStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "MarkerStyle", paramsArray);
				return (LateBindingApi.PowerPointApi.Enums.XlMarkerStyle)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "MarkerStyle", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 PictureType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureType", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PictureType", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool Smooth
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Smooth", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Smooth", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Double Left
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Left", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Double Top
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Top", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Double Width
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Width", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Double Height
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Height", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public bool Shadow
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Shadow", paramsArray);
				return (bool)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Shadow", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public LateBindingApi.PowerPointApi.ChartFormat Format
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Format", paramsArray);
				LateBindingApi.PowerPointApi.ChartFormat newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.PowerPointApi.ChartFormat;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 Creator
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Creator", paramsArray);
				return (Int32)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Double PictureUnit2
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureUnit2", paramsArray);
				return (Double)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PictureUnit2", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
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
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public Int32 PictureUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PictureUnit", paramsArray);
				return (Int32)returnItem;
			}
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "PictureUnit", paramsArray);
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public object ClearFormats()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "ClearFormats", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public object Delete()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Delete", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary PP14 
		/// </summary>
		[SupportByLibrary("PP14")]
		public object Select()
		{
			object[] paramsArray = null;
			object returnItem = Invoker.MethodReturn(this, "Select", paramsArray);
			Type returnItemType = returnItem.GetType();
			if(true == returnItemType.IsCOMObject)
			{
				COMObject newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem, returnItemType);
				return newObject;
			}
			else
			{
				return  returnItem;
			}
		}

		#endregion
		#pragma warning restore
	}
}