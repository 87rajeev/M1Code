using M1CP.Feature.Forms.Models.M1CP;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using M1CP.Foundation.Base.Repositories;
using M1CP.Feature.Forms.Service.M1CP;

namespace M1CP.Feature.Forms.Repository.M1CP
{
    public class SitecoreBuilder : RepositoryBase , ISitecoreBuilder 
    {
        public IFormValidationBase GetUIElement(Item item)
        {
            return ScContext.Cast<IFormValidationBase>(item);
        }

        public IFieldData GetFieldData(Item item)
        {
            return ScContext.Cast<IFieldData>(item);
        }

        public IForms GetFormData(Item item)
        {
            return ScContext.Cast<IForms>(item);
        }

        public IFormButton GetFormButtonData(Item item)
        {
            return ScContext.Cast<IFormButton>(item);
        }

        public IFormButtonGroup GetFormButtonGroupData(Item item)
        {
            return ScContext.Cast<IFormButtonGroup>(item);
        }

        public IFormEvent GetFormEventData(Item item)
        {
            return ScContext.Cast<IFormEvent>(item);
        }

        public IFormFieldGroup GetFormFieldGroupData(Item item)
        {
            return ScContext.Cast<IFormFieldGroup>(item);
        }

        public IFormModel GetFormModelData(Item item)
        {
            return ScContext.Cast<IFormModel>(item);
        }

        public IFormUIElements GetFormUIElementsData(Item item)
        {
            return ScContext.Cast<IFormUIElements>(item);
        }

        public IFormValidationBase GetFormValidationBaseData(Item item)
        {
            return ScContext.Cast<IFormValidationBase>(item);
        }

        public IListFormField GetListFormFieldData(Item item)
        {
            return ScContext.Cast<IListFormField>(item);
        }

        public IListOptionsFormField GetListOptionsFormFieldData(Item item)
        {
            return ScContext.Cast<IListOptionsFormField>(item);
        }

        public RegexFieldValidation GetRegexFieldData(Item item)
        {
            return ScContext.Cast<RegexFieldValidation>(item);
        }

    }
}