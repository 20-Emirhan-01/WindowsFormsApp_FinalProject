﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp_FinalProject
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class YeniEntities : DbContext
    {
        public YeniEntities()
            : base("name=YeniEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        //public virtual DbSet<Banka> Banka { get; set; }
        //public virtual DbSet<Bankas> Bankas { get; set; }
        //public virtual DbSet<Calisan> Calisan { get; set; }
        //public virtual DbSet<departments> departments { get; set; }
        //public virtual DbSet<offices> offices { get; set; }
        //public virtual DbSet<personnels> personnels { get; set; }
        //public virtual DbSet<positions> positions { get; set; }
        //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        //public virtual DbSet<workplaces> workplaces { get; set; }
        //public virtual DbSet<workStationReservations> workStationReservations { get; set; }
        //public virtual DbSet<workStations> workStations { get; set; }
        //public virtual DbSet<Yonetici> Yonetici { get; set; }
        public virtual DbSet<STDer> STDers { get; set; }
        public virtual DbSet<STDersTakip> STDersTakips { get; set; }
        public virtual DbSet<STOgrenci> STOgrencis { get; set; }
        public virtual DbSet<STPersonel> STPersonels { get; set; }
        public virtual DbSet<Sube> Subes { get; set; }
    
        public virtual int BankaSube(Nullable<int> bankaId)
        {
            var bankaIdParameter = bankaId.HasValue ?
                new ObjectParameter("BankaId", bankaId) :
                new ObjectParameter("BankaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BankaSube", bankaIdParameter);
        }
    
        public virtual int BankaSubeler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("BankaSubeler");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<spInsertOrUpdatedepartments_Result> spInsertOrUpdatedepartments(Nullable<int> id, string title, Nullable<int> workplaceId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var workplaceIdParameter = workplaceId.HasValue ?
                new ObjectParameter("workplaceId", workplaceId) :
                new ObjectParameter("workplaceId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdatedepartments_Result>("spInsertOrUpdatedepartments", idParameter, titleParameter, workplaceIdParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdateoffices_Result> spInsertOrUpdateoffices(Nullable<int> id, string title, Nullable<int> workplaceId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var workplaceIdParameter = workplaceId.HasValue ?
                new ObjectParameter("workplaceId", workplaceId) :
                new ObjectParameter("workplaceId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdateoffices_Result>("spInsertOrUpdateoffices", idParameter, titleParameter, workplaceIdParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdatepersonnels_Result> spInsertOrUpdatepersonnels(Nullable<int> id, string name, string surname, string mail, Nullable<int> officeId, Nullable<int> positionId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("surname", surname) :
                new ObjectParameter("surname", typeof(string));
    
            var mailParameter = mail != null ?
                new ObjectParameter("mail", mail) :
                new ObjectParameter("mail", typeof(string));
    
            var officeIdParameter = officeId.HasValue ?
                new ObjectParameter("officeId", officeId) :
                new ObjectParameter("officeId", typeof(int));
    
            var positionIdParameter = positionId.HasValue ?
                new ObjectParameter("positionId", positionId) :
                new ObjectParameter("positionId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdatepersonnels_Result>("spInsertOrUpdatepersonnels", idParameter, nameParameter, surnameParameter, mailParameter, officeIdParameter, positionIdParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdatepositions_Result> spInsertOrUpdatepositions(Nullable<int> id, string title, Nullable<int> departmentId)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var departmentIdParameter = departmentId.HasValue ?
                new ObjectParameter("departmentId", departmentId) :
                new ObjectParameter("departmentId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdatepositions_Result>("spInsertOrUpdatepositions", idParameter, titleParameter, departmentIdParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdateworkplaces_Result> spInsertOrUpdateworkplaces(Nullable<int> id, string title)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdateworkplaces_Result>("spInsertOrUpdateworkplaces", idParameter, titleParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdateworkStationReservations_Result> spInsertOrUpdateworkStationReservations(Nullable<int> id, Nullable<int> officeId, Nullable<int> workStationId, Nullable<int> personnelId, Nullable<System.DateTime> startTime, Nullable<System.DateTime> endTime)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var officeIdParameter = officeId.HasValue ?
                new ObjectParameter("officeId", officeId) :
                new ObjectParameter("officeId", typeof(int));
    
            var workStationIdParameter = workStationId.HasValue ?
                new ObjectParameter("workStationId", workStationId) :
                new ObjectParameter("workStationId", typeof(int));
    
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("personnelId", personnelId) :
                new ObjectParameter("personnelId", typeof(int));
    
            var startTimeParameter = startTime.HasValue ?
                new ObjectParameter("startTime", startTime) :
                new ObjectParameter("startTime", typeof(System.DateTime));
    
            var endTimeParameter = endTime.HasValue ?
                new ObjectParameter("endTime", endTime) :
                new ObjectParameter("endTime", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdateworkStationReservations_Result>("spInsertOrUpdateworkStationReservations", idParameter, officeIdParameter, workStationIdParameter, personnelIdParameter, startTimeParameter, endTimeParameter);
        }
    
        public virtual ObjectResult<spInsertOrUpdateworkStations_Result> spInsertOrUpdateworkStations(Nullable<int> id, Nullable<int> officeId, string title, string description)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var officeIdParameter = officeId.HasValue ?
                new ObjectParameter("officeId", officeId) :
                new ObjectParameter("officeId", typeof(int));
    
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            var descriptionParameter = description != null ?
                new ObjectParameter("description", description) :
                new ObjectParameter("description", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spInsertOrUpdateworkStations_Result>("spInsertOrUpdateworkStations", idParameter, officeIdParameter, titleParameter, descriptionParameter);
        }
    
        public virtual ObjectResult<spSelectWorkStationReservationsByOfficeId_Result> spSelectWorkStationReservationsByOfficeId(Nullable<int> officeId)
        {
            var officeIdParameter = officeId.HasValue ?
                new ObjectParameter("officeId", officeId) :
                new ObjectParameter("officeId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectWorkStationReservationsByOfficeId_Result>("spSelectWorkStationReservationsByOfficeId", officeIdParameter);
        }
    }
}