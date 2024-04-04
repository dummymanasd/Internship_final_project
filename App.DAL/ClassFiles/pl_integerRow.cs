// <fileinfo name="pl_integerRow_Base.cs">
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
	/// The base class for <see cref="pl_integerRow"/> that 
	/// represents a record in the <c>pl_integer</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_integerRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public  class pl_integerRow
	{
		private long _table_pid;
		private bool _table_pidNull = true;
		private string _column_type;
		private int _data_value;
		private bool _data_valueNull = true;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_integerRow"/> class.
		/// </summary>
		public pl_integerRow()
		{
			// EMPTY
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
		/// Gets or sets the <c>column_type</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>column_type</c> column value.</value>
		public string Column_type
		{
			get { return _column_type; }
			set { _column_type = value; }
		}

		/// <summary>
		/// Gets or sets the <c>data_value</c> column value.
		/// This column is nullable.
		/// </summary>
		/// <value>The <c>data_value</c> column value.</value>
		public int Data_value
		{
			get
			{
				if(IsData_valueNull)
					throw new InvalidOperationException("Cannot get value because it is DBNull.");
				return _data_value;
			}
			set
			{
				_data_valueNull = false;
				_data_value = value;
			}
		}

		/// <summary>
		/// Indicates whether the <see cref="Data_value"/>
		/// property value is null.
		/// </summary>
		/// <value>true if the property value is null, otherwise false.</value>
		public bool IsData_valueNull
		{
			get { return _data_valueNull; }
			set { _data_valueNull = value; }
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
			dynStr.Append(IsTable_pidNull ? (object)"<NULL>" : Table_pid);
			dynStr.Append("  Column_type=");
			dynStr.Append(Column_type);
			dynStr.Append("  Data_value=");
			dynStr.Append(IsData_valueNull ? (object)"<NULL>" : Data_value);
			return dynStr.ToString();
		}
	} // End of pl_integerRow_Base class
} // End of namespace
