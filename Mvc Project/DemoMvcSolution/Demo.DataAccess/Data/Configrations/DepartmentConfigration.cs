
namespace Demo.DataAccess.Data.Configrations
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id).UseIdentityColumn(10,10);
            builder.Property(D => D.Name).HasColumnType("Varchar(20)");
            builder.Property(D => D.Code).HasColumnType("Varchar(20)");
            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(D => D.CreatedOn).HasComputedColumnSql("GETDATE()");
        }
        
    }
}
