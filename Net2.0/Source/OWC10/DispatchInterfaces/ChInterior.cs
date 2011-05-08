//Generated by LateBindingApi.CodeGenerator
using System;
using NetRuntimeSystem = System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.ComponentModel;
using System.Reflection;
using LateBindingApi.Core;
namespace LateBindingApi.OWC10Api
{
	///<summary>
	/// DispatchInterface ChInterior SupportByLibrary XWC1.0 
	///</summary>
	[SupportByLibrary("XWC1.0")]
	public class ChInterior : COMObject
	{
		#pragma warning disable
		#region Construction

        /// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject parentObject, object comProxy) : base(parentObject, comProxy)
		{
		}
		
		/// <param name="parentObject">object there has created the proxy</param>
        /// <param name="comProxy">inner wrapped COM proxy</param>
        /// <param name="comProxyType">Type of inner wrapped COM proxy"</param>
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject parentObject, object comProxy, NetRuntimeSystem.Type comProxyType) : base(parentObject, comProxy, comProxyType)
		{
		}
		
		/// <param name="replacedObject">object to replaced. replacedObject are not usable after this action</param>
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior(COMObject replacedObject) : base(replacedObject)
		{
		}
		
		[EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
		public ChInterior()
		{
		}
		
		#endregion
		
		#region Properties

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public object Color
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Color", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "Color", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public object DefaultColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "DefaultColor", paramsArray);
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
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public object BackColor
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "BackColor", paramsArray);
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
			set
			{
				object[] paramsArray = Invoker.ValidateParamsArray(value);
				Invoker.PropertySet(this, "BackColor", paramsArray);
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum Pattern
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "Pattern", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartFillTypeEnum FillType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "FillType", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartFillTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartPresetGradientTypeEnum PresetGradientType
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetGradientType", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartPresetGradientTypeEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientStyle", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientVariant", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Double GradientDegree
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "GradientDegree", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartPresetTextureEnum PresetTexture
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "PresetTexture", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartPresetTextureEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public string TextureName
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureName", paramsArray);
				return (string)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartTextureFormatEnum TextureFormat
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureFormat", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartTextureFormatEnum)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public Double TextureStackUnit
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TextureStackUnit", paramsArray);
				return (Double)returnItem;
			}
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public LateBindingApi.OWC10Api.Enums.ChartTexturePlacementEnum TexturePlacement
		{
			get
			{
				object[] paramsArray = null;
				object returnItem = Invoker.PropertyGet(this, "TexturePlacement", paramsArray);
				return (LateBindingApi.OWC10Api.Enums.ChartTexturePlacementEnum)returnItem;
			}
		}

		#endregion

		#region Methods

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="patternType">LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum patternType</param>
		/// <param name="Color">optional object Color</param>
		/// <param name="BackColor">optional object BackColor</param>
		[SupportByLibrary("XWC1.0")]
		public void SetPatterned(LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum patternType, object color, object backColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(patternType, color, backColor);
			Invoker.Method(this, "SetPatterned", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="patternType">LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum patternType</param>
		[SupportByLibrary("XWC1.0")]
		public void SetPatterned(LateBindingApi.OWC10Api.Enums.ChartPatternTypeEnum patternType)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(patternType);
			Invoker.Method(this, "SetPatterned", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="GradientStyle">LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="gradientVarient">LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVarient</param>
		/// <param name="gradientPreset">LateBindingApi.OWC10Api.Enums.ChartPresetGradientTypeEnum gradientPreset</param>
		[SupportByLibrary("XWC1.0")]
		public void SetPresetGradient(LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVarient, LateBindingApi.OWC10Api.Enums.ChartPresetGradientTypeEnum gradientPreset)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVarient, gradientPreset);
			Invoker.Method(this, "SetPresetGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="textureFile">object textureFile</param>
		/// <param name="TextureFormat">LateBindingApi.OWC10Api.Enums.ChartTextureFormatEnum TextureFormat</param>
		/// <param name="stackUnit">Double stackUnit</param>
		/// <param name="TexturePlacement">LateBindingApi.OWC10Api.Enums.ChartTexturePlacementEnum TexturePlacement</param>
		[SupportByLibrary("XWC1.0")]
		public void SetTextured(object textureFile, LateBindingApi.OWC10Api.Enums.ChartTextureFormatEnum textureFormat, Double stackUnit, LateBindingApi.OWC10Api.Enums.ChartTexturePlacementEnum texturePlacement)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(textureFile, textureFormat, stackUnit, texturePlacement);
			Invoker.Method(this, "SetTextured", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="GradientStyle">LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="GradientDegree">Double GradientDegree</param>
		/// <param name="Color">optional object Color</param>
		[SupportByLibrary("XWC1.0")]
		public void SetOneColorGradient(LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, Double gradientDegree, object color)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, gradientDegree, color);
			Invoker.Method(this, "SetOneColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="GradientStyle">LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="GradientDegree">Double GradientDegree</param>
		[SupportByLibrary("XWC1.0")]
		public void SetOneColorGradient(LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, Double gradientDegree)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, gradientDegree);
			Invoker.Method(this, "SetOneColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="Color">optional object Color</param>
		[SupportByLibrary("XWC1.0")]
		public void SetSolid(object color)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(color);
			Invoker.Method(this, "SetSolid", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		[SupportByLibrary("XWC1.0")]
		public void SetSolid()
		{
			object[] paramsArray = null;
			Invoker.Method(this, "SetSolid", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="GradientStyle">LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		/// <param name="Color">optional object Color</param>
		/// <param name="BackColor">optional object BackColor</param>
		[SupportByLibrary("XWC1.0")]
		public void SetTwoColorGradient(LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant, object color, object backColor)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant, color, backColor);
			Invoker.Method(this, "SetTwoColorGradient", paramsArray);
		}

		/// <summary>
		/// SupportByLibrary XWC1.0 
		/// </summary>
		/// <param name="GradientStyle">LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum GradientStyle</param>
		/// <param name="GradientVariant">LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum GradientVariant</param>
		[SupportByLibrary("XWC1.0")]
		public void SetTwoColorGradient(LateBindingApi.OWC10Api.Enums.ChartGradientStyleEnum gradientStyle, LateBindingApi.OWC10Api.Enums.ChartGradientVariantEnum gradientVariant)
		{
			object[] paramsArray = Invoker.ValidateParamsArray(gradientStyle, gradientVariant);
			Invoker.Method(this, "SetTwoColorGradient", paramsArray);
		}

		#endregion
		#pragma warning restore
	}
}