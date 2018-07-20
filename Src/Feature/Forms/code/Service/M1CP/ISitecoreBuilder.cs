using M1CP.Feature.Forms.Models.M1CP;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace M1CP.Feature.Forms.Service.M1CP
{
    public interface ISitecoreBuilder 
    {
        IFormValidationBase GetUIElement(Item item);

        IFieldData GetFieldData(Item item);

        IForms GetFormData(Item item);

        IFormButton GetFormButtonData(Item item);

        IFormButtonGroup GetFormButtonGroupData(Item item);

        IFormFieldGroup GetFormFieldGroupData(Item item);

        IFormModel GetFormModelData(Item item);

        IFormUIElements GetFormUIElementsData(Item item);

        IFormValidationBase GetFormValidationBaseData(Item item);


        IListFormField GetListFormFieldData(Item item);

        IListOptionsFormField GetListOptionsFormFieldData(Item item);
    }
}