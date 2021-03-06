﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data_Access_Layer
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	public partial class LinqDataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LinqDataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinqDataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}

        public LinqDataClasses1DataContext() :
            base(global::Data_Access_Layer.Properties.Settings.Default.Database1ConnectionString, mappingSource)
        {
            OnCreated();
        }        

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.UserRegistration")]
        public int UserRegistration([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string emailid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string qualification, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string address)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, phone, emailid, password, qualification, address);
            return ((int)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.addUniversity")]
        public int addUniversity([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string code, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string emailid, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string location, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string address)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, code, phone, emailid, location, address);
            return ((int)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.GetUniversity")]
        public ISingleResult<course> GetUniversity()
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return ((ISingleResult<course>)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.addCourse")]
        public int addCourse([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string universityname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string coursename, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string fee, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string duration, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string about)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), universityname, coursename, fee, duration, about);
            return ((int)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.viewUniversity")]
        public ISingleResult<University> viewUniversity()
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return ((ISingleResult<University>)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.viewCourse")]
        public ISingleResult<course> viewCourse()
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));

            return ((ISingleResult<course>)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.searchUniversity")]
        public ISingleResult<University> searchUniversity([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string universityname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] ref string message)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),universityname, message);
            return ((ISingleResult<University>)(result.ReturnValue));
        }

        [global::System.Data.Linq.Mapping.FunctionAttribute(Name = "dbo.searchCourse")]
        public ISingleResult<course> searchCourse([global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] string coursename, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType = "NVarChar(50)")] ref string message)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())),coursename, message);
            return ((ISingleResult<course>)(result.ReturnValue));
        }
	}

    public partial class University
    {

        private int _Id;
        private string _Name;
        private string _Code;
        private string _Phone;
        private string _EmailID;        
        private string _Location;
        private string _Address;

        public University()
        {
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "Int")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this._Id = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Name", DbType = "NVarChar(50)")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                if ((this._Name != value))
                {
                    this._Name = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Code", DbType = "NVarChar(50)")]
        public string Code
        {
            get
            {
                return this._Code;
            }
            set
            {
                if ((this._Code != value))
                {
                    this._Code = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Phone", DbType = "NVarChar(50)")]
        public string Phone
        {
            get
            {
                return this._Phone;
            }
            set
            {
                if ((this._Phone != value))
                {
                    this._Phone = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_EmailID", DbType = "NVarChar(50)")]
        public string EmailID
        {
            get
            {
                return this._EmailID;
            }
            set
            {
                if ((this._EmailID != value))
                {
                    this._EmailID = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Location", DbType = "NVarChar(50)")]
        public string Location
        {
            get
            {
                return this._Location;
            }
            set
            {
                if ((this._Location != value))
                {
                    this._Location = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Address", DbType = "NVarChar(50)")]
        public string Address
        {
            get
            {
                return this._Address;
            }
            set
            {
                if ((this._Address != value))
                {
                    this._Address = value;
                }
            }
        }
    }

    public partial class course
    {

        private int _Id;
        private string _UniversityName;
        private string _CourseName;
        private string _Fee;
        private string _Duration;        
        private string _AboutCourse;        

        public course()
        {
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Id", DbType = "Int")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                if ((this._Id != value))
                {
                    this._Id = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_UniversityName", DbType = "NVarChar(50)")]
        public string UniversityName
        {
            get
            {
                return this._UniversityName;
            }
            set
            {
                if ((this._UniversityName != value))
                {
                    this._UniversityName = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_CourseName", DbType = "NVarChar(50)")]
        public string CourseName
        {
            get
            {
                return this._CourseName;
            }
            set
            {
                if ((this._CourseName != value))
                {
                    this._CourseName = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Fee", DbType = "NVarChar(50)")]
        public string Fee
        {
            get
            {
                return this._Fee;
            }
            set
            {
                if ((this._Fee != value))
                {
                    this._Fee = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_Duration", DbType = "NVarChar(50)")]
        public string Duration
        {
            get
            {
                return this._Duration;
            }
            set
            {
                if ((this._Duration != value))
                {
                    this._Duration = value;
                }
            }
        }

        [global::System.Data.Linq.Mapping.ColumnAttribute(Storage = "_AboutCourse", DbType = "NVarChar(50)")]
        public string AboutCourse
        {
            get
            {
                return this._AboutCourse;
            }
            set
            {
                if ((this._AboutCourse != value))
                {
                    this._AboutCourse = value;
                }
            }
        }
    }
}
#pragma warning restore 1591
