using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2.B
{
    public enum ForeignKeyCategories
    {
        Regular,
        FKIsPK, // inherit
        Recursive, // this is child column/property
    }

    /// <summary>
    /// for dataview only
    /// </summary>
    public enum ForeignKeyPropertyCategory
    {
        Ancestor,
        AncestorName,
        AncestorUniqueConstraint
    }

    /// <summary>
    /// add to current
    /// for dataview of current table, but calculated, name can be used in Entity(projection column)
    /// </summary>
    public enum PropertyCategory
    {
        Name,
        CalcuatedName,
        Count,
        Average,
        Max,
        Min,
        Sum,
    }

    public enum Multiplicity
    {

        /// <summary>
        /// 0	No instances (rare)
        /// </summary>
        Noinstances,

        /// <summary>
        /// 0..1	No instances, or one instance
        /// </summary>
        NoInstancesOrOneInstance,

        /// <summary>
        /// 1	Exactly one instance
        /// 1..1	Exactly one instance
        /// </summary>
        ExactlyOneInstance,

        /// <summary>
        /// 0..*	Zero or more instances
        /// *	Zero or more instances
        /// </summary>
        ZeroOrMoreInstances,

        /// <summary>
        /// 1..*	One or more instances
        /// </summary>
        OneOrMoreInstances,
    }

    /// <summary>
    /// http://mark.random-article.com/musings/db-tables.html
    /// </summary>
    public enum TableCategories
    {
        /// <summary>
        /// The core table, e.g. in AdventureWorks2014
        /// Address;BusinessEntity;Person;Product;ProductModel;WorkOrder;PurchaseOrderHeader;Customer;SalesOrderHeader;SpecialOffer;
        /// </summary>
        CoreTable,
        /// <summary>
        /// The details table, e.g. in AdventureWorks2014
        /// AWBuildVersion;DatabaseLog;ErrorLog;EmployeeDepartmentHistory;EmployeePayHistory;JobCandidate;BusinessEntityAddress;BusinessEntityContact;EmailAddress;Password;PersonPhone;BillOfMaterials;ProductCostHistory;ProductDescription;ProductInventory;ProductListPriceHistory;ProductModelIllustration;ProductModelProductDescriptionCulture;ProductPhoto;ProductProductPhoto;ProductReview;TransactionHistory;TransactionHistoryArchive;WorkOrderRouting;ProductVendor;PurchaseOrderDetail;CreditCard;CurrencyRate;PersonCreditCard;SalesOrderDetail;SalesOrderHeaderSalesReason;SalesPersonQuotaHistory;SalesTaxRate;SalesTerritoryHistory;ShoppingCartItem;SpecialOfferProduct;
        /// </summary>
        DetailsTable,
        /// <summary>
        /// The code list table, Lookup Table - FixedSmall, e.g. in AdventureWorks2014
        /// UnitMeasure;ShipMethod;CountryRegionCurrency;Currency;SalesReason;
        /// </summary>
        CodeListTable,
        /// <summary>
        /// The lookup table, Lookup Table - SlowIntermediate or with business meaning, e.g. in AdventureWorks2014
        /// Department;CountryRegion;StateProvince;ProductCategory;ProductSubcategory;
        /// </summary>
        LookupTable,
        /// <summary>
        /// The list table, List Table -- GrowingIntermediate, e.g. in AdventureWorks2014
        /// ScrapReason;Vendor;SalesPerson;SalesTerritory;Store;
        /// </summary>
        ListTable,
        /// <summary>
        /// The cross reference table, e.g. in AdventureWorks2014
        /// BusinessEntityAddress;BusinessEntityContact;PersonCreditCard;
        /// </summary>
        CrossReferenceTable
    }

    /// <summary>
    /// https://www.databasejournal.com/features/oracle/article.php/3616476/Types-of-Tables-in-Oracle.htm
    /// </summary>
    public enum TableTypes
    {
        /// <summary>
        /// The stage table, e.g. in AdventureWorks2014
        /// DatabaseLog;ErrorLog;TransactionHistoryArchive;
        /// </summary>
        StageTable,
        /// <summary>
        /// The operation table, e.g. in AdventureWorks2014
        /// AWBuildVersion;Department;Employee;JobCandidate;Address;BusinessEntity;CountryRegion;Person;StateProvince;Product;ProductModel;Vendor;Customer;SalesOrderDetail;SalesPerson;SpecialOffer;
        /// </summary>
        OperationTable,
        /// <summary>
        /// The functional table, e.g. in AdventureWorks2014
        /// AWBuildVersion;Department;Employee;JobCandidate;Address;BusinessEntity;CountryRegion;Person;StateProvince;Product;ProductModel;Vendor;Customer;SalesOrderDetail;SalesPerson;SpecialOffer;
        /// </summary>
        FunctionalTable,
        /// <summary>
        /// The disposition table, e.g. in AdventureWorks2014
        /// 
        /// </summary>
        DispositionTable,
        /// <summary>
        /// The archive table, e.g. in AdventureWorks2014
        /// Shift;AddressType;BusinessEntityAddress;BusinessEntityContact;ContactType;PhoneNumberType;Culture;Illustration;Location;ProductCategory;ProductInventory;ProductModelIllustration;ProductModelProductDescriptionCulture;ProductProductPhoto;ProductSubcategory;ScrapReason;UnitMeasure;WorkOrder;ProductVendor;PurchaseOrderHeader;ShipMethod;CountryRegionCurrency;Currency;CurrencyRate;PersonCreditCard;SalesOrderHeader;SalesOrderHeaderSalesReason;SalesReason;SalesTaxRate;SalesTerritory;ShoppingCartItem;SpecialOfferProduct;Store;
        /// </summary>
        ArchiveTable,
        /// <summary>
        /// The other table, e.g. in AdventureWorks2014
        /// </summary>
        OtherTable,
    }


    public class A
    {
        public void B ()
        {
        int[] ccc = new int[] { 1, 2 };
            var c = 
                from t in ccc

        }
    }
}