// <fileinfo name="pl_objectRow_Base.cs">
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
	/// The base class for <see cref="pl_objectRow"/> that 
	/// represents a record in the <c>pl_object</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_objectRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_objectRow
	{
		private long _table_pid;
		private string _table_name;
		private string _name;
		private System.DateTime _created_date;
		private bool _created_dateNull = true;
		private long _created_by;
		private bool _created_byNull = true;
		private System.DateTime _modified_date;
		private bool _modified_dateNull = true;
		private long _modified_by;
		private bool _modified_byNull = true;
		private System.DateTime _deleted_date;
		private bool _deleted_dateNull = true;
		private long _deleted_by;
		private bool _deleted_byNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_objectRow"/> class.
		/// </summary>
		public pl_objectRow()
		{
			// EMPTY
		}

		/// <summary>
		/// Gets or sets the <c>table_pid</c> column value.
		/// </summary>
		/// <value>The <c>table_pid</c> column value.</value>
		public long Table_pid
		{
			get { return _table_pid; }
			set { _table_pid = value; }
		}

		/// <summary>
		/// Gets or sets the <c>table_name</c> column value.
		/// </summary>
		/// <value>The <c>table_name</c> column value.</value>
		public string Table_name
		{
			get { return _table_name; }
			set { _table_name = value; }
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
		/// Gets or sets the <c>created_date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>created_date</c> column value.</value>
		public System.DateTime Created_date
		{
			get
			{
				if(IsCreated_dateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_date;
			}
			set
			{
				_created_dateNull = false;
				_created_date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_dateNull
		{
			get { return _created_dateNull; }
			set { _created_dateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>created_by</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>created_by</c> column value.</value>
		public long Created_by
		{
			get
			{
				if(IsCreated_byNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _created_by;
			}
			set
			{
				_created_byNull = false;
				_created_by = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Created_by"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsCreated_byNull
		{
			get { return _created_byNull; }
			set { _created_byNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>modified_date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>modified_date</c> column value.</value>
		public System.DateTime Modified_date
		{
			get
			{
				if(IsModified_dateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _modified_date;
			}
			set
			{
				_modified_dateNull = false;
				_modified_date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Modified_date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsModified_dateNull
		{
			get { return _modified_dateNull; }
			set { _modified_dateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>modified_by</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>modified_by</c> column value.</value>
		public long Modified_by
		{
			get
			{
				if(IsModified_byNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _modified_by;
			}
			set
			{
				_modified_byNull = false;
				_modified_by = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Modified_by"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsModified_byNull
		{
			get { return _modified_byNull; }
			set { _modified_byNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>deleted_date</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>deleted_date</c> column value.</value>
		public System.DateTime Deleted_date
		{
			get
			{
				if(IsDeleted_dateNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _deleted_date;
			}
			set
			{
				_deleted_dateNull = false;
				_deleted_date = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Deleted_date"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDeleted_dateNull
		{
			get { return _deleted_dateNull; }
			set { _deleted_dateNull = value; }
		}

		/// <summary>
		/// Gets or sets the <c>deleted_by</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>deleted_by</c> column value.</value>
		public long Deleted_by
		{
			get
			{
				if(IsDeleted_byNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _deleted_by;
			}
			set
			{
				_deleted_byNull = false;
				_deleted_by = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Deleted_by"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsDeleted_byNull
		{
			get { return _deleted_byNull; }
			set { _deleted_byNull = value; }
		}

		/// <summary>
		/// Returns the string representation of this instance.
		/// </summary>
		/// <returns>The string representation of this instance.</returns>
		public override string ToString()
		{
			System.Text.StringBuilder dynStr = new System.Text.StringBuilder(GetType().Name);
			dynStr.Append(':');
			dynStr.Append("  Table_pid=");
			dynStr.Append(Table_pid);
			dynStr.Append("  Table_name=");
			dynStr.Append(Table_name);
			dynStr.Append("  Name=");
			dynStr.Append(Name);
			dynStr.Append("  Created_date=");
			dynStr.Append(IsCreated_dateNull ? (object)"<NULL>" : Created_date);
			dynStr.Append("  Created_by=");
			dynStr.Append(IsCreated_byNull ? (object)"<NULL>" : Created_by);
			dynStr.Append("  Modified_date=");
			dynStr.Append(IsModified_dateNull ? (object)"<NULL>" : Modified_date);
			dynStr.Append("  Modified_by=");
			dynStr.Append(IsModified_byNull ? (object)"<NULL>" : Modified_by);
			dynStr.Append("  Deleted_date=");
			dynStr.Append(IsDeleted_dateNull ? (object)"<NULL>" : Deleted_date);
			dynStr.Append("  Deleted_by=");
			dynStr.Append(IsDeleted_byNull ? (object)"<NULL>" : Deleted_by);
			return dynStr.ToString();
		}
	} // End of pl_objectRow_Base class
} // End of namespace
