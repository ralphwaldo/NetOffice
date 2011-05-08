//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using System.Collections;
using LateBindingApi.Core;
namespace LateBindingApi.WordApi
{
	///<summary>
	/// DispatchInterface CanvasShapes SupportByLibrary WD10 WD11 WD12 WD14 
	///</summary>
	[SupportByLibrary("WD10","WD11","WD12","WD14")]
	public class CanvasShapes : COMObject ,IEnumerable
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public CanvasShapes()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Application Application
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Application", paramsArray);
				LateBindingApi.WordApi.Application newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this,returnItem) as LateBindingApi.WordApi.Application;
				return newObject;
			}
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
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
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public Int32 Count
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Count", paramsArray);
				return (Int32)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape Item(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Item", paramsArray, modifiers);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			index = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Type">LateBindingApi.OfficeApi.Enums.MsoCalloutType Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddCallout(LateBindingApi.OfficeApi.Enums.MsoCalloutType type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddCallout", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Type">LateBindingApi.OfficeApi.Enums.MsoConnectorType Type</param>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddConnector(LateBindingApi.OfficeApi.Enums.MsoConnectorType type, Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddConnector", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="SafeArrayOfPoints">ref object SafeArrayOfPoints</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddCurve(ref object safeArrayOfPoints)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddCurve", paramsArray, modifiers);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			safeArrayOfPoints = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Orientation">LateBindingApi.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddLabel(LateBindingApi.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddLabel", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="BeginX">Single BeginX</param>
		/// <param name="BeginY">Single BeginY</param>
		/// <param name="EndX">Single EndX</param>
		/// <param name="EndY">Single EndY</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddLine(Single beginX, Single beginY, Single endX, Single endY)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(beginX, beginY, endX, endY);
			object returnItem = Invoker.MethodReturn(this, "AddLine", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		/// <param name="LinkToFile">ref optional object LinkToFile</param>
		/// <param name="SaveWithDocument">ref optional object SaveWithDocument</param>
		/// <param name="Left">ref optional object Left</param>
		/// <param name="Top">ref optional object Top</param>
		/// <param name="Width">ref optional object Width</param>
		/// <param name="Height">ref optional object Height</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddPicture(string fileName, ref object linkToFile, ref object saveWithDocument, ref object left, ref object top, ref object width, ref object height)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(false,true,true,true,true,true,true);
			object[] paramsArray = Invoker.ValidateParamsArray(fileName, linkToFile, saveWithDocument, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray, modifiers);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			linkToFile = (object)paramsArray[1];
			saveWithDocument = (object)paramsArray[2];
			left = (object)paramsArray[3];
			top = (object)paramsArray[4];
			width = (object)paramsArray[5];
			height = (object)paramsArray[6];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="FileName">string FileName</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddPicture(string fileName)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(fileName);
			object returnItem = Invoker.MethodReturn(this, "AddPicture", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="SafeArrayOfPoints">ref object SafeArrayOfPoints</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddPolyline(ref object safeArrayOfPoints)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(safeArrayOfPoints);
			object returnItem = Invoker.MethodReturn(this, "AddPolyline", paramsArray, modifiers);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			safeArrayOfPoints = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Type">Int32 Type</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddShape(Int32 type, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(type, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddShape", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="PresetTextEffect">LateBindingApi.OfficeApi.Enums.MsoPresetTextEffect PresetTextEffect</param>
		/// <param name="Text">string Text</param>
		/// <param name="FontName">string FontName</param>
		/// <param name="FontSize">Single FontSize</param>
		/// <param name="FontBold">LateBindingApi.OfficeApi.Enums.MsoTriState FontBold</param>
		/// <param name="FontItalic">LateBindingApi.OfficeApi.Enums.MsoTriState FontItalic</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddTextEffect(LateBindingApi.OfficeApi.Enums.MsoPresetTextEffect presetTextEffect, string text, string fontName, Single fontSize, LateBindingApi.OfficeApi.Enums.MsoTriState fontBold, LateBindingApi.OfficeApi.Enums.MsoTriState fontItalic, Single left, Single top)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(presetTextEffect, text, fontName, fontSize, fontBold, fontItalic, left, top);
			object returnItem = Invoker.MethodReturn(this, "AddTextEffect", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Orientation">LateBindingApi.OfficeApi.Enums.MsoTextOrientation Orientation</param>
		/// <param name="Left">Single Left</param>
		/// <param name="Top">Single Top</param>
		/// <param name="Width">Single Width</param>
		/// <param name="Height">Single Height</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.Shape AddTextbox(LateBindingApi.OfficeApi.Enums.MsoTextOrientation orientation, Single left, Single top, Single width, Single height)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(orientation, left, top, width, height);
			object returnItem = Invoker.MethodReturn(this, "AddTextbox", paramsArray);
			LateBindingApi.WordApi.Shape newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.Shape;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="EditingType">LateBindingApi.OfficeApi.Enums.MsoEditingType EditingType</param>
		/// <param name="X1">Single X1</param>
		/// <param name="Y1">Single Y1</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.FreeformBuilder BuildFreeform(LateBindingApi.OfficeApi.Enums.MsoEditingType editingType, Single x1, Single y1)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(editingType, x1, y1);
			object returnItem = Invoker.MethodReturn(this, "BuildFreeform", paramsArray);
			LateBindingApi.WordApi.FreeformBuilder newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.FreeformBuilder;
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		/// <param name="Index">ref object Index</param>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public LateBindingApi.WordApi.ShapeRange Range(ref object index)
		{
			ParameterModifier[] modifiers = Invoker.CreateParamModifiers(true);
			object[] paramsArray = Invoker.ValidateParamsArray(index);
			object returnItem = Invoker.MethodReturn(this, "Range", paramsArray, modifiers);
			LateBindingApi.WordApi.ShapeRange newObject = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, returnItem) as LateBindingApi.WordApi.ShapeRange;
			index = (object)paramsArray[0];
			return newObject;
		}

		/// <summary>
		/// SupportByLibrary WD10 WD11 WD12 WD14 
		/// </summary>
		[SupportByLibrary("WD10","WD11","WD12","WD14")]
		public void SelectAll()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SelectAll", paramsArray);
		}

		#endregion
   
        #region IEnumerable Members
        
        [SupportByLibrary("WD10","WD11","WD12","WD14")]
		public IEnumerator GetEnumerator()
		{
			object enumProxy = Invoker.PropertyGet(this, "_NewEnum");
			COMObject enumerator = new COMObject(this, enumProxy);
			Invoker.Method(enumerator, "Reset", null);
			bool isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
            while (true == isMoveNextTrue)
            {
                object itemProxy = Invoker.PropertyGet(enumerator, "Current", null);
                COMObject returnClass = LateBindingApi.Core.Factory.CreateObjectFromComProxy(this, itemProxy);
                isMoveNextTrue = (bool)Invoker.MethodReturn(enumerator, "MoveNext", null);
				yield return returnClass;
            }
        }

        #endregion
		#pragma warning restore
	}
}