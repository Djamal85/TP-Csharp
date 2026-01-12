namespace AppGestionCahierTexte.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CleEtrangere : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("LaClasses", "IdAcademique", "AnneeAcademiques");
            DropIndex("dbo.LaClasses", new[] { "IdAcademique" });
        }
        
        public override void Down()
        {
            CreateIndex("LaClasses", "IdAcademique");
            AddForeignKey("LaClasses", "IdAcademique", "AnneeAcademiques", "IdAnneeAcademique");
        }
    }
}
