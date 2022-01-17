using System.Collections.Generic;
using System;
using System.Reflection;
using BusinessData.ofCommon.ofKamis.ofDbContext;

namespace BusinessData.ofCommon.ofKamis.ofModel
{
    public abstract class KamisEntity : Entity
	{

	}

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisPart), nameof(KamisPart))]
	public class KamisPart : KamisEntity, IRelationable
	{
		public List<KamisCommodity> KamisCommodities {get; set;}
		public List<KamisKindofCommodity> KamisKindsofCommodities { get; set; }
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

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisCommodity), nameof(KamisCommodity))]
	public class KamisCommodity : KamisEntity, IRelationable
	{
		public string KamisPartId {get; set;}
		public KamisPart KamisPart {get; set;}
		public List<KamisKindofCommodity> KamisKindsofCommodity {get; set;}
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

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisKindofCommodity), nameof(KamisKindofCommodity))]
	public class KamisKindofCommodity : KamisEntity, IRelationable
	{
		public string Code { get; set; }
		public string WholesaleShippingUnit {get; set;} // 도매출하단위 5
		public string WholeSaleShippingUnizSize {get; set;} // 도매출하단위크기 6
		public string RetailShippingUnit {get; set;} // 소매출한단위 7
		public string RetailShippingUnitSize {get; set;} // 소매출하단위크기 8 
		public string EcoFriendlyAgriculturalProductShippingUnit {get; set;} // 친환경농산물 출하단위 11
		public string EcoFriendlyAgriculturalProductShippingUnitSize {get; set;} // 친환경농산물 출하단위 크기 12
		public string WholeSaleGrade {get; set;} // 도매등급 13
		public string RetailSaleGrade {get; set;} // 소매등급 14
		public string EcoFriendlyGrade {get; set;} // 친환경등급 16
		public List<KamisWholeSalePrice> KamisWholeSalePrices {get; set;}
		public List<KamisRetailPrice> KamisRetailPrices {get; set;}
		public KamisCommodity KamisCommodity {get; set;}
		public KamisPart KamisPart {get; set;}
		public string KamisPartId {get; set;}
		public string KamisCommodityId {get; set;} // 품목코드 1
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

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisGrade), nameof(KamisGrade))]
	public class KamisGrade : KamisEntity, IRelationable
	{
		public override string GetRelationCode()
		{
			RelationAttribute relationAttribute = (RelationAttribute)Attribute.GetCustomAttribute(GetType(), typeof(RelationAttribute));
			if (relationAttribute != null)
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
			foreach (var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if (Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					var One = prop.GetCustomAttribute<OneAttribute>();
					if (Many is null && One is null)
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
			foreach (var prop in props)
			{
				var Get = prop.GetCustomAttribute<DetailAttribute>();
				if (Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					var One = prop.GetCustomAttribute<OneAttribute>();
					if (Many is null && One is null)
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
			foreach (var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if (Get != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					if (Many != null)
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
			foreach (var prop in props)
			{
				var Get = prop.GetCustomAttribute<GetAttribute>();
				if (Get != null)
				{
					var One = prop.GetCustomAttribute<OneAttribute>();
					if (One != null)
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
			foreach (var prop in props)
			{
				var Detail = prop.GetCustomAttribute<DetailAttribute>();
				if (Detail != null)
				{
					var One = prop.GetCustomAttribute<OneAttribute>();
					if (One != null)
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
			foreach (var prop in props)
			{
				var Detail = prop.GetCustomAttribute<DetailAttribute>();
				if (Detail != null)
				{
					var Many = prop.GetCustomAttribute<ManyAttribute>();
					if (Many != null)
					{
						DetailManyPropertyInfos.Add(prop);
					}
				}
			}
			return DetailManyPropertyInfos;
		}
	}

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisCountryAdministrationPart), nameof(KamisCountryAdministrationPart))]
	public class KamisCountryAdministrationPart : KamisEntity, IRelationable
	{
		public List<KamisMarket> KamisMakrets {get; set;}
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

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisMarket), nameof(KamisMarket))]
	public class KamisMarket : KamisEntity, IRelationable
	{
		public string KamisCountryAdministrationPartId {get; set;}
		public KamisCountryAdministrationPart KamisCountryAdministrationPart {get; set;}
		public List<KamisWholeSalePrice> KamisWholeSalePrices {get; set;}
		public List<KamisRetailPrice> KamisRetailPrices {get; set;}
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

	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisRetailPrice), nameof(KamisRetailPrice))]
	public class KamisRetailPrice : KamisEntity, IRelationable
	{
		public string KamisMarketId {get; set;}
		public string KamisKindofCommodityId {get; set;}
		public string KamisGradeCode {get; set;}
		public string KamisClsCode {get; set;}
		public string yyyy {get; set;}
		public string regday {get; set;}
		public KamisMarket KamisMarket {get; set;}
		public KamisKindofCommodity KamisKindofCommodity {get; set;}
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
	[DataContext(typeof(KamisDbContext), DbConnectionString.KamisDbConnection)]
	[Relation(typeof(KamisWholeSalePrice), nameof(KamisWholeSalePrice))]
	public class KamisWholeSalePrice : KamisEntity, IRelationable
	{
		public string KamisMarketId {get; set;}
		public string KamisKindofCommodityId {get; set;}
		public string KamisGradeCode {get; set;}
		public string KamisClsCode {get; set;}
		public string yyyy {get; set;}
		public string regday {get; set;}
		public KamisMarket KamisMarket {get; set;}
		public KamisKindofCommodity KamisKindofCommodity {get; set;}

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
	public class ProductPriceResult
	{
		public Condition[] condition { get; set; }
		public Data data { get; set; }
		public class Condition
		{
			public string p_startday { get; set; }
			public string p_endday { get; set; }
			public string p_itemcategorycode { get; set; }
			public string p_itemcode { get; set; }
			public string p_kindcode { get; set; }
			public string p_productrankcode { get; set; }
			public string p_countycode { get; set; }
			public string p_convert_kg_yn { get; set; }
			public string p_key { get; set; }
			public string p_id { get; set; }
			public string p_returntype { get; set; }
		}
		public class Data
		{
			public string error_code { get; set; }
			public object[] item { get; set; }
		}
	}
	public class ProductPrice
	{
		public string itemname { get; set; }
		public string kindname { get; set; }
		public string countryname { get; set; }
		public string marketname { get; set; }
		public string yyyy { get; set; }
		public string regday { get; set; }
		public string price { get; set; }
	}
	public class PeriodProductPriceListInfo
	{
		public string[] itemname { get; set; }
		public string[] kindname { get; set; }
		public string countyname { get; set; }
		public string[] marketname { get; set; }
		public string yyyy { get; set; }
		public string regday { get; set; }
		public string price { get; set; }
	}
	public class AverageKamisPriceInfo
	{
		public string itemname { get; set; }
		public string kindname { get; set; }
		public string countyname { get; set; }
		public string marketname { get; set; }
		public string yyyy { get; set; }
		public string regday { get; set; }
		public string price { get; set; }
	}
	public class BufferAverageKamisPriceInfo
	{
		public string[] itemname { get; set; }
		public string[] kindname { get; set; }
		public string countyname { get; set; }
		public string[] marketname { get; set; }
		public string yyyy { get; set; }
		public string regday { get; set; }
		public string price { get; set; }
	}
	public class KamisPriceInfo
	{
		public string itemname { get; set; }
		public string kindname { get; set; }
		public string countyname { get; set; }
		public string marketname { get; set; }
		public string yyyy { get; set; }
		public string regday { get; set; }
		public string price { get; set; }
	}
}