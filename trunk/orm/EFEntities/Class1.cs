using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Design;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFEntities
{
    public class ExtendedMigrationCodeGenerator : MigrationCodeGenerator
    {
        public override ScaffoldedMigration Generate(string migrationId, IEnumerable<MigrationOperation> operations, string sourceModel, string targetModel, string @namespace, string className)
        {
            foreach (MigrationOperation operation in operations)
            {
                if (operation is CreateTableOperation)
                {
                    foreach (var column in ((CreateTableOperation)operation).Columns)
                        if (column.ClrType == typeof(DateTime) && column.IsNullable.HasValue && !column.IsNullable.Value && string.IsNullOrEmpty(column.DefaultValueSql))
                            column.DefaultValueSql = "GETDATE()";
                }
                else if (operation is AddColumnOperation)
                {
                    ColumnModel column = ((AddColumnOperation)operation).Column;

                    if (column.ClrType == typeof(DateTime) && column.IsNullable.HasValue && !column.IsNullable.Value && string.IsNullOrEmpty(column.DefaultValueSql))
                        column.DefaultValueSql = "GETDATE()";
                }
            }

            CSharpMigrationCodeGenerator generator = new CSharpMigrationCodeGenerator();

            return generator.Generate(migrationId, operations, sourceModel, targetModel, @namespace, className);
        }
    }

    //internal sealed class Configuration : DbMigrationsConfiguration<TestDB1>
    //{
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = false;
    //        MigrationsDirectory = @"Migrations";
    //        this.CodeGenerator = new ExtendedMigrationCodeGenerator();
    //    }
    //}

}
