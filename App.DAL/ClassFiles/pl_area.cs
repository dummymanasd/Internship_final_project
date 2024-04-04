// <fileinfo name="pl_areaCollection_Base.cs">
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
	/// The base class for <see cref="pl_areaCollection"/>. Provides methods 
	/// for common database table operations. 
	/// </summary>
	/// <remarks>
	/// Do not change this source code. Update the <see cref="pl_areaCollection"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class pl_area
	{
		// Constants
		public const string IdColumnName = "id";
		public const string Table_pidColumnName = "table_pid";
		public const string NameColumnName = "name";
		public const string Unique_codeColumnName = "unique_code";
		public const string Area_codeColumnName = "area_code";
		public const string DescriptionColumnName = "description";
		public const string Is_for_dispensingColumnName = "is_for_dispensing";
		public const string Department_idColumnName = "department_id";
		public const string StatusColumnName = "status";
		

		// Instance fields
		private Internship2024DB _db;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_area"/> 
		/// class with the specified <see cref="Internship2024DB"/>.
		/// </summary>
		/// <param name="db">The <see cref="Internship2024DB"/> object.</param>
		public pl_area(Internship2024DB db)
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
		/// Gets an array of all records from the <c>pl_area</c> table.
		/// </summary>
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		public virtual pl_areaRow[] GetAll()
		{
			return MapRecords(CreateGetAllCommand());
		}

		/// <summary>
		/// Gets a <see cref="System.Data.DataTable"/> object that 
		/// includes all records from the <c>pl_area</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		public virtual DataTable GetAllAsDataTable()
		{
			return MapRecordsToDataTable(CreateGetAllCommand());
		}

		/// <summary>
		/// Creates and returns an <see cref="System.Data.SqlCommand"/> object that is used
		/// to retrieve all records from the <c>pl_area</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateGetAllCommand()
		{
			return _db.CreateCommand("dbo.pl_area_GetAll", true);
		}

		/// <summary>
		/// Gets the first <see cref="pl_areaRow"/> objects that 
		/// match the search condition.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>An instance of <see cref="pl_areaRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public pl_areaRow GetRow(string whereSql)
		{
			int totalRecordCount = -1;
			pl_areaRow[] rows = GetAsArray(whereSql, null, 0, 1, ref totalRecordCount);
			return 0 == rows.Length ? null : rows[0];
		}

		/// <summary>
		/// Gets an array of <see cref="pl_areaRow"/> objects that 
		/// match the search condition, in the the specified sort order.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. For example: 
		/// <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <param name="orderBySql">The column name(s) followed by "ASC" (ascending) or "DESC" (descending).
		/// Columns are sorted in ascending order by default. For example: <c>"LastName ASC, FirstName ASC"</c>.</param>
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		public pl_areaRow[] GetAsArray(string whereSql, string orderBySql)
		{
			int totalRecordCount = -1;
			return GetAsArray(whereSql, orderBySql, 0, int.MaxValue, ref totalRecordCount);
		}

		/// <summary>
		/// Gets an array of <see cref="pl_areaRow"/> objects that 
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
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		public virtual pl_areaRow[] GetAsArray(string whereSql, string orderBySql,
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
			string sql = "SELECT * FROM [dbo].[pl_area]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			if(null != orderBySql && 0 < orderBySql.Length)
				sql += " ORDER BY " + orderBySql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Gets <see cref="pl_areaRow"/> by the primary key.
		/// </summary>
		/// <param name="id">The <c>id</c> column value.</param>
		/// <returns>An instance of <see cref="pl_areaRow"/> or null reference 
		/// (Nothing in Visual Basic) if the object was not found.</returns>
		public virtual pl_areaRow GetByPrimaryKey(long id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_area_GetByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			pl_areaRow[] tempArray = MapRecords(cmd);
			return 0 == tempArray.Length ? null : tempArray[0];
		}

		/// <summary>
		/// Adds a new record into the <c>pl_area</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_areaRow"/> object to be inserted.</param>
		public virtual void Insert(pl_areaRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_area_Insert", true);
			AddParameter(cmd, "Table_pid",
				value.IsTable_pidNull ? DBNull.Value : (object)value.Table_pid);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Unique_code", value.Unique_code);
			AddParameter(cmd, "Area_code", value.Area_code);
			AddParameter(cmd, "Description", value.Description);
			AddParameter(cmd, "Is_for_dispensing",
				value.IsIs_for_dispensingNull ? DBNull.Value : (object)value.Is_for_dispensing);
			AddParameter(cmd, "Department_id",
				value.IsDepartment_idNull ? DBNull.Value : (object)value.Department_id);
			AddParameter(cmd, "Status",
				value.IsStatusNull ? DBNull.Value : (object)value.Status);
			
			value.Id = Convert.ToInt64(cmd.ExecuteScalar());
		}

		/// <summary>
		/// Updates a record in the <c>pl_area</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_areaRow"/>
		/// object used to update the table record.</param>
		/// <returns>true if the record was updated; otherwise, false.</returns>
		public virtual bool Update(pl_areaRow value)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_area_Update", true);
			AddParameter(cmd, "Table_pid",
				value.IsTable_pidNull ? DBNull.Value : (object)value.Table_pid);
			AddParameter(cmd, "Name", value.Name);
			AddParameter(cmd, "Unique_code", value.Unique_code);
			AddParameter(cmd, "Area_code", value.Area_code);
			AddParameter(cmd, "Description", value.Description);
			AddParameter(cmd, "Is_for_dispensing",
				value.IsIs_for_dispensingNull ? DBNull.Value : (object)value.Is_for_dispensing);
			AddParameter(cmd, "Department_id",
				value.IsDepartment_idNull ? DBNull.Value : (object)value.Department_id);
			AddParameter(cmd, "Status",
				value.IsStatusNull ? DBNull.Value : (object)value.Status);
			
			AddParameter(cmd, "Id", value.Id);
			return 0 != cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Updates the <c>pl_area</c> table and calls the <c>AcceptChanges</c> method
		/// on the changed DataRow objects.
		/// </summary>
		/// <param name="table">The <see cref="System.Data.DataTable"/> used to update the data source.</param>
		public void Update(DataTable table)
		{
			Update(table, true);
		}

		/// <summary>
		/// Updates the <c>pl_area</c> table. Pass <c>false</c> as the <c>acceptChanges</c> 
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
							DeleteByPrimaryKey((long)row["Id"]);
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
		/// Deletes the specified object from the <c>pl_area</c> table.
		/// </summary>
		/// <param name="value">The <see cref="pl_areaRow"/> object to delete.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public bool Delete(pl_areaRow value)
		{
			return DeleteByPrimaryKey(value.Id);
		}

		/// <summary>
		/// Deletes a record from the <c>pl_area</c> table using
		/// the specified primary key.
		/// </summary>
		/// <param name="id">The <c>id</c> column value.</param>
		/// <returns>true if the record was deleted; otherwise, false.</returns>
		public virtual bool DeleteByPrimaryKey(long id)
		{
			SqlCommand cmd = _db.CreateCommand("dbo.pl_area_DeleteByPrimaryKey", true);
			AddParameter(cmd, "Id", id);
			return 0 < cmd.ExecuteNonQuery();
		}

		/// <summary>
		/// Deletes <c>pl_area</c> records that match the specified criteria.
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
		/// to delete <c>pl_area</c> records that match the specified criteria.
		/// </summary>
		/// <param name="whereSql">The SQL search condition. 
		/// For example: <c>"FirstName='Smith' AND Zip=75038"</c>.</param>
		/// <returns>A reference to the <see cref="System.Data.SqlCommand"/> object.</returns>
		protected virtual SqlCommand CreateDeleteCommand(string whereSql)
		{
			string sql = "DELETE FROM [dbo].[pl_area]";
			if(null != whereSql && 0 < whereSql.Length)
				sql += " WHERE " + whereSql;
			return _db.CreateCommand(sql);
		}

		/// <summary>
		/// Deletes all records from the <c>pl_area</c> table.
		/// </summary>
		/// <returns>The number of deleted records.</returns>
		public int DeleteAll()
		{
			return _db.CreateCommand("dbo.pl_area_DeleteAll", true).ExecuteNonQuery();
		}

		/// <summary>
		/// Reads data using the specified command and returns 
		/// an array of mapped objects.
		/// </summary>
		/// <param name="command">The <see cref="System.Data.SqlCommand"/> object.</param>
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		protected pl_areaRow[] MapRecords(SqlCommand command)
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
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		protected pl_areaRow[] MapRecords(SqlDataReader reader)
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
		/// <returns>An array of <see cref="pl_areaRow"/> objects.</returns>
		protected virtual pl_areaRow[] MapRecords(SqlDataReader reader, 
										int startIndex, int length, ref int totalRecordCount)
		{
			if(0 > startIndex)
				throw new ArgumentOutOfRangeException("startIndex", startIndex, "StartIndex cannot be less than zero.");
			if(0 > length)
				throw new ArgumentOutOfRangeException("length", length, "Length cannot be less than zero.");

			int idColumnIndex = reader.GetOrdinal("id");
			int table_pidColumnIndex = reader.GetOrdinal("table_pid");
			int nameColumnIndex = reader.GetOrdinal("name");
			int unique_codeColumnIndex = reader.GetOrdinal("unique_code");
			int area_codeColumnIndex = reader.GetOrdinal("area_code");
			int descriptionColumnIndex = reader.GetOrdinal("description");
			int is_for_dispensingColumnIndex = reader.GetOrdinal("is_for_dispensing");
			int department_idColumnIndex = reader.GetOrdinal("department_id");
			int statusColumnIndex = reader.GetOrdinal("status");
			

			System.Collections.ArrayList recordList = new System.Collections.ArrayList();
			int ri = -startIndex;
			while(reader.Read())
			{
				ri++;
				if(ri > 0 && ri <= length)
				{
					pl_areaRow record = new pl_areaRow();
					recordList.Add(record);

					record.Id = Convert.ToInt64(reader.GetValue(idColumnIndex));
					if(!reader.IsDBNull(table_pidColumnIndex))
						record.Table_pid = Convert.ToInt64(reader.GetValue(table_pidColumnIndex));
					if(!reader.IsDBNull(nameColumnIndex))
						record.Name = Convert.ToString(reader.GetValue(nameColumnIndex));
					if(!reader.IsDBNull(unique_codeColumnIndex))
						record.Unique_code = Convert.ToString(reader.GetValue(unique_codeColumnIndex));
					if(!reader.IsDBNull(area_codeColumnIndex))
						record.Area_code = Convert.ToString(reader.GetValue(area_codeColumnIndex));
					if(!reader.IsDBNull(descriptionColumnIndex))
						record.Description = Convert.ToString(reader.GetValue(descriptionColumnIndex));
					if(!reader.IsDBNull(is_for_dispensingColumnIndex))
						record.Is_for_dispensing = Convert.ToBoolean(reader.GetValue(is_for_dispensingColumnIndex));
					if(!reader.IsDBNull(department_idColumnIndex))
						record.Department_id = Convert.ToInt64(reader.GetValue(department_idColumnIndex));
					if(!reader.IsDBNull(statusColumnIndex))
						record.Status = Convert.ToBoolean(reader.GetValue(statusColumnIndex));
				

					if(ri == length && 0 != totalRecordCount)
						break;
				}
			}

			totalRecordCount = 0 == totalRecordCount ? ri + startIndex : -1;
			return (pl_areaRow[])(recordList.ToArray(typeof(pl_areaRow)));
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
		/// Converts <see cref="System.Data.DataRow"/> to <see cref="pl_areaRow"/>.
		/// </summary>
		/// <param name="row">The <see cref="System.Data.DataRow"/> object to be mapped.</param>
		/// <returns>A reference to the <see cref="pl_areaRow"/> object.</returns>
		protected virtual pl_areaRow MapRow(DataRow row)
		{
			pl_areaRow mappedObject = new pl_areaRow();
			DataTable dataTable = row.Table;
			DataColumn dataColumn;
			// Column "Id"
			dataColumn = dataTable.Columns["Id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Id = (long)row[dataColumn];
			// Column "Table_pid"
			dataColumn = dataTable.Columns["Table_pid"];
			if(!row.IsNull(dataColumn))
				mappedObject.Table_pid = (long)row[dataColumn];
			// Column "Name"
			dataColumn = dataTable.Columns["Name"];
			if(!row.IsNull(dataColumn))
				mappedObject.Name = (string)row[dataColumn];
			// Column "Unique_code"
			dataColumn = dataTable.Columns["Unique_code"];
			if(!row.IsNull(dataColumn))
				mappedObject.Unique_code = (string)row[dataColumn];
			// Column "Area_code"
			dataColumn = dataTable.Columns["Area_code"];
			if(!row.IsNull(dataColumn))
				mappedObject.Area_code = (string)row[dataColumn];
			// Column "Description"
			dataColumn = dataTable.Columns["Description"];
			if(!row.IsNull(dataColumn))
				mappedObject.Description = (string)row[dataColumn];
			// Column "Is_for_dispensing"
			dataColumn = dataTable.Columns["Is_for_dispensing"];
			if(!row.IsNull(dataColumn))
				mappedObject.Is_for_dispensing = (bool)row[dataColumn];
			// Column "Department_id"
			dataColumn = dataTable.Columns["Department_id"];
			if(!row.IsNull(dataColumn))
				mappedObject.Department_id = (long)row[dataColumn];
			// Column "Status"
			dataColumn = dataTable.Columns["Status"];
			if(!row.IsNull(dataColumn))
				mappedObject.Status = (bool)row[dataColumn];
		
			return mappedObject;
		}

		/// <summary>
		/// Creates a <see cref="System.Data.DataTable"/> object for 
		/// the <c>pl_area</c> table.
		/// </summary>
		/// <returns>A reference to the <see cref="System.Data.DataTable"/> object.</returns>
		protected virtual DataTable CreateDataTable()
		{
			DataTable dataTable = new DataTable();
			dataTable.TableName = "pl_area";
			DataColumn dataColumn;
			dataColumn = dataTable.Columns.Add("Id", typeof(long));
			dataColumn.Caption = "id";
			dataColumn.AllowDBNull = false;
			dataColumn.ReadOnly = true;
			dataColumn.Unique = true;
			dataColumn.AutoIncrement = true;
			dataColumn = dataTable.Columns.Add("Table_pid", typeof(long));
			dataColumn.Caption = "table_pid";
			dataColumn = dataTable.Columns.Add("Name", typeof(string));
			dataColumn.Caption = "name";
			dataColumn.MaxLength = 50;
			dataColumn = dataTable.Columns.Add("Unique_code", typeof(string));
			dataColumn.Caption = "unique_code";
			dataColumn.MaxLength = 1073741823;
			dataColumn = dataTable.Columns.Add("Area_code", typeof(string));
			dataColumn.Caption = "area_code";
			dataColumn.MaxLength = 1073741823;
			dataColumn = dataTable.Columns.Add("Description", typeof(string));
			dataColumn.Caption = "description";
			dataColumn.MaxLength = 1073741823;
			dataColumn = dataTable.Columns.Add("Is_for_dispensing", typeof(bool));
			dataColumn.Caption = "is_for_dispensing";
			dataColumn = dataTable.Columns.Add("Department_id", typeof(long));
			dataColumn.Caption = "department_id";
			dataColumn = dataTable.Columns.Add("Status", typeof(bool));
			dataColumn.Caption = "status";
			
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
				case "Id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Table_pid":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Name":
					parameter = _db.AddParameter(cmd, paramName, DbType.AnsiString, value);
					break;

				case "Unique_code":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Area_code":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Description":
					parameter = _db.AddParameter(cmd, paramName, DbType.String, value);
					break;

				case "Is_for_dispensing":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				case "Department_id":
					parameter = _db.AddParameter(cmd, paramName, DbType.Int64, value);
					break;

				case "Status":
					parameter = _db.AddParameter(cmd, paramName, DbType.Boolean, value);
					break;

				

				default:
					throw new ArgumentException("Unknown parameter name (" + paramName + ").");
			}
			return parameter;
		}
	} // End of pl_areaCollection_Base class
}  // End of namespace
