// <fileinfo name="pl_objectCollection_Base.cs">
//		<copyright>
//			All rights reserved.
//		</copyright>
//		<remarks>
//			Do not change this source code manually. Changes to this file may 
//			cause incorrect behavior and will be lost if the code is regenerated.
//		</remarks>
//		<generator rewritefile="True" infourl="http://www.SharpPower.com">RapTier</generator>
// </fileinfo>

using System;
using System.Data;
using System.Data.SqlClient;

namespace Internship2024
{
	/// <summary>
	/// The base class for <see cref="pl_objectCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="pl_objectCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_object
	{
		// Constants
		public const string Table_pidColumnName = "table_pid";
		public const string Table_nameColumnName = "table_name";
		public const string NameColumnName = "name";
		public const string Created_dateColumnName = "created_date";
		public const string Created_byColumnName = "created_by";
		public const string Modified_dateColumnName = "modified_date";
		public const string Modified_byColumnName = "modified_by";
		public const string Deleted_dateColumnName = "deleted_date";
		public const string Deleted_byColumnName = "deleted_by";

		// Instance fields
		private Internship2024DB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_object"/> 
		/// class with the specified <see cref="Internship2024DB"/>.
		/// </summary>
		/// <param name="db">The <see cref="Internship2024DB"/> object.</param>
		public pl_object(Internship2024DB db)
		{
			_db = db;
		}

		/// <summary>
		/// Gets the database object that this table belongs to.
		///	</summary>
		///	<value>The <see cref="Internship2024DB"/> object.</value>
		protected Internship2024DB Database
		{
			get { return _db; }
		}

		/// <summary>
		/// Gets an array of all records from the <c>pl_object</c> table.
		/// </summary>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		public virtual pl_objectRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>pl_object</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>pl_object</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.pl_object_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="pl_objectRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="pl_objectRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public pl_objectRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			pl_objectRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="pl_objectRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		public pl_objectRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="pl_objectRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example:
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		public virtual pl_objectRow[] GetAsArray(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecords(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public DataTable GetAsDataTable(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsDataTable(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object filled with data that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <param name="startIndex">The index of the first record to return.</param>
		/// <param name="length">The number of records to return.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAsDataTable(string whereSql, string orderBySql,
							int startIndex, int length, ref int totalRecordCount)
		{
			using(SqlDataReader reader = _db.ExecuteReader(CreateGetCommand(whereSql, orderBySql)))
			{
				return MapRecordsToDataTable(reader, startIndex, length, ref totalRecordCount);
			}
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object for the specified search criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: "FirstName='Smith' AND Zip=75038".</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: "LastName ASC, FirstName ASC".</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetCommand(string whereSql, string orderBySql)
		{
			string sql = "SELECT * FROM [dbo].[pl_object]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="pl_objectRow"/> by the primary key.
		/// </summary>
		/// <param name="table_pid">The <c>table_pid</c> column value.</param>
		/// <returns>An instance of <see cref="pl_objectRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual pl_objectRow GetByPrimaryKey(long table_pid)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_object_GetByPrimaryKey", true);
			AddParameter(cmd, "Table_pid", table_pid);
			pl_objectRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>pl_object</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_objectRow"/> object to be inserted.</param>
		public virtual long Insert(pl_objectRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_object_Insert", true);
			AddParameter(cmd, "Table_name", value.Table_name);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Created_date",
				value.IsCreated_dateNull ? DBNull.Value : (object)value.Created_date);
			AddParameter(cmd, "Created_by",
				value.IsCreated_byNull ? DBNull.Value : (object)value.Created_by);
			AddParameter(cmd, "Modified_date",
				value.IsModified_dateNull ? DBNull.Value : (object)value.Modified_date);
			AddParameter(cmd, "Modified_by",
				value.IsModified_byNull ? DBNull.Value : (object)value.Modified_by);
			AddParameter(cmd, "Deleted_date",
				value.IsDeleted_dateNull ? DBNull.Value : (object)value.Deleted_date);
			AddParameter(cmd, "Deleted_by",
				value.IsDeleted_byNull ? DBNull.Value : (object)value.Deleted_by);
			value.Table_pid = Convert.ToInt64(cmd.ExecuteScalar());
			return value.Table_pid;
		}

		/// <summary>
		/// Updates a record in the <c>pl_object</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_objectRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(pl_objectRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_object_Update", true);
			AddParameter(cmd, "Table_name", value.Table_name);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Created_date",
				value.IsCreated_dateNull ? DBNull.Value : (object)value.Created_date);
			AddParameter(cmd, "Created_by",
				value.IsCreated_byNull ? DBNull.Value : (object)value.Created_by);
			AddParameter(cmd, "Modified_date",
				value.IsModified_dateNull ? DBNull.Value : (object)value.Modified_date);
			AddParameter(cmd, "Modified_by",
				value.IsModified_byNull ? DBNull.Value : (object)value.Modified_by);
			AddParameter(cmd, "Deleted_date",
				value.IsDeleted_dateNull ? DBNull.Value : (object)value.Deleted_date);
			AddParameter(cmd, "Deleted_by",
				value.IsDeleted_byNull ? DBNull.Value : (object)value.Deleted_by);
			AddParameter(cmd, "Table_pid", value.Table_pid);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>pl_object</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>pl_object</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
		/// argument when your code calls this method in an ADO.NET transaction context. Note that in 
		/// this case, after you call the Update method you need call either <c>AcceptChanges</c> 
		/// or <c>RejectChanges</c> method on the DataTable object.
		/// <code>
		/// MyDb db = new MyDb();
		/// try
		/// {
		///		db.BeginTransaction();
		///		db.MyCollection.Update(myDataTable, false);
		///		db.CommitTransaction();
		///		myDataTable.AcceptChanges();
		/// }
		/// catch(Exception)
		/// {
		///		db.RollbackTransaction();
		///		myDataTable.RejectChanges();
		/// }
		/// </code>
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		/// <param name="acceptChanges">Specifies whether this method calls the <c>AcceptChanges</c>
		/// method on the changed DataRow objects.</param>
		public virtual void Update(DataTable table, bool acceptChanges)
		{
			DataRowCollection rows = table.Rows;
			for(int i = rows.Count - 1; i >= 0; i--)
			{
				DataRow row = rows[i];
				switch(row.RowState)
				{
					case DataRowState.Added:
						Insert(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;

					case DataRowState.Deleted:
						// Temporary reject changes to be able to access to the PK column(s)
						row.RejectChanges();
						try
						{
							DeleteByPrimaryKey((long)row["Table_pid"]);
						}
						finally
						{
							row.Delete();
						}
						if(acceptChanges)
							row.AcceptChanges();
						break;
						
					case DataRowState.Modified:
						Update(MapRow(row));
						if(acceptChanges)
							row.AcceptChanges();
						break;
				}
			}
		}

		/// <summary>
		/// Deletes the specified object from the <c>pl_object</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_objectRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(pl_objectRow value)
		{
			return DeleteByPrimaryKey(value.Table_pid);
		}

		/// <summary>
		/// Deletes a record from the <c>pl_object</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="table_pid">The <c>table_pid</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long table_pid)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_object_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Table_pid", table_pid);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>pl_object</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>The number of deleted records.</returns>
		public int Delete(string whereSql)
		{
			return CreateDeleteCommand(whereSql).ExecuteNonQuery();
		}

		/// <summary>
		/// Creates an <see cref="System.Data.SqlCommand"/> object that can be used 
		/// to delete <c>pl_object</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[pl_object]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>pl_object</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.pl_object_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		protected pl_objectRow[] MapRecords(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecords(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		protected pl_objectRow[] MapRecords(SqlDataReader reader)
		{
			int totalRecordCount = -1;
			return MapRecords(reader, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to map.</param>
		/// <param name="length">The number of records to map.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>An array of <see cref="pl_objectRow"/> objects.</returns>
		protected virtual pl_objectRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int table_pidColumnIndex = reader.GetOrdinal("table_pid");
			int table_nameColumnIndex = reader.GetOrdinal("table_name");
			int nameColumnIndex = reader.GetOrdinal("name");
			int created_dateColumnIndex = reader.GetOrdinal("created_date");
			int created_byColumnIndex = reader.GetOrdinal("created_by");
			int modified_dateColumnIndex = reader.GetOrdinal("modified_date");
			int modified_byColumnIndex = reader.GetOrdinal("modified_by");
			int deleted_dateColumnIndex = reader.GetOrdinal("deleted_date");
			int deleted_byColumnIndex = reader.GetOrdinal("deleted_by");

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					pl_objectRow record = new pl_objectRow();
					recordList.Add(record);

					record.Table_pid = Convert.ToInt64(reader.GetValue(table_pidColumnIndex));
					record.Table_name = Convert.ToString(reader.GetValue(table_nameColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(created_dateColumnIndex))
						record.Created_date = Convert.ToDateTime(reader.GetValue(created_dateColumnIndex));
					if(!reader.IsDBNull(created_byColumnIndex))
						record.Created_by = Convert.ToInt64(reader.GetValue(created_byColumnIndex));
					if(!reader.IsDBNull(modified_dateColumnIndex))
						record.Modified_date = Convert.ToDateTime(reader.GetValue(modified_dateColumnIndex));
					if(!reader.IsDBNull(modified_byColumnIndex))
						record.Modified_by = Convert.ToInt64(reader.GetValue(modified_byColumnIndex));
					if(!reader.IsDBNull(deleted_dateColumnIndex))
						record.Deleted_date = Convert.ToDateTime(reader.GetValue(deleted_dateColumnIndex));
					if(!reader.IsDBNull(deleted_byColumnIndex))
						record.Deleted_by = Convert.ToInt64(reader.GetValue(deleted_byColumnIndex));

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (pl_objectRow[])(recordList.ToArray(typeof(pl_objectRow)));
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlCommand command)
		{
			using(SqlDataReader reader = _db.ExecuteReader(command))
			{
				return MapRecordsToDataTable(reader);
			}
		}

		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected DataTable MapRecordsToDataTable(SqlDataReader reader)
		{
			int totalRecordCount = 0;
			return MapRecordsToDataTable(reader, 0, int.MaxValue, ref totalRecordCount);
		}
		
		/// <summary>
		/// Reads data from the provided data reader and returns 
		/// a filled <see cref="System.Data.DataTable"/> object.
		/// </summary>
		/// <param name="reader">The <see cref="System.Data.SqlDataReader"/> object to read data from the table.</param>
		/// <param name="startIndex">The index of the first record to read.</param>
		/// <param name="length">The number of records to read.</param>
		/// <param name="totalRecordCount">A reference parameter that returns the total number 
		/// of records in the reader object if 0 was passed into the method; otherwise it returns -1.</param>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable MapRecordsToDataTable(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int columnCount = reader.FieldCount;
			int ri = -startIndex;
			
			DataTable dataTable = CreateDataTable();
			dataTable.BeginLoadData();
			object[] values = new object[columnCount];

			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					reader.GetValues(values);
					dataTable.LoadDataRow(values, true);

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}
			dataTable.EndLoadData();

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return dataTable;
		}

		/// <summary>
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="pl_objectRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="pl_objectRow"/> object.</returns>
		protected virtual pl_objectRow MapRow(DataRow row)
		{
			pl_objectRow mappedObject = new pl_objectRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Table_pid"
			dataColumn = dataTable.Columns["Table_pid"];
			if(!row.IsNull(dataColumn))
				mappedObject.Table_pid = (long)row[dataColumn];
			// Column "Table_name"
			dataColumn = dataTable.Columns["Table_name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Table_name = (string)row[dataColumn];
			// Column "Name"
			dataColumn = dataTable.Columns["Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Name = (string)row[dataColumn];
			// Column "Created_date"
			dataColumn = dataTable.Columns["Created_date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_date = (System.DateTime)row[dataColumn];
			// Column "Created_by"
			dataColumn = dataTable.Columns["Created_by"];
			if(!row.IsNull(dataColumn))
				mappedObject.Created_by = (long)row[dataColumn];
			// Column "Modified_date"
			dataColumn = dataTable.Columns["Modified_date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Modified_date = (System.DateTime)row[dataColumn];
			// Column "Modified_by"
			dataColumn = dataTable.Columns["Modified_by"];
			if(!row.IsNull(dataColumn))
				mappedObject.Modified_by = (long)row[dataColumn];
			// Column "Deleted_date"
			dataColumn = dataTable.Columns["Deleted_date"];
			if(!row.IsNull(dataColumn))
				mappedObject.Deleted_date = (System.DateTime)row[dataColumn];
			// Column "Deleted_by"
			dataColumn = dataTable.Columns["Deleted_by"];
			if(!row.IsNull(dataColumn))
				mappedObject.Deleted_by = (long)row[dataColumn];
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>pl_object</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "pl_object";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Table_pid", typeof(long));
			dataColumn.Caption = "table_pid";
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Table_name", typeof(string));
			dataColumn.Caption = "table_name";
			dataColumn.MaxLength = 100;
			dataColumn.AllowDBNull = false;
			dataColumn = dataTable.Columns.Add("Name", typeof(string));
			dataColumn.Caption = "name";
			dataColumn.MaxLength = 1000;
			dataColumn = dataTable.Columns.Add("Created_date", typeof(System.DateTime));
			dataColumn.Caption = "created_date";
			dataColumn = dataTable.Columns.Add("Created_by", typeof(long));
			dataColumn.Caption = "created_by";
			dataColumn = dataTable.Columns.Add("Modified_date", typeof(System.DateTime));
			dataColumn.Caption = "modified_date";
			dataColumn = dataTable.Columns.Add("Modified_by", typeof(long));
			dataColumn.Caption = "modified_by";
			dataColumn = dataTable.Columns.Add("Deleted_date", typeof(System.DateTime));
			dataColumn.Caption = "deleted_date";
			dataColumn = dataTable.Columns.Add("Deleted_by", typeof(long));
			dataColumn.Caption = "deleted_by";
			return dataTable;
		}
		
		/// <summary>
		/// Adds a new parameter to the specified command.
		/// </summary>
		/// <param name="cmd">The <see cref="System.Data.SqlCommand"/> object to add the parameter to.</param>
		/// <param name="paramName">The name of the parameter.</param>
		/// <param name="value">The value of the parameter.</param>
		/// <returns>A reference to the added parameter.</returns>
		protected virtual SqlParameter AddParameter(SqlCommand cmd, string paramName, object value)
		{
			SqlParameter parameter;
			switch(paramName)
			{
				case "Table_pid":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Table_name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Created_date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Created_by":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Modified_date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Modified_by":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Deleted_date":
					parameter = _db.AddParameter(cmd, paramName, DbType.DateTime, value);
					break;

				case "Deleted_by":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of pl_objectCollection_Base class
}  // End of namespace
