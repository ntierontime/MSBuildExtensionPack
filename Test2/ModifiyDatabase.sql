DROP INDEX IX_Employee_OrganizationLevel_OrganizationNode ON HumanResources.Employee;
GO;

DROP INDEX IX_Employee_OrganizationNode ON HumanResources.Employee;
GO;

ALTER TABLE HumanResources.Employee DROP COLUMN OrganizationLevel;  
GO;

ALTER TABLE HumanResources.Employee DROP COLUMN OrganizationNode;  
GO;

DROP TABLE Production.ProductDocument
GO;

DROP TABLE Production.Document
GO;

ALTER TABLE Person.Address DROP COLUMN SpatialLocation;  
GO;