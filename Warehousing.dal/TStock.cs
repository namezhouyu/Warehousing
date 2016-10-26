/**  版本信息模板在安装目录下，可自行修改。
* TStock.cs
*
* 功 能： N/A
* 类 名： TStock
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
using System.Data;
using System.Text;
using System.Data.SQLite;
using Warehousing.model;
namespace Warehousing.dal
{
	/// <summary>
	/// 数据访问类:TStock
	/// </summary>
	public partial class TStock
	{
		public TStock()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQLite.GetMaxID("id", "TStock"); 
		}


		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TStock");
			strSql.Append(" where id='"+id+"'");
			return DbHelperSQLite.Exists(strSql.ToString());
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Warehousing.model.TStock model)
		{
			StringBuilder strSql=new StringBuilder();
			StringBuilder strSql1=new StringBuilder();
			StringBuilder strSql2=new StringBuilder();
			if (model.id != "")
			{
				strSql1.Append("id,");
				strSql2.Append(""+model.id+",");
			}
			if (model.code != null)
			{
				strSql1.Append("code,");
				strSql2.Append("'"+model.code+"',");
			}
			if (model.name != null)
			{
				strSql1.Append("name,");
				strSql2.Append("'"+model.name+"',");
			}
			if (model.spec != null)
			{
				strSql1.Append("spec,");
				strSql2.Append("'"+model.spec+"',");
			}
			if (model.unit != null)
			{
				strSql1.Append("unit,");
				strSql2.Append("'"+model.unit+"',");
			}
			if (model.price != null)
			{
				strSql1.Append("price,");
				strSql2.Append(""+model.price+",");
			}
			if (model.number != null)
			{
				strSql1.Append("number,");
				strSql2.Append(""+model.number+",");
			}
			strSql.Append("insert into TStock(");
			strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
			strSql.Append(")");
			strSql.Append(" values (");
			strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
			strSql.Append(")");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Warehousing.model.TStock model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TStock set ");
			if (model.code != null)
			{
				strSql.Append("code='"+model.code+"',");
			}
			else
			{
				strSql.Append("code= null ,");
			}
			if (model.name != null)
			{
				strSql.Append("name='"+model.name+"',");
			}
			else
			{
				strSql.Append("name= null ,");
			}
			if (model.spec != null)
			{
				strSql.Append("spec='"+model.spec+"',");
			}
			else
			{
				strSql.Append("spec= null ,");
			}
			if (model.unit != null)
			{
				strSql.Append("unit='"+model.unit+"',");
			}
			else
			{
				strSql.Append("unit= null ,");
			}
			if (model.price != null)
			{
				strSql.Append("price="+model.price+",");
			}
			else
			{
				strSql.Append("price= null ,");
			}
			if (model.number != null)
			{
				strSql.Append("number="+model.number+",");
			}
			else
			{
				strSql.Append("number= null ,");
			}
			int n = strSql.ToString().LastIndexOf(",");
			strSql.Remove(n, 1);
			strSql.Append(" where id="+ model.id+" ");
			int rowsAffected=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TStock ");
			strSql.Append(" where id="+id+" " );
			int rowsAffected=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rowsAffected > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TStock ");
			strSql.Append(" where id in ("+idlist + ")  ");
			int rows=DbHelperSQLite.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Warehousing.model.TStock GetModel(string id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  ");
			strSql.Append(" id,code,name,spec,unit,price,number ");
			strSql.Append(" from TStock ");
			strSql.Append(" where id='"+id+"'" );
			Warehousing.model.TStock model=new Warehousing.model.TStock();
			DataSet ds=DbHelperSQLite.Query(strSql.ToString());
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Warehousing.model.TStock DataRowToModel(DataRow row)
		{
			Warehousing.model.TStock model=new Warehousing.model.TStock();
			if (row != null)
			{
				if(row["id"]!=null && row["id"].ToString()!="")
				{
					model.id=row["id"].ToString();
				}
				if(row["code"]!=null)
				{
					model.code=row["code"].ToString();
				}
				if(row["name"]!=null)
				{
					model.name=row["name"].ToString();
				}
				if(row["spec"]!=null)
				{
					model.spec=row["spec"].ToString();
				}
				if(row["unit"]!=null)
				{
					model.unit=row["unit"].ToString();
				}
				if(row["price"]!=null && row["price"].ToString()!="")
				{
					model.price=decimal.Parse(row["price"].ToString());
				}
				if(row["number"]!=null && row["number"].ToString()!="")
				{
					model.number=int.Parse(row["number"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select id,code,name,spec,unit,price,number ");
			strSql.Append(" FROM TStock ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM TStock ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQLite.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.id desc");
			}
			strSql.Append(")AS Row, T.*  from TStock T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQLite.Query(strSql.ToString());
		}

		/*
		*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

