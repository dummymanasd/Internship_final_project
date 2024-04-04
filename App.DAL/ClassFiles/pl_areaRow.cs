// <fileinfo name="pl_areaRow_Base.cs">
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

namespace Internship2024
{
	/// <summary>
	/// The base class for <see cref="pl_areaRow"/> that 
	/// represents a record in the <c>pl_area</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_areaRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class pl_areaRow
	{
		private long _id;
		private long _table_pid;
		private bool _table_pidNull = true;
		private string _name;
		private string _unique_code;
		private string _area_code;
		private string _description;
		private bool _is_for_dispensing;
		private bool _is_for_dispensingNull = true;
		private long _department_id;
		private bool _department_idNull = true;
		private bool _status;
		private bool _statusNull = true;
		

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_areaRow"/> class.
		/// </summary>
		public pl_areaRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>id</c> column value.
		/// </summary>
		/// <value>The <c>id</c> column value.</value>
		public long Id
		{
			get { return _id; }
			set { _id = value; }
		}

		/// <summary>
		/// Gets or sets the <c>table_pid</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>table_pid</c> column value.</value>
		public long Table_pid
		{
			get
			{
				if(IsTable_pidNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _table_pid;
			}
			set
			{
				_table_pidNull = false;
				_table_pid = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Table_pid"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsTable_pidNull
		{
			get { return _table_pidNull; }
			set { _table_pidNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>name</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>name</c> column value.</value>
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		/// <summary>
		/// Gets or sets the <c>unique_code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>unique_code</c> column value.</value>
		public string Unique_code
		{
			get { return _unique_code; }
			set { _unique_code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>area_code</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>area_code</c> column value.</value>
		public string Area_code
		{
			get { return _area_code; }
			set { _area_code = value; }
		}

		/// <summary>
		/// Gets or sets the <c>description</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>description</c> column value.</value>
		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		/// <summary>
		/// Gets or sets the <c>is_for_dispensing</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>is_for_dispensing</c> column value.</value>
		public bool Is_for_dispensing
		{
			get
			{
				if(IsIs_for_dispensingNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _is_for_dispensing;
			}
			set
			{
				_is_for_dispensingNull = false;
				_is_for_dispensing = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Is_for_dispensing"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsIs_for_dispensingNull
		{
			get { return _is_for_dispensingNull; }
			set { _is_for_dispensingNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>department_id</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>department_id</c> column value.</value>
		public long Department_id
		{
			get
			{
				if(IsDepartment_idNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _department_id;
			}
			set
			{
				_department_idNull = false;
				_department_id = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Department_id"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDepartment_idNull
		{
			get { return _department_idNull; }
			set { _department_idNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>status</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>status</c> column value.</value>
		public bool Status
		{
			get
			{
				if(IsStatusNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _status;
			}
			set
			{
				_statusNull = false;
				_status = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Status"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsStatusNull
		{
			get { return _statusNull; }
			set { _statusNull = value; }
		}

		/// <summary>
		

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Id=");
			dynStr.Append(Id);
			dynStr.Append("  Table_pid=");
			dynStr.Append(IsTable_pidNull ? (object)"<NULL>" : Table_pid);
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Unique_code=");
			dynStr.Append(Unique_code);
			dynStr.Append("  Area_code=");
			dynStr.Append(Area_code);
			dynStr.Append("  Description=");
			dynStr.Append(Description);
			dynStr.Append("  Is_for_dispensing=");
			dynStr.Append(IsIs_for_dispensingNull ? (object)"<NULL>" : Is_for_dispensing);
			dynStr.Append("  Department_id=");
			dynStr.Append(IsDepartment_idNull ? (object)"<NULL>" : Department_id);
			dynStr.Append("  Status=");
			dynStr.Append(IsStatusNull ? (object)"<NULL>" : Status);
			
			return dynStr.ToString();
		}
	} // End of pl_areaRow_Base class
} // End of namespace
