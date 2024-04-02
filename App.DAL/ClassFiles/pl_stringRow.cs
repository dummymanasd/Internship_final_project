// <fileinfo name="pl_stringRow_Base.cs">
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
	/// The base class for <see cref="pl_stringRow"/> that 
	/// represents a record in the <c>pl_string</c> table.
	/// </summary>
	/// <remarks>
	/// Do not change this source code manually. Update the <see cref="pl_stringRow"/>
	/// class if you need to add or change some functionality.
	/// </remarks>
	public class pl_stringRow
	{
		private long _table_pid;
		private string _column_type;
		private string _data_value;

		/// <summary>
		/// Initializes a new instance of the <see cref="pl_stringRow"/> class.
		/// </summary>
		public pl_stringRow()
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
		/// Gets or sets the <c>column_type</c> column value.
		/// </summary>
		/// <value>The <c>column_type</c> column value.</value>
		public string Column_type
		{
			get { return _column_type; }
			set { _column_type = value; }
		}

		/// <summary>
		/// Gets or sets the <c>data_value</c> column value.
		/// </summary>
		/// <value>The <c>data_value</c> column value.</value>
		public string Data_value
		{
			get { return _data_value; }
			set { _data_value = value; }
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
			dynStr.Append("  Column_type=");
			dynStr.Append(Column_type);
			dynStr.Append("  Data_value=");
			dynStr.Append(Data_value);
			return dynStr.ToString();
		}
	} // End of pl_stringRow_Base class
} // End of namespace
