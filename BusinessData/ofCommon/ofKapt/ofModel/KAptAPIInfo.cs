using BusinessData.ofCommon.ofKApt.ofDbContext;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace BusinessData.ofCommon.ofKapt
{
    [DataContext(typeof(KAptDbContext), DbConnectionString.KAptDbConnection)]
	[Relation(typeof(KAptBasicInfo), nameof(KAptBasicInfo))]
    public class KAptBasicInfo : Entity, IRelationable
    {
        public string County { get; set; } //1
        public string City { get; set; } //2
        public string Town { get; set; } //3
        public string Viliage { get; set; } //4
        public string Classification { get; set; } //7
        public string StreetAddress { get; set; }// 9
        public string RegalAddress { get; set; } // 8
        public string SalesType { get; set; } // 10
        public string DateofApprovalForUse { get; set; } // 11
        public string NumberofApt { get; set; } //12
        public string NumberofHouseHolds { get; set; } // 13
        public string Managementmethod { get; set; } //14
        public string Housemanager { get; set; } //19
        public string Managementmanagementmethod { get; set; } //20
        public string Generalmanagementpersonnel { get; set; } //21
        public string GuardManagement  { get; set; } // 22
        public string GuardNumber { get; set; } // 23
        public string GuardManager { get; set; } // 24
        public string Numberofparkingspaces { get; set; } //45
        public string Numberofundergroundparkingspaces { get; set; } //46
        public string ManagementOfficeAddress { get; set; } //49
        public string ManagementOfficePhoneNumber { get; set; } // 50
        public string ManagementOfficeFax { get; set; } // 51
        public string WelfareFacility { get; set; } // 52
        public override string GetRelationCode()
		{
			RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(GetType(), typeof(RelationAttribute));
			if(relationAttribute != null)
			{
				return relationAttribute.GetEntityRelation();
			}
			throw new ArgumentException("Not Defined Relation");
		}
		
		public Type GetDbContextType()
		{
			DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
			if (dataContextAttribute != null)
			{
				return dataContextAttribute.GetDbContextType();
			}
			throw new ArgumentException("Not Defined Relation");
		}

		public string GetDbConnetionString()
		{
			DataContextAttribute dataContextAttribute = (DataContextAttribute)Attribute.GetCustomAttribute(GetType(), typeof(DataContextAttribute));
			if (dataContextAttribute != null)
			{
				return dataContextAttribute.GetDbConnectionString();
			}
			throw new ArgumentException("Not Defined Relation");
		}
		public List<PropertyInfo> OnlyGetProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> OnlyGetPropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if(Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					var One = prop.GetCustomAttribute<OneAttribute>();
					if(Many is null && One is null)
					{
						OnlyGetPropertyInfos.Add(prop);
					}
				}
			}
			return OnlyGetPropertyInfos;
		}
		public List<PropertyInfo> OnlyDetailProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> OnlyDetailPropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Get = prop.GetCustomAttribute<DetailAttribute>();
				if(Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					var One = prop.GetCustomAttribute<OneAttribute>();
					if(Many is null && One is null)
					{
						OnlyDetailPropertyInfos.Add(prop);
					}
				}
			}
			return OnlyDetailPropertyInfos;
		}
		public List<PropertyInfo> GetManyProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> GetManyPropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if(Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					if(Many != null)
					{
						GetManyPropertyInfos.Add(prop);
					}
				}
			}
			return GetManyPropertyInfos;
		}

		public List<PropertyInfo> GetOneProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if(Get != null)
				{
					var One = prop.GetCustomAttribute<OneAttribute>();
					if(One != null)
					{
						GetOnePropertyInfos.Add(prop);
					}
				}
			}
			return GetOnePropertyInfos;
		}

		public List<PropertyInfo> DetailOneProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> GetOnePropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Detail = prop.GetCustomAttribute<DetailAttribute>();
				if(Detail != null)
				{
					var One = prop.GetCustomAttribute<OneAttribute>();
					if(One != null)
					{
						GetOnePropertyInfos.Add(prop);
					}
				}
			}
			return GetOnePropertyInfos;
		}

		public List<PropertyInfo> DetailManyProperties()
		{
			Type t = this.GetType();
			List<PropertyInfo> DetailManyPropertyInfos = new List<PropertyInfo>();
			var props = t.GetProperties();
			foreach(var prop in props)
			{
				var Detail = prop.GetCustomAttribute<DetailAttribute>();
				if(Detail != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					if(Many != null)
					{
						DetailManyPropertyInfos.Add(prop);
					}
				}
			}
			return DetailManyPropertyInfos;
		}
    }
}
