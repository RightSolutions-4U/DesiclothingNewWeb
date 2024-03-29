﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DesiClothing4u.Common.Models;


#nullable disable

namespace DesiClothing4u.Common.Models
{
    public partial class desiclothingContext : DbContext
    {
        public desiclothingContext()
        {
        }

        //public desiclothingContext(DbContextOptions<desiclothingContext> options)
        //    : base(options)
        //{
        //}
        public desiclothingContext(DbContextOptions<desiclothingContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public virtual DbSet<AclRecord> AclRecords { get; set; }
        public virtual DbSet<ActivityLog> ActivityLogs { get; set; }
        public virtual DbSet<ActivityLogType> ActivityLogTypes { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AddressAttribute> AddressAttributes { get; set; }
        public virtual DbSet<AddressAttributeValue> AddressAttributeValues { get; set; }
        public virtual DbSet<Affiliate> Affiliates { get; set; }
        public virtual DbSet<BackInStockSubscription> BackInStockSubscriptions { get; set; }
        public virtual DbSet<Campaign> Campaigns { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CategoryTemplate> CategoryTemplates { get; set; }
        public virtual DbSet<CheckoutAttribute> CheckoutAttributes { get; set; }
        public virtual DbSet<CheckoutAttributeValue> CheckoutAttributeValues { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossSellProduct> CrossSellProducts { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public virtual DbSet<CustomerAttribute> CustomerAttributes { get; set; }
        public virtual DbSet<CustomerAttributeValue> CustomerAttributeValues { get; set; }
        public virtual DbSet<CustomerCustomerRoleMapping> CustomerCustomerRoleMappings { get; set; }
        public virtual DbSet<CustomerPassword> CustomerPasswords { get; set; }
        public virtual DbSet<CustomerRole> CustomerRoles { get; set; }
        public virtual DbSet<DeliveryDate> DeliveryDates { get; set; }
        public virtual DbSet<Discount> Discounts { get; set; }
        public virtual DbSet<DiscountAppliedToCategory> DiscountAppliedToCategories { get; set; }
        public virtual DbSet<DiscountAppliedToManufacturer> DiscountAppliedToManufacturers { get; set; }
        public virtual DbSet<DiscountAppliedToProduct> DiscountAppliedToProducts { get; set; }
        public virtual DbSet<DiscountRequirement> DiscountRequirements { get; set; }
        public virtual DbSet<DiscountUsageHistory> DiscountUsageHistories { get; set; }
        public virtual DbSet<Download> Downloads { get; set; }
        public virtual DbSet<EmailAccount> EmailAccounts { get; set; }
        public virtual DbSet<ExternalAuthenticationRecord> ExternalAuthenticationRecords { get; set; }
        public virtual DbSet<FacebookPixelConfiguration> FacebookPixelConfigurations { get; set; }
        public virtual DbSet<GdprConsent> GdprConsents { get; set; }
        public virtual DbSet<GdprLog> GdprLogs { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttributes { get; set; }
        public virtual DbSet<GiftCard> GiftCards { get; set; }
        public virtual DbSet<GiftCardUsageHistory> GiftCardUsageHistories { get; set; }
        public virtual DbSet<Language> Languages { get; set; }
        public virtual DbSet<LocaleStringResource> LocaleStringResources { get; set; }
        public virtual DbSet<LocalizedProperty> LocalizedProperties { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<ManufacturerTemplate> ManufacturerTemplates { get; set; }
        public virtual DbSet<MeasureDimension> MeasureDimensions { get; set; }
        public virtual DbSet<MeasureWeight> MeasureWeights { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplates { get; set; }
        public virtual DbSet<MigrationVersionInfo> MigrationVersionInfos { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<NewsComment> NewsComments { get; set; }
        public virtual DbSet<NewsLetterSubscription> NewsLetterSubscriptions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderNote> OrderNotes { get; set; }
        public virtual DbSet<PermissionRecord> PermissionRecords { get; set; }
        public virtual DbSet<PermissionRecordRoleMapping> PermissionRecordRoleMappings { get; set; }
        public virtual DbSet<Picture> Pictures { get; set; }
        public virtual DbSet<PictureBinary> PictureBinaries { get; set; }
        public virtual DbSet<Poll> Polls { get; set; }
        public virtual DbSet<PollAnswer> PollAnswers { get; set; }
        public virtual DbSet<PollVotingRecord> PollVotingRecords { get; set; }
        public virtual DbSet<PredefinedProductAttributeValue> PredefinedProductAttributeValues { get; set; }
        public virtual DbSet<Product> Products { get; set; }

        public virtual DbSet<productExt> productExts { get; set; }
        public virtual DbSet<ProductAttribute> ProductAttributes { get; set; }
        public virtual DbSet<ProductAttributeCombination> ProductAttributeCombinations { get; set; }
        public virtual DbSet<ProductAttributeValue> ProductAttributeValues { get; set; }
        public virtual DbSet<ProductAvailabilityRange> ProductAvailabilityRanges { get; set; }
        public virtual DbSet<ProductCategoryMapping> ProductCategoryMappings { get; set; }
        public virtual DbSet<ProductManufacturerMapping> ProductManufacturerMappings { get; set; }
        public virtual DbSet<ProductPictureMapping> ProductPictureMappings { get; set; }
        public virtual DbSet<ProductProductAttributeMapping> ProductProductAttributeMappings { get; set; }
        public virtual DbSet<ProductProductTagMapping> ProductProductTagMappings { get; set; }
        public virtual DbSet<ProductReview> ProductReviews { get; set; }
        public virtual DbSet<ProductReviewHelpfulness> ProductReviewHelpfulnesses { get; set; }
        public virtual DbSet<ProductReviewReviewTypeMapping> ProductReviewReviewTypeMappings { get; set; }
        public virtual DbSet<ProductSpecificationAttributeMapping> ProductSpecificationAttributeMappings { get; set; }
        public virtual DbSet<ProductTag> ProductTags { get; set; }
        public virtual DbSet<ProductTemplate> ProductTemplates { get; set; }
        public virtual DbSet<ProductWarehouseInventory> ProductWarehouseInventories { get; set; }
        public virtual DbSet<QueuedEmail> QueuedEmails { get; set; }
        public virtual DbSet<RecurringPayment> RecurringPayments { get; set; }
        public virtual DbSet<RecurringPaymentHistory> RecurringPaymentHistories { get; set; }
        public virtual DbSet<RelatedProduct> RelatedProducts { get; set; }
        public virtual DbSet<ReturnRequest> ReturnRequests { get; set; }
        public virtual DbSet<ReturnRequestAction> ReturnRequestActions { get; set; }
        public virtual DbSet<ReturnRequestReason> ReturnRequestReasons { get; set; }
        public virtual DbSet<ReviewType> ReviewTypes { get; set; }
        public virtual DbSet<RewardPointsHistory> RewardPointsHistories { get; set; }
        public virtual DbSet<ScheduleTask> ScheduleTasks { get; set; }
        public virtual DbSet<SearchTerm> SearchTerms { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<Shipment> Shipments { get; set; }
        public virtual DbSet<ShipmentItem> ShipmentItems { get; set; }
        public virtual DbSet<ShippingByWeightByTotalRecord> ShippingByWeightByTotalRecords { get; set; }
        public virtual DbSet<ShippingMethod> ShippingMethods { get; set; }
        public virtual DbSet<ShippingMethodRestriction> ShippingMethodRestrictions { get; set; }
        public virtual DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public virtual DbSet<SpecificationAttribute> SpecificationAttributes { get; set; }
        public virtual DbSet<SpecificationAttributeOption> SpecificationAttributeOptions { get; set; }
        public virtual DbSet<StateProvince> StateProvinces { get; set; }
        public virtual DbSet<StockQuantityHistory> StockQuantityHistories { get; set; }
        public virtual DbSet<Store> Stores { get; set; }
        public virtual DbSet<StoreMapping> StoreMappings { get; set; }
        public virtual DbSet<StorePickupPoint> StorePickupPoints { get; set; }
        public virtual DbSet<TaxCategory> TaxCategories { get; set; }
        public virtual DbSet<TaxRate> TaxRates { get; set; }
        public virtual DbSet<TaxTransactionLog> TaxTransactionLogs { get; set; }
        public virtual DbSet<TierPrice> TierPrices { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<TopicTemplate> TopicTemplates { get; set; }
        public virtual DbSet<UrlRecord> UrlRecords { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<VendorAttribute> VendorAttributes { get; set; }
        public virtual DbSet<VendorAttributeValue> VendorAttributeValues { get; set; }
        public virtual DbSet<VendorBankDetail> VendorBankDetails { get; set; }
        public virtual DbSet<VendorNote> VendorNotes { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
        //added by SM on Nov 20, 2020
        public virtual DbSet<ProductByVendor> ProductByVendors { get; set; }
        //added by SM on Dec 5, 2020
        public virtual DbSet<Cart> Carts { get; set; }

        public virtual DbSet<CustOrderItems> CustOrderItems { get; set; }
        //on Dec 26, 2020
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<CompletedOrder> CompletedOrder { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-GO81RKT\\MARS ; Database=desiclothing; user id= mars ; password = mars;");

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AclRecord>(entity =>
            {
                entity.ToTable("AclRecord");

                entity.HasIndex(e => e.CustomerRoleId, "IX_AclRecord_CustomerRoleId");

                entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_AclRecord_EntityId_EntityName");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.AclRecords)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_AclRecord_CustomerRoleId_CustomerRole_Id");
            });

            modelBuilder.Entity<ActivityLog>(entity =>
            {
                entity.ToTable("ActivityLog");

                entity.HasIndex(e => e.ActivityLogTypeId, "IX_ActivityLog_ActivityLogTypeId");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_ActivityLog_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_ActivityLog_CustomerId");

                entity.Property(e => e.Comment).IsRequired();

                entity.Property(e => e.EntityName).HasMaxLength(400);

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.HasOne(d => d.ActivityLogType)
                    .WithMany(p => p.ActivityLogs)
                    .HasForeignKey(d => d.ActivityLogTypeId)
                    .HasConstraintName("FK_ActivityLog_ActivityLogTypeId_ActivityLogType_Id");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.ActivityLogs)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_ActivityLog_CustomerId_Customer_Id");
            });
            modelBuilder.Entity<CompletedOrder>(entity =>
            {
                entity.ToTable("CompletedOrder");
           });
            modelBuilder.Entity<ActivityLogType>(entity =>
            {
                entity.ToTable("ActivityLogType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.ToTable("Address");

                entity.HasIndex(e => e.CountryId, "IX_Address_CountryId");

                entity.HasIndex(e => e.StateProvinceId, "IX_Address_StateProvinceId");

                //entity.HasOne(d => d.Country)
                //    .WithMany(p => p.Addresses)
                //    .HasForeignKey(d => d.CountryId)
                //    .HasConstraintName("FK_Address_CountryId_Country_Id");

                //entity.HasOne(d => d.StateProvince)
                //    .WithMany(p => p.Addresses)
                //    .HasForeignKey(d => d.StateProvinceId)
                //    .HasConstraintName("FK_Address_StateProvinceId_StateProvince_Id");
            });

            modelBuilder.Entity<AddressAttribute>(entity =>
            {
                entity.ToTable("AddressAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<AddressAttributeValue>(entity =>
            {
                entity.ToTable("AddressAttributeValue");

                entity.HasIndex(e => e.AddressAttributeId, "IX_AddressAttributeValue_AddressAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.AddressAttribute)
                    .WithMany(p => p.AddressAttributeValues)
                    .HasForeignKey(d => d.AddressAttributeId)
                    .HasConstraintName("FK_AddressAttributeValue_AddressAttributeId_AddressAttribute_Id");
            });

            modelBuilder.Entity<Affiliate>(entity =>
            {
                entity.ToTable("Affiliate");

                entity.HasIndex(e => e.AddressId, "IX_Affiliate_AddressId");

                //entity.HasOne(d => d.Address)
                //    .WithMany(p => p.Affiliates)
                //    .HasForeignKey(d => d.AddressId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Affiliate_AddressId_Address_Id");
            });

            modelBuilder.Entity<BackInStockSubscription>(entity =>
            {
                entity.ToTable("BackInStockSubscription");

                entity.HasIndex(e => e.CustomerId, "IX_BackInStockSubscription_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_BackInStockSubscription_ProductId");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.BackInStockSubscriptions)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_BackInStockSubscription_CustomerId_Customer_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.BackInStockSubscriptions)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_BackInStockSubscription_ProductId_Product_Id");
            });

            modelBuilder.Entity<Campaign>(entity =>
            {
                entity.ToTable("Campaign");

                entity.Property(e => e.Body).IsRequired();

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Subject).IsRequired();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasIndex(e => e.Deleted, "IX_Category_Deleted_Extended")
                    .IncludeProperties(new[] { "Id", "Name", "SubjectToAcl", "LimitedToStores", "Published" });

                entity.HasIndex(e => e.DisplayOrder, "IX_Category_DisplayOrder");

                entity.HasIndex(e => e.LimitedToStores, "IX_Category_LimitedToStores");

                entity.HasIndex(e => e.ParentCategoryId, "IX_Category_ParentCategoryId");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Category_SubjectToAcl");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<CategoryTemplate>(entity =>
            {
                entity.ToTable("CategoryTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttribute>(entity =>
            {
                entity.ToTable("CheckoutAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CheckoutAttributeValue>(entity =>
            {
                entity.ToTable("CheckoutAttributeValue");

                entity.HasIndex(e => e.CheckoutAttributeId, "IX_CheckoutAttributeValue_CheckoutAttributeId");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.CheckoutAttribute)
                    .WithMany(p => p.CheckoutAttributeValues)
                    .HasForeignKey(d => d.CheckoutAttributeId)
                    .HasConstraintName("FK_CheckoutAttributeValue_CheckoutAttributeId_CheckoutAttribute_Id");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.HasIndex(e => e.DisplayOrder, "IX_Country_DisplayOrder");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ThreeLetterIsoCode).HasMaxLength(3);

                entity.Property(e => e.TwoLetterIsoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<CrossSellProduct>(entity =>
            {
                entity.ToTable("CrossSellProduct");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.ToTable("Currency");

                entity.HasIndex(e => e.DisplayOrder, "IX_Currency_DisplayOrder");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CustomFormatting).HasMaxLength(50);

                entity.Property(e => e.DisplayLocale).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rate)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.BillingAddressId, "IX_Customer_BillingAddress_Id");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Customer_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerGuid, "IX_Customer_CustomerGuid");

                entity.HasIndex(e => e.Email, "IX_Customer_Email");

                entity.HasIndex(e => e.ShippingAddressId, "IX_Customer_ShippingAddress_Id");

                entity.HasIndex(e => e.SystemName, "IX_Customer_SystemName");

                entity.HasIndex(e => e.Username, "IX_Customer_Username");

                entity.Property(e => e.Apitoken)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("APIToken");
                entity.Property(e => e.Password)
                   .HasMaxLength(256)
                   .IsUnicode(false)
                   .HasColumnName("Password");

                entity.Property(e => e.BillingAddressId).HasColumnName("BillingAddress_Id");

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.EmailToRevalidate).HasMaxLength(1000);

                entity.Property(e => e.ShippingAddressId).HasColumnName("ShippingAddress_Id");

                entity.Property(e => e.SystemName).HasMaxLength(400);

                entity.Property(e => e.Username).HasMaxLength(1000);

                //entity.HasOne(d => d.BillingAddress)
                //    .WithMany(p => p.CustomerBillingAddresses)
                //    .HasForeignKey(d => d.BillingAddressId)
                //    .HasConstraintName("FK_Customer_BillingAddress_Id_Address_Id");

                //entity.HasOne(d => d.ShippingAddress)
                //    .WithMany(p => p.CustomerShippingAddresses)
                //    .HasForeignKey(d => d.ShippingAddressId)
                //    .HasConstraintName("FK_Customer_ShippingAddress_Id_Address_Id");
            });

            modelBuilder.Entity<CustomerAddress>(entity =>
            {
                entity.HasKey(e => new { e.AddressId, e.CustomerId });

                entity.HasIndex(e => e.AddressId, "IX_CustomerAddresses_Address_Id");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerAddresses_Customer_Id");

                entity.Property(e => e.AddressId).HasColumnName("Address_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                //entity.HasOne(d => d.Address)
                //    .WithMany(p => p.CustomerAddresses)
                //    .HasForeignKey(d => d.AddressId)
                //    .HasConstraintName("FK_CustomerAddresses_Address_Id_Address_Id");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.CustomerAddresses)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_CustomerAddresses_Customer_Id_Customer_Id");
            });

            modelBuilder.Entity<CustomerAttribute>(entity =>
            {
                entity.ToTable("CustomerAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<CustomerAttributeValue>(entity =>
            {
                entity.ToTable("CustomerAttributeValue");

                entity.HasIndex(e => e.CustomerAttributeId, "IX_CustomerAttributeValue_CustomerAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.CustomerAttribute)
                    .WithMany(p => p.CustomerAttributeValues)
                    .HasForeignKey(d => d.CustomerAttributeId)
                    .HasConstraintName("FK_CustomerAttributeValue_CustomerAttributeId_CustomerAttribute_Id");
            });

            modelBuilder.Entity<CustomerCustomerRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.CustomerRoleId });

                entity.ToTable("Customer_CustomerRole_Mapping");

                entity.HasIndex(e => e.CustomerRoleId, "IX_Customer_CustomerRole_Mapping_CustomerRole_Id");

                entity.HasIndex(e => e.CustomerId, "IX_Customer_CustomerRole_Mapping_Customer_Id");

                entity.Property(e => e.CustomerId).HasColumnName("Customer_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.CustomerCustomerRoleMappings)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_Customer_CustomerRole_Mapping_Customer_Id_Customer_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.CustomerCustomerRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_Customer_CustomerRole_Mapping_CustomerRole_Id_CustomerRole_Id");
            });

            modelBuilder.Entity<CustomerPassword>(entity =>
            {
                entity.ToTable("CustomerPassword");

                entity.HasIndex(e => e.CustomerId, "IX_CustomerPassword_CustomerId");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.CustomerPasswords)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_CustomerPassword_CustomerId_Customer_Id");
            });

            modelBuilder.Entity<CustomerRole>(entity =>
            {
                entity.ToTable("CustomerRole");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SystemName).HasMaxLength(255);
            });

            modelBuilder.Entity<DeliveryDate>(entity =>
            {
                entity.ToTable("DeliveryDate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Discount>(entity =>
            {
                entity.ToTable("Discount");

                entity.Property(e => e.CouponCode).HasMaxLength(100);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.DiscountPercentage)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.MaximumDiscountAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DiscountAppliedToCategory>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.CategoryId });

                entity.ToTable("Discount_AppliedToCategories");

                entity.HasIndex(e => e.CategoryId, "IX_Discount_AppliedToCategories_Category_Id");

                entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToCategories_Discount_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.DiscountAppliedToCategories)
                //    .HasForeignKey(d => d.CategoryId)
                //    .HasConstraintName("FK_Discount_AppliedToCategories_Category_Id_Category_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToCategories)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToCategories_Discount_Id_Discount_Id");
            });

            modelBuilder.Entity<DiscountAppliedToManufacturer>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ManufacturerId });

                entity.ToTable("Discount_AppliedToManufacturers");

                entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToManufacturers_Discount_Id");

                entity.HasIndex(e => e.ManufacturerId, "IX_Discount_AppliedToManufacturers_Manufacturer_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ManufacturerId).HasColumnName("Manufacturer_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToManufacturers_Discount_Id_Discount_Id");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.DiscountAppliedToManufacturers)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Discount_AppliedToManufacturers_Manufacturer_Id_Manufacturer_Id");
            });

            modelBuilder.Entity<DiscountAppliedToProduct>(entity =>
            {
                entity.HasKey(e => new { e.DiscountId, e.ProductId });

                entity.ToTable("Discount_AppliedToProducts");

                entity.HasIndex(e => e.DiscountId, "IX_Discount_AppliedToProducts_Discount_Id");

                entity.HasIndex(e => e.ProductId, "IX_Discount_AppliedToProducts_Product_Id");

                entity.Property(e => e.DiscountId).HasColumnName("Discount_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountAppliedToProducts)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_Discount_AppliedToProducts_Discount_Id_Discount_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.DiscountAppliedToProducts)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Discount_AppliedToProducts_Product_Id_Product_Id");
            });

            modelBuilder.Entity<DiscountRequirement>(entity =>
            {
                entity.ToTable("DiscountRequirement");

                entity.HasIndex(e => e.DiscountId, "IX_DiscountRequirement_DiscountId");

                entity.HasIndex(e => e.ParentId, "IX_DiscountRequirement_ParentId");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountRequirements)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountRequirement_DiscountId_Discount_Id");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_DiscountRequirement_ParentId_DiscountRequirement_Id");
            });

            modelBuilder.Entity<DiscountUsageHistory>(entity =>
            {
                entity.ToTable("DiscountUsageHistory");

                entity.HasIndex(e => e.DiscountId, "IX_DiscountUsageHistory_DiscountId");

                entity.HasIndex(e => e.OrderId, "IX_DiscountUsageHistory_OrderId");

                entity.HasOne(d => d.Discount)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.DiscountId)
                    .HasConstraintName("FK_DiscountUsageHistory_DiscountId_Discount_Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.DiscountUsageHistories)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_DiscountUsageHistory_OrderId_Order_Id");
            });

            modelBuilder.Entity<Download>(entity =>
            {
                entity.ToTable("Download");
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.ToTable("EmailAccount");

                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<ExternalAuthenticationRecord>(entity =>
            {
                entity.ToTable("ExternalAuthenticationRecord");

                entity.HasIndex(e => e.CustomerId, "IX_ExternalAuthenticationRecord_CustomerId");

                entity.Property(e => e.OauthAccessToken).HasColumnName("OAuthAccessToken");

                entity.Property(e => e.OauthToken).HasColumnName("OAuthToken");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.ExternalAuthenticationRecords)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_ExternalAuthenticationRecord_CustomerId_Customer_Id");
            });

            modelBuilder.Entity<FacebookPixelConfiguration>(entity =>
            {
                entity.ToTable("FacebookPixelConfiguration");
            });

            modelBuilder.Entity<GdprConsent>(entity =>
            {
                entity.ToTable("GdprConsent");

                entity.Property(e => e.Message).IsRequired();
            });

            modelBuilder.Entity<GdprLog>(entity =>
            {
                entity.ToTable("GdprLog");
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.ToTable("GenericAttribute");

                entity.HasIndex(e => new { e.EntityId, e.KeyGroup }, "IX_GenericAttribute_EntityId_and_KeyGroup");

                entity.Property(e => e.CreatedOrUpdatedDateUtc).HasColumnName("CreatedOrUpdatedDateUTC");

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<GiftCard>(entity =>
            {
                entity.ToTable("GiftCard");

                entity.HasIndex(e => e.PurchasedWithOrderItemId, "IX_GiftCard_PurchasedWithOrderItemId");

                entity.Property(e => e.Amount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.PurchasedWithOrderItem)
                    .WithMany(p => p.GiftCards)
                    .HasForeignKey(d => d.PurchasedWithOrderItemId)
                    .HasConstraintName("FK_GiftCard_PurchasedWithOrderItemId_OrderItem_Id");
            });

            modelBuilder.Entity<GiftCardUsageHistory>(entity =>
            {
                entity.ToTable("GiftCardUsageHistory");

                entity.HasIndex(e => e.GiftCardId, "IX_GiftCardUsageHistory_GiftCardId");

                entity.HasIndex(e => e.UsedWithOrderId, "IX_GiftCardUsageHistory_UsedWithOrderId");

                entity.Property(e => e.UsedValue)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.GiftCard)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.GiftCardId)
                    .HasConstraintName("FK_GiftCardUsageHistory_GiftCardId_GiftCard_Id");

                entity.HasOne(d => d.UsedWithOrder)
                    .WithMany(p => p.GiftCardUsageHistories)
                    .HasForeignKey(d => d.UsedWithOrderId)
                    .HasConstraintName("FK_GiftCardUsageHistory_UsedWithOrderId_Order_Id");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.ToTable("Language");

                entity.HasIndex(e => e.DisplayOrder, "IX_Language_DisplayOrder");

                entity.Property(e => e.FlagImageFileName).HasMaxLength(50);

                entity.Property(e => e.LanguageCulture)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UniqueSeoCode).HasMaxLength(2);
            });

            modelBuilder.Entity<LocaleStringResource>(entity =>
            {
                entity.ToTable("LocaleStringResource");

                entity.HasIndex(e => new { e.ResourceName, e.LanguageId }, "IX_LocaleStringResource");

                entity.HasIndex(e => e.LanguageId, "IX_LocaleStringResource_LanguageId");

                entity.Property(e => e.ResourceName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ResourceValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocaleStringResources)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LocaleStringResource_LanguageId_Language_Id");
            });

            modelBuilder.Entity<LocalizedProperty>(entity =>
            {
                entity.ToTable("LocalizedProperty");

                entity.HasIndex(e => e.LanguageId, "IX_LocalizedProperty_LanguageId");

                entity.Property(e => e.LocaleKey)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleKeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.LocaleValue).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.LocalizedProperties)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_LocalizedProperty_LanguageId_Language_Id");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.ToTable("Log");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Log_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_Log_CustomerId");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.ShortMessage).IsRequired();

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.Logs)
                //    .HasForeignKey(d => d.CustomerId)
                //    .OnDelete(DeleteBehavior.Cascade)
                //    .HasConstraintName("FK_Log_CustomerId_Customer_Id");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.ToTable("Manufacturer");

                entity.HasIndex(e => e.DisplayOrder, "IX_Manufacturer_DisplayOrder");

                entity.HasIndex(e => e.LimitedToStores, "IX_Manufacturer_LimitedToStores");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Manufacturer_SubjectToAcl");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);

                entity.Property(e => e.PriceRanges).HasMaxLength(400);
            });

            modelBuilder.Entity<ManufacturerTemplate>(entity =>
            {
                entity.ToTable("ManufacturerTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<MeasureDimension>(entity =>
            {
                entity.ToTable("MeasureDimension");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio)
                    .HasColumnType("decimal(18, 8)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MeasureWeight>(entity =>
            {
                entity.ToTable("MeasureWeight");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio)
                    .HasColumnType("decimal(18, 8)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 8)");

                entity.Property(e => e.SystemKeyword)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.ToTable("MessageTemplate");

                entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<MigrationVersionInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("MigrationVersionInfo");

                entity.HasIndex(e => e.Version, "UC_Version")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.AppliedOn)
                    .HasColumnType("datetime")
                    .HasAnnotation("Relational:ColumnType", "datetime");

                entity.Property(e => e.Description).HasMaxLength(1024);
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.HasIndex(e => e.LanguageId, "IX_News_LanguageId");

                entity.Property(e => e.Full).IsRequired();

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Short).IsRequired();

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.News)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_News_LanguageId_Language_Id");
            });

            modelBuilder.Entity<NewsComment>(entity =>
            {
                entity.ToTable("NewsComment");

                entity.HasIndex(e => e.CustomerId, "IX_NewsComment_CustomerId");

                entity.HasIndex(e => e.NewsItemId, "IX_NewsComment_NewsItemId");

                entity.HasIndex(e => e.StoreId, "IX_NewsComment_StoreId");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.NewsComments)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_NewsComment_CustomerId_Customer_Id");

                entity.HasOne(d => d.NewsItem)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.NewsItemId)
                    .HasConstraintName("FK_NewsComment_NewsItemId_News_Id");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.NewsComments)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_NewsComment_StoreId_Store_Id");
            });

            modelBuilder.Entity<NewsLetterSubscription>(entity =>
            {
                entity.ToTable("NewsLetterSubscription");

                entity.HasIndex(e => new { e.Email, e.StoreId }, "IX_NewsletterSubscription_Email_StoreId");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.HasIndex(e => e.BillingAddressId, "IX_Order_BillingAddressId");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_Order_CreatedOnUtc");

                entity.HasIndex(e => e.CustomerId, "IX_Order_CustomerId");

                entity.HasIndex(e => e.PickupAddressId, "IX_Order_PickupAddressId");

                entity.HasIndex(e => e.ShippingAddressId, "IX_Order_ShippingAddressId");

                entity.Property(e => e.CurrencyRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.CustomOrderNumber).IsRequired();

                entity.Property(e => e.OrderDiscount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderShippingExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderShippingInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderSubTotalDiscountInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderSubtotalInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OrderTotal)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.PaymentMethodAdditionalFeeInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.RefundedAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                //entity.HasOne(d => d.BillingAddress)
                //    .WithMany(p => p.OrderBillingAddresses)
                //    .HasForeignKey(d => d.BillingAddressId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Order_BillingAddressId_Address_Id");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.Orders)
                //    .HasForeignKey(d => d.CustomerId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK_Order_CustomerId_Customer_Id");

                //entity.HasOne(d => d.PickupAddress)
                //    .WithMany(p => p.OrderPickupAddresses)
                //    .HasForeignKey(d => d.PickupAddressId)
                //    .HasConstraintName("FK_Order_PickupAddressId_Address_Id");

                entity.HasOne(d => d.RewardPointsHistoryEntry)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.RewardPointsHistoryEntryId)
                    .HasConstraintName("FK_Order_RewardPointsHistoryEntryId_RewardPointsHistory_Id");

                //entity.HasOne(d => d.ShippingAddress)
                //    .WithMany(p => p.OrderShippingAddresses)
                //    .HasForeignKey(d => d.ShippingAddressId)
                //    .HasConstraintName("FK_Order_ShippingAddressId_Address_Id");
            });

            modelBuilder.Entity<OrderItem>(entity =>
            {
                entity.ToTable("OrderItem");

                entity.HasIndex(e => e.OrderId, "IX_OrderItem_OrderId");

                entity.HasIndex(e => e.ProductId, "IX_OrderItem_ProductId");

                entity.Property(e => e.DiscountAmountExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.DiscountAmountInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.ItemWeight)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OriginalProductCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.PriceExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.PriceInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.UnitPriceExclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.UnitPriceInclTax)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                //entity.HasOne(d => d.Order)
                //    .WithMany(p => p.OrderItems)
                //    .HasForeignKey(d => d.OrderId)
                //    .HasConstraintName("FK_OrderItem_OrderId_Order_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.OrderItems)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_OrderItem_ProductId_Product_Id");
            });

            modelBuilder.Entity<OrderNote>(entity =>
            {
                entity.ToTable("OrderNote");

                entity.HasIndex(e => e.OrderId, "IX_OrderNote_OrderId");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderNotes)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderNote_OrderId_Order_Id");
            });

            modelBuilder.Entity<PermissionRecord>(entity =>
            {
                entity.ToTable("PermissionRecord");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<PermissionRecordRoleMapping>(entity =>
            {
                entity.HasKey(e => new { e.PermissionRecordId, e.CustomerRoleId });

                entity.ToTable("PermissionRecord_Role_Mapping");

                entity.HasIndex(e => e.CustomerRoleId, "IX_PermissionRecord_Role_Mapping_CustomerRole_Id");

                entity.HasIndex(e => e.PermissionRecordId, "IX_PermissionRecord_Role_Mapping_PermissionRecord_Id");

                entity.Property(e => e.PermissionRecordId).HasColumnName("PermissionRecord_Id");

                entity.Property(e => e.CustomerRoleId).HasColumnName("CustomerRole_Id");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .HasConstraintName("FK_PermissionRecord_Role_Mapping_CustomerRole_Id_CustomerRole_Id");

                entity.HasOne(d => d.PermissionRecord)
                    .WithMany(p => p.PermissionRecordRoleMappings)
                    .HasForeignKey(d => d.PermissionRecordId)
                    .HasConstraintName("FK_PermissionRecord_Role_Mapping_PermissionRecord_Id_PermissionRecord_Id");
            });

            modelBuilder.Entity<Picture>(entity =>
            {
                entity.ToTable("Picture");

                entity.Property(e => e.MimeType)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SeoFilename).HasMaxLength(300);
            });

            modelBuilder.Entity<PictureBinary>(entity =>
            {
                entity.ToTable("PictureBinary");

                entity.HasIndex(e => e.PictureId, "IX_PictureBinary_PictureId");

                //entity.HasOne(d => d.Picture)
                //    .WithMany(p => p.PictureBinaries)
                //    .HasForeignKey(d => d.PictureId)
                //    .HasConstraintName("FK_PictureBinary_PictureId_Picture_Id");
            });

            modelBuilder.Entity<Poll>(entity =>
            {
                entity.ToTable("Poll");

                entity.HasIndex(e => e.LanguageId, "IX_Poll_LanguageId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Language)
                    .WithMany(p => p.Polls)
                    .HasForeignKey(d => d.LanguageId)
                    .HasConstraintName("FK_Poll_LanguageId_Language_Id");
            });

            modelBuilder.Entity<PollAnswer>(entity =>
            {
                entity.ToTable("PollAnswer");

                entity.HasIndex(e => e.PollId, "IX_PollAnswer_PollId");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Poll)
                    .WithMany(p => p.PollAnswers)
                    .HasForeignKey(d => d.PollId)
                    .HasConstraintName("FK_PollAnswer_PollId_Poll_Id");
            });
            modelBuilder.Entity<VendorBankDetail>(entity =>
            {
                entity.ToTable("VendorBankDetails");
                //dec 23, 2020
                //entity.HasOne(d => d.Vendor)
                //    .WithMany(p => p.VendorBankDetail)
                //    .HasForeignKey(d => d.Id)
                //    .HasConstraintName("FK__VendorBan__Vendo__1F2E9E6D");
            });
            modelBuilder.Entity<PollVotingRecord>(entity =>
            {
                entity.ToTable("PollVotingRecord");

                entity.HasIndex(e => e.CustomerId, "IX_PollVotingRecord_CustomerId");

                entity.HasIndex(e => e.PollAnswerId, "IX_PollVotingRecord_PollAnswerId");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.PollVotingRecords)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_PollVotingRecord_CustomerId_Customer_Id");

                entity.HasOne(d => d.PollAnswer)
                    .WithMany(p => p.PollVotingRecords)
                    .HasForeignKey(d => d.PollAnswerId)
                    .HasConstraintName("FK_PollVotingRecord_PollAnswerId_PollAnswer_Id");
            });

            modelBuilder.Entity<PredefinedProductAttributeValue>(entity =>
            {
                entity.ToTable("PredefinedProductAttributeValue");

                entity.HasIndex(e => e.ProductAttributeId, "IX_PredefinedProductAttributeValue_ProductAttributeId");

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.PredefinedProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_PredefinedProductAttributeValue_ProductAttributeId_ProductAttribute_Id");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasIndex(e => new { e.Deleted, e.VendorId, e.ProductTypeId, e.ManageInventoryMethodId, e.MinStockQuantity, e.UseMultipleWarehouses }, "IX_GetLowStockProducts");

                entity.HasIndex(e => new { e.Deleted, e.Id }, "IX_Product_Delete_Id");

                entity.HasIndex(e => new { e.Published, e.Deleted }, "IX_Product_Deleted_and_Published");

                entity.HasIndex(e => e.LimitedToStores, "IX_Product_LimitedToStores");

                entity.HasIndex(e => e.ParentGroupedProductId, "IX_Product_ParentGroupedProductId");

                entity.HasIndex(e => new { e.Price, e.AvailableStartDateTimeUtc, e.AvailableEndDateTimeUtc, e.Published, e.Deleted }, "IX_Product_PriceDatesEtc");

                entity.HasIndex(e => e.Published, "IX_Product_Published");

                entity.HasIndex(e => e.ShowOnHomepage, "IX_Product_ShowOnHomepage");

                entity.HasIndex(e => e.SubjectToAcl, "IX_Product_SubjectToAcl");

                entity.HasIndex(e => e.VisibleIndividually, "IX_Product_VisibleIndividually");

                entity.HasIndex(e => new { e.VisibleIndividually, e.Published, e.Deleted }, "IX_Product_VisibleIndividually_Published_Deleted_Extended")
                    .IncludeProperties(new[] { "Id", "AvailableStartDateTimeUtc", "AvailableEndDateTimeUtc" });

                entity.Property(e => e.AdditionalShippingCharge)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.AllowedQuantities).HasMaxLength(1000);

                entity.Property(e => e.BasepriceAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.BasepriceBaseAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.MaximumCustomerEnteredPrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.MinimumCustomerEnteredPrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.OldPrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.OverriddenGiftCardAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.ProductCost)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.RequiredProductIds).HasMaxLength(1000);

                entity.Property(e => e.Sku).HasMaxLength(400);

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");
            });

            modelBuilder.Entity<ProductAttribute>(entity =>
            {
                entity.ToTable("ProductAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<ProductAttributeCombination>(entity =>
            {
                entity.ToTable("ProductAttributeCombination");

                entity.HasIndex(e => e.ProductId, "IX_ProductAttributeCombination_ProductId");

                entity.Property(e => e.Gtin).HasMaxLength(400);

                entity.Property(e => e.ManufacturerPartNumber).HasMaxLength(400);

                entity.Property(e => e.OverriddenPrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Sku).HasMaxLength(400);

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductAttributeCombinations)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_ProductAttributeCombination_ProductId_Product_Id");
            });

            modelBuilder.Entity<ProductAttributeValue>(entity =>
            {
                entity.ToTable("ProductAttributeValue");

                entity.HasIndex(e => e.ProductAttributeMappingId, "IX_ProductAttributeValue_ProductAttributeMappingId");

                entity.HasIndex(e => new { e.ProductAttributeMappingId, e.DisplayOrder }, "IX_ProductAttributeValue_ProductAttributeMappingId_DisplayOrder");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Cost)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PriceAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.WeightAdjustment)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.ProductAttributeMapping)
                    .WithMany(p => p.ProductAttributeValues)
                    .HasForeignKey(d => d.ProductAttributeMappingId)
                    .HasConstraintName("FK_ProductAttributeValue_ProductAttributeMappingId_Product_ProductAttribute_Mapping_Id");
            });

            modelBuilder.Entity<ProductAvailabilityRange>(entity =>
            {
                entity.ToTable("ProductAvailabilityRange");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductCategoryMapping>(entity =>
            {
                entity.ToTable("Product_Category_Mapping");

                entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PCM_ProductId_Extended")
                    .IncludeProperties(new[] { "CategoryId" });

                entity.HasIndex(e => new { e.CategoryId, e.ProductId }, "IX_PCM_Product_and_Category");

                entity.HasIndex(e => e.CategoryId, "IX_Product_Category_Mapping_CategoryId");

                entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Category_Mapping_IsFeaturedProduct");

                entity.HasIndex(e => e.ProductId, "IX_Product_Category_Mapping_ProductId");

                //entity.HasOne(d => d.Category)
                //    .WithMany(p => p.ProductCategoryMappings)
                //    .HasForeignKey(d => d.CategoryId)
                //    .HasConstraintName("FK_Product_Category_Mapping_CategoryId_Category_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductCategoryMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_Category_Mapping_ProductId_Product_Id");
            });

            modelBuilder.Entity<ProductManufacturerMapping>(entity =>
            {
                entity.ToTable("Product_Manufacturer_Mapping");

                entity.HasIndex(e => new { e.ProductId, e.IsFeaturedProduct }, "IX_PMM_ProductId_Extended")
                    .IncludeProperties(new[] { "ManufacturerId" });

                entity.HasIndex(e => new { e.ManufacturerId, e.ProductId }, "IX_PMM_Product_and_Manufacturer");

                entity.HasIndex(e => e.IsFeaturedProduct, "IX_Product_Manufacturer_Mapping_IsFeaturedProduct");

                entity.HasIndex(e => e.ManufacturerId, "IX_Product_Manufacturer_Mapping_ManufacturerId");

                entity.HasIndex(e => e.ProductId, "IX_Product_Manufacturer_Mapping_ProductId");

                entity.HasOne(d => d.Manufacturer)
                    .WithMany(p => p.ProductManufacturerMappings)
                    .HasForeignKey(d => d.ManufacturerId)
                    .HasConstraintName("FK_Product_Manufacturer_Mapping_ManufacturerId_Manufacturer_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductManufacturerMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_Manufacturer_Mapping_ProductId_Product_Id");
            });

            modelBuilder.Entity<ProductPictureMapping>(entity =>
            {
                entity.ToTable("Product_Picture_Mapping");

                entity.HasIndex(e => e.PictureId, "IX_Product_Picture_Mapping_PictureId");

                entity.HasIndex(e => e.ProductId, "IX_Product_Picture_Mapping_ProductId");

                //entity.HasOne(d => d.Picture)
                //    .WithMany(p => p.ProductPictureMappings)
                //    .HasForeignKey(d => d.PictureId)
                //    .HasConstraintName("FK_Product_Picture_Mapping_PictureId_Picture_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductPictureMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_Picture_Mapping_ProductId_Product_Id");
            });

            modelBuilder.Entity<ProductProductAttributeMapping>(entity =>
            {
                entity.ToTable("Product_ProductAttribute_Mapping");

                entity.HasIndex(e => e.ProductAttributeId, "IX_Product_ProductAttribute_Mapping_ProductAttributeId");

                entity.HasIndex(e => e.ProductId, "IX_Product_ProductAttribute_Mapping_ProductId");

                entity.HasIndex(e => new { e.ProductId, e.DisplayOrder }, "IX_Product_ProductAttribute_Mapping_ProductId_DisplayOrder");

                entity.HasOne(d => d.ProductAttribute)
                    .WithMany(p => p.ProductProductAttributeMappings)
                    .HasForeignKey(d => d.ProductAttributeId)
                    .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductAttributeId_ProductAttribute_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductProductAttributeMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_ProductAttribute_Mapping_ProductId_Product_Id");
            });

            modelBuilder.Entity<ProductProductTagMapping>(entity =>
            {
                entity.HasKey(e => new { e.ProductId, e.ProductTagId });

                entity.ToTable("Product_ProductTag_Mapping");

                entity.HasIndex(e => e.ProductTagId, "IX_Product_ProductTag_Mapping_ProductTag_Id");

                entity.HasIndex(e => e.ProductId, "IX_Product_ProductTag_Mapping_Product_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductTagId).HasColumnName("ProductTag_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductProductTagMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_ProductTag_Mapping_Product_Id_Product_Id");

                entity.HasOne(d => d.ProductTag)
                    .WithMany(p => p.ProductProductTagMappings)
                    .HasForeignKey(d => d.ProductTagId)
                    .HasConstraintName("FK_Product_ProductTag_Mapping_ProductTag_Id_ProductTag_Id");
            });

            modelBuilder.Entity<ProductReview>(entity =>
            {
                entity.ToTable("ProductReview");

                entity.HasIndex(e => e.CustomerId, "IX_ProductReview_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_ProductReview_ProductId");

                entity.HasIndex(e => e.StoreId, "IX_ProductReview_StoreId");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.ProductReviews)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_ProductReview_CustomerId_Customer_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductReviews)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_ProductReview_ProductId_Product_Id");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.ProductReviews)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_ProductReview_StoreId_Store_Id");
            });

            modelBuilder.Entity<ProductReviewHelpfulness>(entity =>
            {
                entity.ToTable("ProductReviewHelpfulness");

                entity.HasIndex(e => e.ProductReviewId, "IX_ProductReviewHelpfulness_ProductReviewId");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewHelpfulnesses)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("FK_ProductReviewHelpfulness_ProductReviewId_ProductReview_Id");
            });

            modelBuilder.Entity<ProductReviewReviewTypeMapping>(entity =>
            {
                entity.ToTable("ProductReview_ReviewType_Mapping");

                entity.HasIndex(e => e.ProductReviewId, "IX_ProductReview_ReviewType_Mapping_ProductReviewId");

                entity.HasIndex(e => e.ReviewTypeId, "IX_ProductReview_ReviewType_Mapping_ReviewTypeId");

                entity.HasOne(d => d.ProductReview)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ProductReviewId)
                    .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ProductReviewId_ProductReview_Id");

                entity.HasOne(d => d.ReviewType)
                    .WithMany(p => p.ProductReviewReviewTypeMappings)
                    .HasForeignKey(d => d.ReviewTypeId)
                    .HasConstraintName("FK_ProductReview_ReviewType_Mapping_ReviewTypeId_ReviewType_Id");
            });

            modelBuilder.Entity<ProductSpecificationAttributeMapping>(entity =>
            {
                entity.ToTable("Product_SpecificationAttribute_Mapping");

                entity.HasIndex(e => e.AllowFiltering, "IX_PSAM_AllowFiltering")
                    .IncludeProperties(new[] { "ProductId", "SpecificationAttributeOptionId" });

                entity.HasIndex(e => new { e.SpecificationAttributeOptionId, e.AllowFiltering }, "IX_PSAM_SpecificationAttributeOptionId_AllowFiltering")
                    .IncludeProperties(new[] { "ProductId" });

                entity.HasIndex(e => e.ProductId, "IX_Product_SpecificationAttribute_Mapping_ProductId");

                entity.HasIndex(e => e.SpecificationAttributeOptionId, "IX_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId");

                entity.Property(e => e.CustomValue).HasMaxLength(4000);

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductSpecificationAttributeMappings)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_ProductId_Product_Id");

                entity.HasOne(d => d.SpecificationAttributeOption)
                    .WithMany(p => p.ProductSpecificationAttributeMappings)
                    .HasForeignKey(d => d.SpecificationAttributeOptionId)
                    .HasConstraintName("FK_Product_SpecificationAttribute_Mapping_SpecificationAttributeOptionId_SpecificationAttributeOption_Id");
            });

            modelBuilder.Entity<ProductTag>(entity =>
            {
                entity.ToTable("ProductTag");

                entity.HasIndex(e => e.Name, "IX_ProductTag_Name");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductTemplate>(entity =>
            {
                entity.ToTable("ProductTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ProductWarehouseInventory>(entity =>
            {
                entity.ToTable("ProductWarehouseInventory");

                entity.HasIndex(e => e.ProductId, "IX_ProductWarehouseInventory_ProductId");

                entity.HasIndex(e => e.WarehouseId, "IX_ProductWarehouseInventory_WarehouseId");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ProductWarehouseInventories)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_ProductWarehouseInventory_ProductId_Product_Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ProductWarehouseInventories)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("FK_ProductWarehouseInventory_WarehouseId_Warehouse_Id");
            });

            modelBuilder.Entity<QueuedEmail>(entity =>
            {
                entity.ToTable("QueuedEmail");

                entity.HasIndex(e => e.CreatedOnUtc, "IX_QueuedEmail_CreatedOnUtc");

                entity.HasIndex(e => e.EmailAccountId, "IX_QueuedEmail_EmailAccountId");

                entity.HasIndex(e => new { e.SentOnUtc, e.DontSendBeforeDateUtc }, "IX_QueuedEmail_SentOnUtc_DontSendBeforeDateUtc_Extended")
                    .IncludeProperties(new[] { "SentTries" });

                entity.Property(e => e.Bcc).HasMaxLength(500);

                entity.Property(e => e.Cc)
                    .HasMaxLength(500)
                    .HasColumnName("CC");

                entity.Property(e => e.From)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.FromName).HasMaxLength(500);

                entity.Property(e => e.ReplyTo).HasMaxLength(500);

                entity.Property(e => e.ReplyToName).HasMaxLength(500);

                entity.Property(e => e.Subject).HasMaxLength(1000);

                entity.Property(e => e.To)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.ToName).HasMaxLength(500);

                entity.HasOne(d => d.EmailAccount)
                    .WithMany(p => p.QueuedEmails)
                    .HasForeignKey(d => d.EmailAccountId)
                    .HasConstraintName("FK_QueuedEmail_EmailAccountId_EmailAccount_Id");
            });

            modelBuilder.Entity<RecurringPayment>(entity =>
            {
                entity.ToTable("RecurringPayment");

                entity.HasIndex(e => e.InitialOrderId, "IX_RecurringPayment_InitialOrderId");

                entity.HasOne(d => d.InitialOrder)
                    .WithMany(p => p.RecurringPayments)
                    .HasForeignKey(d => d.InitialOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurringPayment_InitialOrderId_Order_Id");
            });

            modelBuilder.Entity<RecurringPaymentHistory>(entity =>
            {
                entity.ToTable("RecurringPaymentHistory");

                entity.HasIndex(e => e.RecurringPaymentId, "IX_RecurringPaymentHistory_RecurringPaymentId");

                entity.HasOne(d => d.RecurringPayment)
                    .WithMany(p => p.RecurringPaymentHistories)
                    .HasForeignKey(d => d.RecurringPaymentId)
                    .HasConstraintName("FK_RecurringPaymentHistory_RecurringPaymentId_RecurringPayment_Id");
            });

            modelBuilder.Entity<RelatedProduct>(entity =>
            {
                entity.ToTable("RelatedProduct");

                entity.HasIndex(e => e.ProductId1, "IX_RelatedProduct_ProductId1");
            });

            modelBuilder.Entity<ReturnRequest>(entity =>
            {
                entity.ToTable("ReturnRequest");

                entity.HasIndex(e => e.CustomerId, "IX_ReturnRequest_CustomerId");

                entity.Property(e => e.ReasonForReturn).IsRequired();

                entity.Property(e => e.RequestedAction).IsRequired();

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.ReturnRequests)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_ReturnRequest_CustomerId_Customer_Id");
            });

            modelBuilder.Entity<ReturnRequestAction>(entity =>
            {
                entity.ToTable("ReturnRequestAction");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReturnRequestReason>(entity =>
            {
                entity.ToTable("ReturnRequestReason");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ReviewType>(entity =>
            {
                entity.ToTable("ReviewType");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<RewardPointsHistory>(entity =>
            {
                entity.ToTable("RewardPointsHistory");

                entity.HasIndex(e => e.CustomerId, "IX_RewardPointsHistory_CustomerId");

                entity.Property(e => e.UsedAmount)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.RewardPointsHistories)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_RewardPointsHistory_CustomerId_Customer_Id");
            });

            modelBuilder.Entity<ScheduleTask>(entity =>
            {
                entity.ToTable("ScheduleTask");

                entity.Property(e => e.Name).IsRequired();

                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<SearchTerm>(entity =>
            {
                entity.ToTable("SearchTerm");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.ToTable("Setting");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<Shipment>(entity =>
            {
                entity.ToTable("Shipment");

                entity.HasIndex(e => e.OrderId, "IX_Shipment_OrderId");

                entity.Property(e => e.TotalWeight)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.Shipments)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_Shipment_OrderId_Order_Id");
            });

            modelBuilder.Entity<ShipmentItem>(entity =>
            {
                entity.ToTable("ShipmentItem");

                entity.HasIndex(e => e.ShipmentId, "IX_ShipmentItem_ShipmentId");

                entity.HasOne(d => d.Shipment)
                    .WithMany(p => p.ShipmentItems)
                    .HasForeignKey(d => d.ShipmentId)
                    .HasConstraintName("FK_ShipmentItem_ShipmentId_Shipment_Id");
            });

            modelBuilder.Entity<ShippingByWeightByTotalRecord>(entity =>
            {
                entity.ToTable("ShippingByWeightByTotalRecord");

                entity.Property(e => e.AdditionalFixedCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.LowerWeightLimit)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.OrderSubtotalFrom)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.OrderSubtotalTo)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.PercentageRateOfSubtotal)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.RatePerWeightUnit)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.WeightFrom)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.WeightTo)
                    .HasColumnType("decimal(18, 2)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 2)");

                entity.Property(e => e.Zip).HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethod>(entity =>
            {
                entity.ToTable("ShippingMethod");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<ShippingMethodRestriction>(entity =>
            {
                entity.HasKey(e => new { e.ShippingMethodId, e.CountryId });

                entity.HasIndex(e => e.CountryId, "IX_ShippingMethodRestrictions_Country_Id");

                entity.HasIndex(e => e.ShippingMethodId, "IX_ShippingMethodRestrictions_ShippingMethod_Id");

                entity.Property(e => e.ShippingMethodId).HasColumnName("ShippingMethod_Id");

                entity.Property(e => e.CountryId).HasColumnName("Country_Id");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_ShippingMethodRestrictions_Country_Id_Country_Id");

                entity.HasOne(d => d.ShippingMethod)
                    .WithMany(p => p.ShippingMethodRestrictions)
                    .HasForeignKey(d => d.ShippingMethodId)
                    .HasConstraintName("FK_ShippingMethodRestrictions_ShippingMethod_Id_ShippingMethod_Id");
            });

            modelBuilder.Entity<ShoppingCartItem>(entity =>
            {
                entity.ToTable("ShoppingCartItem");

                entity.HasIndex(e => e.CustomerId, "IX_ShoppingCartItem_CustomerId");

                entity.HasIndex(e => e.ProductId, "IX_ShoppingCartItem_ProductId");

                entity.HasIndex(e => new { e.ShoppingCartTypeId, e.CustomerId }, "IX_ShoppingCartItem_ShoppingCartTypeId_CustomerId");

                entity.Property(e => e.CustomerEnteredPrice)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                //entity.HasOne(d => d.Customer)
                //    .WithMany(p => p.ShoppingCartItems)
                //    .HasForeignKey(d => d.CustomerId)
                //    .HasConstraintName("FK_ShoppingCartItem_CustomerId_Customer_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.ShoppingCartItems)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_ShoppingCartItem_ProductId_Product_Id");
            });

            modelBuilder.Entity<SpecificationAttribute>(entity =>
            {
                entity.ToTable("SpecificationAttribute");

                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<SpecificationAttributeOption>(entity =>
            {
                entity.ToTable("SpecificationAttributeOption");

                entity.HasIndex(e => e.SpecificationAttributeId, "IX_SpecificationAttributeOption_SpecificationAttributeId");

                entity.Property(e => e.ColorSquaresRgb).HasMaxLength(100);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.SpecificationAttribute)
                    .WithMany(p => p.SpecificationAttributeOptions)
                    .HasForeignKey(d => d.SpecificationAttributeId)
                    .HasConstraintName("FK_SpecificationAttributeOption_SpecificationAttributeId_SpecificationAttribute_Id");
            });

            modelBuilder.Entity<StateProvince>(entity =>
            {
                entity.ToTable("StateProvince");

                entity.HasIndex(e => e.CountryId, "IX_StateProvince_CountryId");

                entity.Property(e => e.Abbreviation).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateProvinces)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateProvince_CountryId_Country_Id");
            });

            modelBuilder.Entity<StockQuantityHistory>(entity =>
            {
                entity.ToTable("StockQuantityHistory");

                entity.HasIndex(e => e.ProductId, "IX_StockQuantityHistory_ProductId");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.StockQuantityHistories)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_StockQuantityHistory_ProductId_Product_Id");
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.ToTable("Store");

                entity.Property(e => e.CompanyAddress).HasMaxLength(1000);

                entity.Property(e => e.CompanyName).HasMaxLength(1000);

                entity.Property(e => e.CompanyPhoneNumber).HasMaxLength(1000);

                entity.Property(e => e.CompanyVat).HasMaxLength(1000);

                entity.Property(e => e.Hosts).HasMaxLength(1000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<StoreMapping>(entity =>
            {
                entity.ToTable("StoreMapping");

                entity.HasIndex(e => new { e.EntityId, e.EntityName }, "IX_StoreMapping_EntityId_EntityName");

                entity.HasIndex(e => e.StoreId, "IX_StoreMapping_StoreId");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreMappings)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FK_StoreMapping_StoreId_Store_Id");
            });

            modelBuilder.Entity<StorePickupPoint>(entity =>
            {
                entity.ToTable("StorePickupPoint");

                entity.Property(e => e.Latitude)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.Longitude)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.Property(e => e.PickupFee)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");
            });

            modelBuilder.Entity<TaxCategory>(entity =>
            {
                entity.ToTable("TaxCategory");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.ToTable("TaxRate");

                entity.Property(e => e.Percentage)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");
            });

            modelBuilder.Entity<TaxTransactionLog>(entity =>
            {
                entity.ToTable("TaxTransactionLog");
            });

            modelBuilder.Entity<TierPrice>(entity =>
            {
                entity.ToTable("TierPrice");

                entity.HasIndex(e => e.CustomerRoleId, "IX_TierPrice_CustomerRoleId");

                entity.HasIndex(e => e.ProductId, "IX_TierPrice_ProductId");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(18, 4)")
                    .HasAnnotation("Relational:ColumnType", "decimal(18, 4)");

                entity.HasOne(d => d.CustomerRole)
                    .WithMany(p => p.TierPrices)
                    .HasForeignKey(d => d.CustomerRoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TierPrice_CustomerRoleId_CustomerRole_Id");

                //entity.HasOne(d => d.Product)
                //    .WithMany(p => p.TierPrices)
                //    .HasForeignKey(d => d.ProductId)
                //    .HasConstraintName("FK_TierPrice_ProductId_Product_Id");
            });

            modelBuilder.Entity<Topic>(entity =>
            {
                entity.ToTable("Topic");
            });

            modelBuilder.Entity<TopicTemplate>(entity =>
            {
                entity.ToTable("TopicTemplate");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.ViewPath)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<UrlRecord>(entity =>
            {
                entity.ToTable("UrlRecord");

                entity.HasIndex(e => new { e.EntityId, e.EntityName, e.LanguageId, e.IsActive }, "IX_UrlRecord_Custom_1");

                entity.HasIndex(e => e.Slug, "IX_UrlRecord_Slug");

                entity.Property(e => e.EntityName)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Slug)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.Email).HasMaxLength(400);

                entity.Property(e => e.MetaKeywords).HasMaxLength(400);

                entity.Property(e => e.MetaTitle).HasMaxLength(400);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.PageSizeOptions).HasMaxLength(200);
            });

            modelBuilder.Entity<VendorAttribute>(entity =>
            {
                entity.ToTable("VendorAttribute");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<VendorAttributeValue>(entity =>
            {
                entity.ToTable("VendorAttributeValue");

                entity.HasIndex(e => e.VendorAttributeId, "IX_VendorAttributeValue_VendorAttributeId");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.HasOne(d => d.VendorAttribute)
                    .WithMany(p => p.VendorAttributeValues)
                    .HasForeignKey(d => d.VendorAttributeId)
                    .HasConstraintName("FK_VendorAttributeValue_VendorAttributeId_VendorAttribute_Id");
            });

            modelBuilder.Entity<VendorBankDetail>(entity =>
            {
                //entity.HasNoKey();

                entity.Property(e => e.AccHolderName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                //for vendorbankdetails
                //entity.HasOne(d => d.Vendor)
                //   .WithMany(p => p.VendorBankDetail)
                //   .HasForeignKey(d => d.VendorId)
                //   .HasConstraintName("FK__VendorBan__Vendo__1F2E9E6D");
            });
            //});

            modelBuilder.Entity<VendorNote>(entity =>
            {
                entity.ToTable("VendorNote");

                entity.HasIndex(e => e.VendorId, "IX_VendorNote_VendorId");

                entity.Property(e => e.Note).IsRequired();

                entity.HasOne(d => d.Vendor)
                    .WithMany(p => p.VendorNotes)
                    .HasForeignKey(d => d.VendorId)
                    .HasConstraintName("FK_VendorNote_VendorId_Vendor_Id");
            });

            modelBuilder.Entity<Warehouse>(entity =>
            {
                entity.ToTable("Warehouse");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(400);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
