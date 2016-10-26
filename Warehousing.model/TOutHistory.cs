/**  版本信息模板在安装目录下，可自行修改。
* TOutHistory.cs
*
* 功 能： N/A
* 类 名： TOutHistory
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/10/23 20:12:05   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Warehousing.model
{
	/// <summary>
	/// TOutHistory:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TOutHistory
	{
		public TOutHistory()
		{}
		#region Model
		private int _id;
		private int _goodid;
		private int _number;
		private DateTime _datetime;
		private string _operator;
		/// <summary>
		/// 
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int goodId
		{
			set{ _goodid=value;}
			get{return _goodid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int number
		{
			set{ _number=value;}
			get{return _number;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime dateTime
		{
			set{ _datetime=value;}
			get{return _datetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string operators
		{
			set{ _operator=value;}
			get{return _operator;}
		}
		#endregion Model

	}
}

