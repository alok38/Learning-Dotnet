﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Employee_Service_Project
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LTIMindtreeDB")]
	public partial class LTIMindtreedbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertDepartment(Department instance);
    partial void UpdateDepartment(Department instance);
    partial void DeleteDepartment(Department instance);
    partial void InsertProject(Project instance);
    partial void UpdateProject(Project instance);
    partial void DeleteProject(Project instance);
    #endregion
		
		public LTIMindtreedbDataContext() : 
				base(global::Employee_Service_Project.Properties.Settings.Default.LTIMindtreeDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LTIMindtreedbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LTIMindtreedbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LTIMindtreedbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LTIMindtreedbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<Department> Departments
		{
			get
			{
				return this.GetTable<Department>();
			}
		}
		
		public System.Data.Linq.Table<Project> Projects
		{
			get
			{
				return this.GetTable<Project>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employees")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _EmpId;
		
		private string _EmpName;
		
		private decimal _EmpSalary;
		
		private string _EmpGender;
		
		private System.DateTime _EmpDob;
		
		private System.DateTime _EmpDoj;
		
		private System.Nullable<int> _ProjectId;
		
		private int _DeptId;
		
		private EntityRef<Department> _Department;
		
		private EntityRef<Project> _Project;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmpIdChanging(int value);
    partial void OnEmpIdChanged();
    partial void OnEmpNameChanging(string value);
    partial void OnEmpNameChanged();
    partial void OnEmpSalaryChanging(decimal value);
    partial void OnEmpSalaryChanged();
    partial void OnEmpGenderChanging(string value);
    partial void OnEmpGenderChanged();
    partial void OnEmpDobChanging(System.DateTime value);
    partial void OnEmpDobChanged();
    partial void OnEmpDojChanging(System.DateTime value);
    partial void OnEmpDojChanged();
    partial void OnProjectIdChanging(System.Nullable<int> value);
    partial void OnProjectIdChanged();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    #endregion
		
		public Employee()
		{
			this._Department = default(EntityRef<Department>);
			this._Project = default(EntityRef<Project>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int EmpId
		{
			get
			{
				return this._EmpId;
			}
			set
			{
				if ((this._EmpId != value))
				{
					this.OnEmpIdChanging(value);
					this.SendPropertyChanging();
					this._EmpId = value;
					this.SendPropertyChanged("EmpId");
					this.OnEmpIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string EmpName
		{
			get
			{
				return this._EmpName;
			}
			set
			{
				if ((this._EmpName != value))
				{
					this.OnEmpNameChanging(value);
					this.SendPropertyChanging();
					this._EmpName = value;
					this.SendPropertyChanged("EmpName");
					this.OnEmpNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpSalary", DbType="Money NOT NULL")]
		public decimal EmpSalary
		{
			get
			{
				return this._EmpSalary;
			}
			set
			{
				if ((this._EmpSalary != value))
				{
					this.OnEmpSalaryChanging(value);
					this.SendPropertyChanging();
					this._EmpSalary = value;
					this.SendPropertyChanged("EmpSalary");
					this.OnEmpSalaryChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpGender", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string EmpGender
		{
			get
			{
				return this._EmpGender;
			}
			set
			{
				if ((this._EmpGender != value))
				{
					this.OnEmpGenderChanging(value);
					this.SendPropertyChanging();
					this._EmpGender = value;
					this.SendPropertyChanged("EmpGender");
					this.OnEmpGenderChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpDob", DbType="Date NOT NULL")]
		public System.DateTime EmpDob
		{
			get
			{
				return this._EmpDob;
			}
			set
			{
				if ((this._EmpDob != value))
				{
					this.OnEmpDobChanging(value);
					this.SendPropertyChanging();
					this._EmpDob = value;
					this.SendPropertyChanged("EmpDob");
					this.OnEmpDobChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmpDoj", DbType="Date NOT NULL")]
		public System.DateTime EmpDoj
		{
			get
			{
				return this._EmpDoj;
			}
			set
			{
				if ((this._EmpDoj != value))
				{
					this.OnEmpDojChanging(value);
					this.SendPropertyChanging();
					this._EmpDoj = value;
					this.SendPropertyChanged("EmpDoj");
					this.OnEmpDojChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", DbType="Int")]
		public System.Nullable<int> ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					if (this._Project.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL")]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					if (this._Department.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Department", ThisKey="DeptId", OtherKey="DeptId", IsForeignKey=true)]
		public Department Department
		{
			get
			{
				return this._Department.Entity;
			}
			set
			{
				Department previousValue = this._Department.Entity;
				if (((previousValue != value) 
							|| (this._Department.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Department.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Department.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._DeptId = value.DeptId;
					}
					else
					{
						this._DeptId = default(int);
					}
					this.SendPropertyChanged("Department");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Employee", Storage="_Project", ThisKey="ProjectId", OtherKey="ProjectId", IsForeignKey=true)]
		public Project Project
		{
			get
			{
				return this._Project.Entity;
			}
			set
			{
				Project previousValue = this._Project.Entity;
				if (((previousValue != value) 
							|| (this._Project.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Project.Entity = null;
						previousValue.Employees.Remove(this);
					}
					this._Project.Entity = value;
					if ((value != null))
					{
						value.Employees.Add(this);
						this._ProjectId = value.ProjectId;
					}
					else
					{
						this._ProjectId = default(Nullable<int>);
					}
					this.SendPropertyChanged("Project");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Department")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _DeptId;
		
		private string _DeptName;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDeptIdChanging(int value);
    partial void OnDeptIdChanged();
    partial void OnDeptNameChanging(string value);
    partial void OnDeptNameChanged();
    #endregion
		
		public Department()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int DeptId
		{
			get
			{
				return this._DeptId;
			}
			set
			{
				if ((this._DeptId != value))
				{
					this.OnDeptIdChanging(value);
					this.SendPropertyChanging();
					this._DeptId = value;
					this.SendPropertyChanged("DeptId");
					this.OnDeptIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DeptName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DeptName
		{
			get
			{
				return this._DeptName;
			}
			set
			{
				if ((this._DeptName != value))
				{
					this.OnDeptNameChanging(value);
					this.SendPropertyChanging();
					this._DeptName = value;
					this.SendPropertyChanged("DeptName");
					this.OnDeptNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Department_Employee", Storage="_Employees", ThisKey="DeptId", OtherKey="DeptId")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Department = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Project")]
	public partial class Project : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProjectId;
		
		private string _ProjectName;
		
		private string _ProjectClient;
		
		private EntitySet<Employee> _Employees;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProjectIdChanging(int value);
    partial void OnProjectIdChanged();
    partial void OnProjectNameChanging(string value);
    partial void OnProjectNameChanged();
    partial void OnProjectClientChanging(string value);
    partial void OnProjectClientChanged();
    #endregion
		
		public Project()
		{
			this._Employees = new EntitySet<Employee>(new Action<Employee>(this.attach_Employees), new Action<Employee>(this.detach_Employees));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProjectId
		{
			get
			{
				return this._ProjectId;
			}
			set
			{
				if ((this._ProjectId != value))
				{
					this.OnProjectIdChanging(value);
					this.SendPropertyChanging();
					this._ProjectId = value;
					this.SendPropertyChanged("ProjectId");
					this.OnProjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProjectName
		{
			get
			{
				return this._ProjectName;
			}
			set
			{
				if ((this._ProjectName != value))
				{
					this.OnProjectNameChanging(value);
					this.SendPropertyChanging();
					this._ProjectName = value;
					this.SendPropertyChanged("ProjectName");
					this.OnProjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProjectClient", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProjectClient
		{
			get
			{
				return this._ProjectClient;
			}
			set
			{
				if ((this._ProjectClient != value))
				{
					this.OnProjectClientChanging(value);
					this.SendPropertyChanging();
					this._ProjectClient = value;
					this.SendPropertyChanged("ProjectClient");
					this.OnProjectClientChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Project_Employee", Storage="_Employees", ThisKey="ProjectId", OtherKey="ProjectId")]
		public EntitySet<Employee> Employees
		{
			get
			{
				return this._Employees;
			}
			set
			{
				this._Employees.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Project = this;
		}
		
		private void detach_Employees(Employee entity)
		{
			this.SendPropertyChanging();
			entity.Project = null;
		}
	}
}
#pragma warning restore 1591
