    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Internship2024.Model
    {
        public class AreaCreateRepository : IAreaCreateRepository
        {
            private readonly Internship2024DB _db;

            public AreaCreateRepository(Internship2024DB db)
            {
                _db = db;
            }

            // to get the unique code from the database


            public string GetUniqueCodeFromDatabase()
            {
                string query = "SELECT MAX(CAST(SUBSTRING(unique_code, 2, LEN(unique_code) - 1) AS INT)) FROM pl_area";
                using (SqlCommand cmd = new SqlCommand(query, _db.Connection))
                {
                    // Ensure to handle null values
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value && result != null)
                    {
                        int maxNumericValue = (int)result;
                        // Increment the maxNumericValue by 1
                        maxNumericValue++;
                        // Format the new unique code
                        string newUniqueCode = $"A{maxNumericValue:D3}";
                        return newUniqueCode;

                    }
                    else
                    {
                        // If no records found or all UniqueCode values are null, start from A001
                        return "A001";
                    }

                }


            }

            public void CreateArea(pl_areaRow area)
            {
                // ctrl +k + c 
                // using (SqlCommand cmd = _db.CreateCommand(
                //            "INSERT INTO pl_area (unique_code, name, area_code, is_for_dispensing) " +
                //            "VALUES (@UniqueCode, @AreaName, @AreaCode,  @IsForDispensing)"))
                // {
                //     _db.AddParameter(cmd, "UniqueCode", DbType.String, area.UniqueCode);
                //     _db.AddParameter(cmd, "AreaName", DbType.String, area.AreaName);
                //     _db.AddParameter(cmd, "AreaCode", DbType.String, area.AreaCode);
                //     // _db.AddParameter(cmd, "DepartmentName", DbType.String, area.DepartmentName);
                //     // _db.AddParameter(cmd, "Description", DbType.String, area.Description); 
                //     _db.AddParameter(cmd, "IsForDispensing", DbType.Boolean, area.IsForDispensing);
                //     // _db.AddParameter(cmd, "", DbType.Boolean, area.IsActive);
                //
                //     _db.ExecuteNonQuery(cmd);
                // }

                try
                {
                    _db.BeginTransaction();

                    pl_objectRow row = new pl_objectRow();
                    row.Table_name = "pl_area";
                    row.Name = area.Name;

                    pl_object obj = new pl_object(_db);
                    obj.Insert(row);

                    area.Table_pid = row.Table_pid; // Assign the Table_pid value from the inserted pl_object row
                    long Table_pid = row.Table_pid;

                    pl_area objArea = new pl_area(_db);
                    objArea.Insert(area);

                    // Insert UniqueCode
                    pl_stringRow objStringRowUniqueCode = new pl_stringRow();
                    objStringRowUniqueCode.Table_pid = row.Table_pid;
                    objStringRowUniqueCode.Column_type = "unique_code";
                    objStringRowUniqueCode.Data_value = area.Unique_code;

                    pl_string plStringUniqueCode = new pl_string(_db);
                    plStringUniqueCode.Insert(objStringRowUniqueCode);

                    // Insert AreaName
                    pl_stringRow objStringRowAreaName = new pl_stringRow();
                    objStringRowAreaName.Table_pid = row.Table_pid;
                    objStringRowAreaName.Column_type = "area_name";
                    objStringRowAreaName.Data_value = area.Name;

                    pl_string plStringAreaName = new pl_string(_db);
                    plStringAreaName.Insert(objStringRowAreaName);

                    // Insert AreaCode
                    pl_stringRow objStringRowAreaCode = new pl_stringRow();
                    objStringRowAreaCode.Table_pid = row.Table_pid;
                    objStringRowAreaCode.Column_type = "area_code";
                    objStringRowAreaCode.Data_value = area.Area_code;

                    pl_string plStringAreaCode = new pl_string(_db);
                    plStringAreaCode.Insert(objStringRowAreaCode);

                    // Insert Description
                    pl_stringRow objStringRowDescription = new pl_stringRow();
                    objStringRowDescription.Table_pid = row.Table_pid;
                    objStringRowDescription.Column_type = "description";
                    objStringRowDescription.Data_value = area.Description;

                    pl_string plStringDescription = new pl_string(_db);
                    plStringDescription.Insert(objStringRowDescription);

                    //Boolean- Insert
                    pl_booleanRow plBooleanRowIsForDispen = new pl_booleanRow();
                    plBooleanRowIsForDispen.Table_pid = Table_pid;
                    plBooleanRowIsForDispen.Column_type = "s_for_dispensing";
                    plBooleanRowIsForDispen.Data_value = area.Is_for_dispensing;

                    pl_boolean plBooleanIsforDispen = new pl_boolean(_db);
                    plBooleanIsforDispen.Insert(plBooleanRowIsForDispen);
                    
                    //Boolean -Insert
                    pl_booleanRow plBooleanRowStatus = new pl_booleanRow();
                    plBooleanRowStatus.Table_pid = Table_pid;
                    plBooleanRowStatus.Column_type = "status";
                    plBooleanRowStatus.Data_value = area.Status;
                    
                    pl_boolean plBooleanStatus = new pl_boolean(_db);
                    plBooleanStatus.Insert(plBooleanRowStatus);
                    
                    // // Int - Insert
                    // pl_integerRow plIntegerRow = new pl_integerRow();
                    // plIntegerRow.Table_pid = area.Table_pid;
                    // plIntegerRow.Column_type = "department_id";
                    // plIntegerRow.Data_value = area.Department_id;
                    


                    _db.CommitTransaction();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    _db.RollbackTransaction();
                    throw;
                }


            }


            public List<Department> LoadDepartmentsFromDatabase()
            {
                var departments = new List<Department>();
                
                string query = "SELECT DID, Name FROM Department";
                using (SqlCommand cmd = new SqlCommand(query, _db.Connection))
                {
                    
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                var department = new Department
                                {
                                    ID = reader.GetInt32(0),
                                    Name = reader.GetString(1)
                                };

                                departments.Add(department);
                            }
                        }
                    }
                }

                return departments;
            }
        }
    }
                        
            