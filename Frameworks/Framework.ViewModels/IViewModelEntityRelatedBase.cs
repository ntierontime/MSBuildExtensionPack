using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.ViewModels
{
    public interface IViewModelEntityRelatedBase
    {
        Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus StatusOfMasterEntity { get; set; }
        string StatusMessageOfMasterEntity { get; set; }
        Framework.EntityContracts.QueryPagingSetting QueryPagingSetting { get; set; }
        Framework.EntityContracts.QueryPagingSetting QueryPagingSettingOneRecord { get; set; }
    }

    public interface IViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity> : IViewModelEntityRelatedBase
        where TMasterEntity : class, new()
        where TCriteriaOfMasterEntity : class, new()
    {
        TMasterEntity MasterEntity { get; set; }
        TCriteriaOfMasterEntity CriteriaOfMasterEntity { get; set; }
    }
}
