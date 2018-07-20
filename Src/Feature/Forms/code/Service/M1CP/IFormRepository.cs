using M1CP.Feature.Form.Models;
using System.Web;
using Sitecore.Data.Items;
using M1CP.Feature.Forms.Models.M1CP;

namespace M1CP.Feature.Form.Repository
{
    public interface IFormRepository
    {
        /// <summary>
        /// Read form current details from sitecore to create a new form
        /// </summary>
        /// <param name="formId">Sitecore Form Id</param>
        /// <returns></returns>
        IForms LoadForm(Item currentItem);
        /// <summary>
        /// Read form details from sitecore to create a new form by formId
        /// </summary>
        /// <param name="formId">Sitecore Form Id</param>
        /// <returns></returns>
        IForms LoadFormById(Item formId,HttpRequestBase request);

        void SaveToDatabase();




    }
}