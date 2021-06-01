namespace CourseApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0b35c39c-5ed3-408f-bc2e-3736a6a6780f', N'guest@email.com', 0, N'ADpVzVs2TYnLys1z3C4abuheIeI27XqPhHdQdXqSEMfPjwvsYyDDdEbIH0KN0dHtVQ==', N'20c08b7f-29ac-4fb6-9901-a014ddcd2ade', NULL, 0, 0, NULL, 1, 0, N'guest@email.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9563eae9-f532-4197-a6d9-8c2b1920758c', N'admin@email.com', 0, N'ANsHsNCZlETWeeqIdoVvjiXF2LLhacsWSxVqMtYQwo9IaDOr5NMJ6QWBC92Mep/Epw==', N'e8d26de2-3c88-4e9d-88b8-1cbf9ca9faa9', NULL, 0, 0, NULL, 1, 0, N'admin@email.com')
            
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'37fefc3b-9234-4d12-9ff9-76c601e34ab4', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9563eae9-f532-4197-a6d9-8c2b1920758c', N'37fefc3b-9234-4d12-9ff9-76c601e34ab4')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
