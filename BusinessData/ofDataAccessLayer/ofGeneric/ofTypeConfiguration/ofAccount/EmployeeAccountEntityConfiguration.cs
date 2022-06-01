using BusinessData.ofAccount.ofModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BusinessData.ofGeneric.ofTypeConfiguration.ofAccount
{
    public class EmployeeAccountEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : EmployeeAccountEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property(c => c.Id).HasMaxLength((int)ConstraintLength.Id);
            builder.Property(c => c.ChangedUsers).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<List<ChangeUser>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.ImageofInfos).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<IList<ImageofInfo>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
            builder.Property(c => c.Docs).HasConversion(
                 v => JsonConvert.SerializeObject(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }),
                 v => JsonConvert.DeserializeObject<IList<Doc>>(v, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }));
        }
    }
}