
using Sitecore.Analytics;
using Sitecore.Analytics.Data.Items;
using System.Net;
using Sitecore.Services.Infrastructure.Web.Http;
using Sitecore.Services.Core;
using System.Web.Http;
using Sitecore;
using M1CP.Foundation.CustomAPI.Authentication;
using M1CP.Foundation.CustomAPI.Repositories;

namespace M1CP.Foundation.CustomAPI.Controllers
{
    [ServicesController]
    public class CustomAPIController : ServicesApiController
    //public class CustomAPIController : ApiController
    {
        /// <summary>
        /// CustomAPI Repository
        /// </summary>
        private ICustomAPIRepository _CustomAPIRepository;

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CustomAPIController()
        {
            this._CustomAPIRepository = new CustomAPIRepository();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomAPIController"/> class.
        /// </summary>
        /// <param name="customAPIRepository">customAPIRepository</param>
        public CustomAPIController(ICustomAPIRepository customAPIRepository)
        {
            this._CustomAPIRepository = customAPIRepository;
        }

        [HttpPost]
        [Route("m1api/TriggerGoal")]
        public IHttpActionResult TrackEvent(string trackingID)
        {

            if (!Tracker.IsActive || Tracker.Current == null)
                Tracker.StartTracking();

            string[] strArray = trackingID.Split('|');

            foreach (var goalId in strArray)
            {
                if (!string.IsNullOrEmpty(goalId))
                {
                    Sitecore.Data.Items.Item GoaltoTrigger = Sitecore.Context.Database.GetItem(goalId);
                    PageEventItem registerthegoal = new PageEventItem(GoaltoTrigger);
                    Sitecore.Analytics.Model.PageEventData eventData = Tracker.Current.CurrentPage.Register(registerthegoal);
                    eventData.Data = GoaltoTrigger["Description"];
                    eventData.ItemId = Sitecore.Context.Item.ID.Guid;
                    eventData.DataKey = Sitecore.Context.Item.Paths.Path;
                    eventData.Name = GoaltoTrigger["Name"];
                    eventData.Value = string.IsNullOrEmpty(GoaltoTrigger["Points"]) ? 0 : System.Convert.ToInt32(GoaltoTrigger["Points"]);
                    Tracker.Current.Interaction.AcceptModifications();
                }
            }

            //return new HttpStatusCodeResult(HttpStatusCode.OK);
            return Ok(HttpStatusCode.OK);
        }

        /// <summary>
        /// ~/m1api/item?id=110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9
        /// returns all fields of item as json response
        /// </summary>
        //[AuthorizedUser(@"sitecore\ServicesAPI")]

        [AuthorizedUser("Author")]
        [HttpGet]
        [Route("m1api/item")]
        public IHttpActionResult GetItem(string id)
        {
            if (_CustomAPIRepository != null)
            {
                var result = _CustomAPIRepository.GetSitecoreItem(id);
                return Ok(result);
            }
            else
                return Ok("Ok!");
        }

        /// <summary>
        /// ~/m1api/getchilditems?pid=0DE95AE4-41AB-4D01-9EB0-67441B7C2450
        /// ~/m1api/getchilditems?pid=0DE95AE4-41AB-4D01-9EB0-67441B7C2450&fields="DisplayName,Price"
        /// returns all child item as json response
        /// </summary>

        [AuthorizedUser("Author")]
        [HttpGet]
        [Route("m1api/getchilditems")]
        public IHttpActionResult GetChildItems(string pid, string fields)
        {
            if (_CustomAPIRepository != null)
            {
                var result = _CustomAPIRepository.GetSitecoreChildItems(pid, fields);
                return Ok(result);
            }
            else
                return Ok("Ok!");

        }

        /// <summary>
        /// ~/m1api/itemrendering?id=110D559F-DEA5-42EA-9C1C-8A5DF7E70EF9&rid=493B3A83-0FA7-4484-8FC9-4680991CF743
        /// returns all fields of all the rendering items
        /// </summary>

        [AuthorizedUser("Author")]
        [HttpGet]
        [Route("m1api/itemrendering")]
        public IHttpActionResult GetItemRendering(string id, string rid)
        {
            if (_CustomAPIRepository != null)
            {
                var result = _CustomAPIRepository.GetSitecoreItemRendering(id, rid);
                return Ok(result);
            }
            else
                return Ok("Ok!");
        }

        /// <summary>
        /// ~/m1api/getmatchingitems?fid=75577384-3C97-45DA-A847-81B00500E250&fvalue=Experience
        /// returns all fields of all the rendering items
        /// </summary>

        [AuthorizedUser("Author")]
        [HttpGet]
        [Route("m1api/getmatchingitems")]
        public IHttpActionResult GetMatchingItems(string fid, string fvalue)
        {
            if (_CustomAPIRepository != null)
            {
                var result = _CustomAPIRepository.GetSitecoreMatchingItems(fid, fvalue);
                return Ok(result);
            }
            else
                return Ok("Ok!");
        }
    }
}