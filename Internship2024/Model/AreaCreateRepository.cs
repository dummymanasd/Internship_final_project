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


                    pl_area objArea = new pl_area(_db);
                    objArea.Insert(area);

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
                        
            